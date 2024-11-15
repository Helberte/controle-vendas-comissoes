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

        public static IPromise<Produto> AdicionaProduto(Produto produto, List<TabelaPreco> tabelasPrecos)
        {
            Promise<Produto> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext          context     = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    if (   context.Produtos            is not null 
                        && context.ProdutoTabelaPrecos is not null 
                        && context.TabelaPrecos        is not null
                        && context.UnidadesPrimarias   is not null)
                    {
                        Produto?                 novoProduto           = null;                       
                        List<ProdutoTabelaPreco> produtosTabelasPrecos = [];
                        Produto?                 produtoExiste         = context.Produtos.Where(e => (e.Nome.Equals(produto.Nome))).FirstOrDefault();

                        if (produtoExiste is not null)                       
                            if (produtoExiste.Nome.Equals(produto.Nome))
                                throw new Exception("Já existe um Produto cadastrado com este Nome.");

                        UnidadePrimaria? unidadePrimaria = context.UnidadesPrimarias.Where(u => u.Id.Equals(produto.UnidadePrimariaId)).FirstOrDefault();

                        if (unidadePrimaria is null)
                            throw new Exception("A unidade primária informada não existe. Cadastre ela primeiro.");

                        // insere novo PRODUTO
                        novoProduto = context.Produtos.Add(produto).Entity;

                        context.SaveChanges();

                        // insere as tabelas de preços
                        context.TabelaPrecos.AddRange(tabelasPrecos);

                        context.SaveChanges();

                        foreach (TabelaPreco item in tabelasPrecos)
                        {
                            if (item is null || item.Id <= 0)
                                throw new Exception("Existe uma inconsistência ao gravar o produto.");

                            produtosTabelasPrecos.Add(new ProdutoTabelaPreco() { ProdutoId = produto.Id, TabelaPrecoId = item.Id });
                        }

                        // insere o relacionamento do produto com a tabela de preço
                        context.ProdutoTabelaPrecos.AddRange(produtosTabelasPrecos);

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
    }
}
