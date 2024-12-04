using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RSG;
using System.Runtime.CompilerServices;

namespace controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos
{
    public class HelperProdutos
    {
        public static IPromise<List<Produto>> ObtemProdutos(string textoFind = "")
        {
            Promise<List<Produto>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Produtos is not null)
                        promise.Resolve([..
                            context.Produtos    
                            .OrderByDescending(x => x.CreatedAt)
                            .Take(20)
                            .Select(produto => new Produto
                            {
                                Id              = produto.Id,
                                Nome            = produto.Nome,
                                Descricao       = produto.Descricao,
                                Composicao      = produto.Composicao,
                                ModoUsar        = produto.ModoUsar,
                                UnidadePrimaria = produto.UnidadePrimaria
                            })]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar os produtos."));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

        public static IPromise<List<ModelProdutoEstadoPreco>> ObtemPrecosProduto(int produtoId, int estadoId = 0)
        {
            Promise<List<ModelProdutoEstadoPreco>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                        SELECT Id          = estado.id
                             , Nome        = estado.nome
                             , UF          = estado.UF
                             , PrecoCusto1 = ISNULL(PRECO1.custo, 0)
                             , PrecoVenda1 = ISNULL(PRECO1.venda, 0)
                             , PrecoCusto2 = ISNULL(PRECO2.custo, 0)
                             , PrecoVenda2 = ISNULL(PRECO2.venda, 0)
                        
                          FROM estado
                        
                          OUTER
                          APPLY (
                                   SELECT custo = CAST(tabela_preco.preco_custo AS DECIMAL(10,4))
                                        , venda = CAST(tabela_preco.preco_venda AS DECIMAL(10,4))
                        
                                     FROM produto_tabela_preco
                        
                                    INNER
                                     JOIN tabela_preco
                                       ON tabela_preco.deleted_at IS NULL
                                      AND tabela_preco.id        = produto_tabela_preco.tabela_preco_id
                                      AND tabela_preco.ordem     = 1
                                      AND tabela_preco.estado_id = estado.id
                        
                                    WHERE produto_tabela_preco.deleted_at IS NULL
                                      AND produto_tabela_preco.produto_id = {0}
                              )
                             AS PRECO1
                        
                          OUTER
                          APPLY (
                                   SELECT custo = CAST(tabela_preco.preco_custo AS DECIMAL(10,4))
                                        , venda = CAST(tabela_preco.preco_venda AS DECIMAL(10,4))
                        
                                     FROM produto_tabela_preco
                        
                                    INNER
                                     JOIN tabela_preco
                                       ON tabela_preco.deleted_at IS NULL
                                      AND tabela_preco.id    = produto_tabela_preco.tabela_preco_id
                                      AND tabela_preco.ordem = 2
                                      AND tabela_preco.estado_id = estado.id
                        
                                    WHERE produto_tabela_preco.deleted_at IS NULL
                                      AND produto_tabela_preco.produto_id = {0}
                                )
                                AS PRECO2
                        
                          WHERE estado.deleted_at IS NULL
                            " + (estadoId > 0 ? " AND estado.id = {1} " : "") +                             
                        
                          @" ORDER
                                BY estado.nome;", produtoId, estadoId);

                    List<ModelProdutoEstadoPreco>? resultado = context.Database.SqlQuery<ModelProdutoEstadoPreco>(FormattableStringFactory.Create(sql)).ToList();

                    promise.Resolve(resultado);
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

        public static IPromise<Produto> AdicionaProduto(Produto produto)
        {
            Promise<Produto> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext          context     = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    if (context.Produtos is not null && context.UnidadesPrimarias is not null)
                    {
                        Produto? novoProduto   = null;           
                        Produto? produtoExiste = context.Produtos.Where(e => e.Nome.Equals(produto.Nome)).FirstOrDefault();

                        if (produtoExiste is not null)                       
                            if (produtoExiste.Nome.Equals(produto.Nome))
                                throw new Exception("Já existe um Produto cadastrado com este Nome.");

                        UnidadePrimaria? unidadePrimaria = context.UnidadesPrimarias.Where(u => u.Id.Equals(produto.UnidadePrimariaId)).FirstOrDefault();

                        if (unidadePrimaria is null)
                            throw new Exception("A unidade primária informada não existe. Cadastre ela primeiro.");

                        // insere novo PRODUTO
                        novoProduto = context.Produtos.Add(produto).Entity;

                        context.SaveChanges();
                        
                        transaction.Commit();

                        promise.Resolve(novoProduto);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir um novo produto"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
         
        public static IPromise<List<ModelProdutoPreco>> AdicionaPrecoProduto(int produtoId, TabelaPreco tabelaPreco)
        {
            Promise<List<ModelProdutoPreco>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    string sql = string.Format(@"
                        SELECT TabelaPrecoId        = tabela_preco.id
                             , ProdutoTabelaPrecoId = produto_tabela_preco.id
                             , Ordem                = tabela_preco.ordem
                             , PrecoCusto           = ISNULL(tabela_preco.preco_custo, 0)
                             , PrecoVenda           = ISNULL(tabela_preco.preco_venda, 0)
                         
                          FROM produto_tabela_preco
                         
                         INNER
                          JOIN produto
                            ON produto.deleted_at IS NULL
                           AND produto.id = produto_tabela_preco.produto_id
                         
                         INNER
                          JOIN tabela_preco
                            ON tabela_preco.deleted_at IS NULL
                           AND tabela_preco.id = produto_tabela_preco.tabela_preco_id
                         
                         INNER
                          JOIN estado
                            ON estado.deleted_at IS NULL
                           AND estado.id = tabela_preco.estado_id
                           AND estado.id = {0}
                         
                         WHERE produto_tabela_preco.deleted_at IS NULL
                           AND produto_tabela_preco.produto_id = {1}
                         
                         GROUP
                            BY tabela_preco.id
                             , produto_tabela_preco.id
                             , tabela_preco.ordem
                             , tabela_preco.preco_custo
                             , tabela_preco.preco_venda;", tabelaPreco.EstadoId, produtoId);

                    List<ModelProdutoPreco>? resultado = context.Database.SqlQuery<ModelProdutoPreco>(FormattableStringFactory.Create(sql)).ToList();

                    if (    context.ProdutoTabelaPrecos is not null 
                        &&  context.TabelaPrecos is not null 
                        &&  context.Estados is not null
                        &&  context.Produtos is not null )
                    {
                        // se não existir nenhuma tabela de preços ou se a ordem não existir
                        if (resultado.Count == 0 || resultado.FindAll(o => o.Ordem == tabelaPreco.Ordem).Count() <= 0)
                        {
                            Estado? estado = context.Estados.Where(e => e.Id.Equals(tabelaPreco.EstadoId)).FirstOrDefault();

                            if (estado == null)
                                throw new Exception("O Estado informado não existe");

                            TabelaPreco novaTabPreco = context.TabelaPrecos.Add(new TabelaPreco()
                            {
                                PrecoCusto  = tabelaPreco.PrecoCusto,
                                PrecoVenda  = tabelaPreco.PrecoVenda,
                                EstadoId    = tabelaPreco.EstadoId,
                                Ordem       = tabelaPreco.Ordem
                            }).Entity;

                            context.SaveChanges();

                            context.ProdutoTabelaPrecos.Add(new ProdutoTabelaPreco()
                            {
                                ProdutoId     = produtoId,
                                TabelaPrecoId = novaTabPreco.Id,
                            });

                            context.SaveChanges();
                        }
                        else
                        {
                            List<ModelProdutoPreco>? tabelaExistente = resultado.FindAll(t => t.Ordem == tabelaPreco.Ordem);

                            if (tabelaExistente is null || tabelaExistente.Count > 1)
                                throw new Exception("Inconsistencia ao buscar a tabela de preços");

                            TabelaPreco?        tabela        = context.TabelaPrecos.Where(t => t.Id == tabelaExistente[0].TabelaPrecoId).FirstOrDefault();
                            ProdutoTabelaPreco? produtoTabela = context.ProdutoTabelaPrecos.Where(t => t.Id == tabelaExistente[0].ProdutoTabelaPrecoId).FirstOrDefault();

                            if (tabela is null || produtoTabela is null)
                                throw new Exception("Inconsistencia ao buscar a tabela de preços especificada");

                            if (tabela.PrecoCusto != tabelaPreco.PrecoCusto)
                            {
                                tabela.PrecoCusto = tabelaPreco.PrecoCusto;
                                tabela.UpdatedAt  = DateTime.Now;
                            }

                            if (tabela.PrecoVenda != tabelaPreco.PrecoVenda)
                            {
                                tabela.PrecoVenda = tabelaPreco.PrecoVenda;
                                tabela.UpdatedAt  = DateTime.Now;
                            }

                            context.SaveChanges();
                        }
                    }

                    transaction.Commit();

                    promise.Resolve(resultado);
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

        public static IPromise<List<ModelPrecosPorEstado>> ObtemPrecosPorEstado(int estadoId, string textoPesquisa = "")
        {
            Promise<List<ModelPrecosPorEstado>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                    SELECT ProdutoId           = produtoId
                         , ProdutoNome         = produtoNome
                         , UnidadePrimariaNome = unidadePrimariaNome
                         , PrecoCusto1         = ISNULL(PRECO1.custo, 0)
                         , PrecoVenda1         = ISNULL(PRECO1.venda, 0)
                         , PrecoCusto2         = ISNULL(PRECO2.custo, 0)
                         , PrecoVenda2         = ISNULL(PRECO2.venda, 0)
                     
                      FROM (
                            SELECT TOP 20
                                   produtoId           = produto.id
                                 , produtoNome         = produto.nome
                                 , unidadePrimariaNome = unidade_primaria.nome
                     
                              FROM produto
                     
                             INNER
                              JOIN unidade_primaria
                                ON unidade_primaria.deleted_at IS NULL
                               AND unidade_primaria.id = produto.unidade_primaria_id
                     
                             WHERE produto.deleted_at IS NULL
                               AND CONCAT(  produto.nome           + ' '
                                          , produto.descricao      + ' '
                                          , produto.id             + ' '
                                          , produto.composicao     + ' '
                                          , produto.modo_usar      + ' '
                                          , unidade_primaria.nome  + ' '
                                          , produto.peso ) LIKE '%{0}%'
                           ) AS TB
                     
                     OUTER
                     APPLY (
                              SELECT custo = CAST(tabela_preco.preco_custo AS DECIMAL(10,4))
                                   , venda = CAST(tabela_preco.preco_venda AS DECIMAL(10,4))
                     
                                FROM produto_tabela_preco
                     
                               INNER
                                JOIN tabela_preco
                                  ON tabela_preco.deleted_at IS NULL
                                 AND tabela_preco.id        = produto_tabela_preco.tabela_preco_id
                                 AND tabela_preco.ordem     = 1
                                 AND tabela_preco.estado_id = {1}
                     
                               WHERE produto_tabela_preco.deleted_at IS NULL
                                 AND produto_tabela_preco.produto_id = produtoId
                         )
                        AS PRECO1
                     
                     OUTER
                     APPLY (
                              SELECT custo = CAST(tabela_preco.preco_custo AS DECIMAL(10,4))
                                   , venda = CAST(tabela_preco.preco_venda AS DECIMAL(10,4))
                     
                                FROM produto_tabela_preco
                     
                               INNER
                                JOIN tabela_preco
                                  ON tabela_preco.deleted_at IS NULL
                                 AND tabela_preco.id        = produto_tabela_preco.tabela_preco_id
                                 AND tabela_preco.ordem     = 2
                                 AND tabela_preco.estado_id = {1}
                     
                               WHERE produto_tabela_preco.deleted_at IS NULL
                                 AND produto_tabela_preco.produto_id = produtoId
                         )
                        AS PRECO2
                     
                     ORDER
                        BY ProdutoNome;", textoPesquisa, estadoId);

                    List<ModelPrecosPorEstado>? resultado = context.Database.SqlQuery<ModelPrecosPorEstado>(FormattableStringFactory.Create(sql)).ToList();

                    promise.Resolve(resultado);
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
    }
}
