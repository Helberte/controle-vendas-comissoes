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
        public static IPromise<List<ModelProdutosLista>> ObtemProdtos(string textoFind = "")
        {
            Promise<List<ModelProdutosLista>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                        SELECT Id			   = TB.id
                             , Nome			   = TB.nome
                        	 , UnidadePrimaria = unidade_primaria.nome
                        	 , PrecoCusto1	   = ISNULL( PRECO1.custo, 0)
                        	 , PrecoVenda1	   = ISNULL( PRECO1.venda, 0)
                        	 , PrecoCusto2	   = ISNULL( PRECO2.custo, 0)
                        	 , PrecoVenda2	   = ISNULL( PRECO2.venda, 0)
                        
                          FROM (
                        		SELECT TOP 20 
                        		       id				 = produto.id	
                        			 , nome				 = produto.nome
                        			 , unidadePrimariaId = unidade_primaria_id
                        		  FROM produto
                        		 WHERE produto.deleted_at IS NULL
                        		   AND CONCAT( produto.nome		 + ' '
                        				     , produto.descricao + ' '
                        					 , modo_usar		 + ' '
                        					 , CAST(peso AS VARCHAR) + ' ') LIKE '%{0}%'
                        	   ) 
                        	  AS TB
                        
                           INNER 
                            JOIN unidade_primaria
                        	  ON unidade_primaria.deleted_at IS NULL
                        	 AND unidade_primaria.id = TB.unidadePrimariaId
                        
                           OUTER 
                           APPLY (
                        		   SELECT custo = CAST(tabela_preco.preco_custo AS DECIMAL(10,4))
                        		        , venda = CAST(tabela_preco.preco_venda AS DECIMAL(10,4))
                        		   
                        		     FROM produto_tabela_preco
                        		   
                        		    INNER 
                        		     JOIN tabela_preco
                        		       ON tabela_preco.deleted_at IS NULL
                        		      AND tabela_preco.id    = produto_tabela_preco.tabela_preco_id
                        		      AND tabela_preco.ordem = 1	

                        		    WHERE produto_tabela_preco.deleted_at IS NULL
                        		      AND produto_tabela_preco.produto_id = TB.id

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

                        		    WHERE produto_tabela_preco.deleted_at IS NULL
                        		      AND produto_tabela_preco.produto_id = TB.id
                        		      
                        	     )
                        		AS PRECO2
                        
                        	 ORDER 
                        	    BY TB.nome", textoFind);

                    List<ModelProdutosLista>? resultado = context.Database.SqlQuery<ModelProdutosLista>(FormattableStringFactory.Create(sql)).ToList();

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
