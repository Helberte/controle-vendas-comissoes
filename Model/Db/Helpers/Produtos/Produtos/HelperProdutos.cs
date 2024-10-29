using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
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
                        		      AND tabela_preco.id = produto_tabela_preco.tabela_preco_id
                        		    
                        		    WHERE produto_tabela_preco.deleted_at IS NULL
                        		      AND produto_tabela_preco.produto_id = TB.id
                        		      AND produto_tabela_preco.ordem      = 1	
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
                        		      AND tabela_preco.id = produto_tabela_preco.tabela_preco_id
                        		    
                        		    WHERE produto_tabela_preco.deleted_at IS NULL
                        		      AND produto_tabela_preco.produto_id = TB.id
                        		      AND produto_tabela_preco.ordem      = 2	
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
        /*
        public static IPromise<UnidadePrimaria> AdicionaUnidadePrimaria(UnidadePrimaria unidadePrimaria)
        {
            Promise<UnidadePrimaria> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.UnidadesPrimarias is not null)
                    {
                        UnidadePrimaria? unidadeExiste = context.UnidadesPrimarias.Where(e => e.Nome.Equals(unidadePrimaria.Nome.Trim().ToUpper())
                                                                                           || e.Sigla.ToUpper().Trim().Equals(unidadePrimaria.Sigla.ToUpper().Trim())).FirstOrDefault();

                        if (unidadeExiste is not null)
                        {
                            if (unidadeExiste.Nome.ToUpper().Trim().Equals(unidadePrimaria.Nome.ToUpper().Trim()))
                                throw new Exception("Já existe uma Unidade Primária com este nome.\n\nNome: " + unidadePrimaria.Nome);

                            if (unidadeExiste.Sigla.ToUpper().Trim().Equals(unidadePrimaria.Sigla.ToUpper().Trim()))
                                throw new Exception("Já existe uma Unidade Primária com esta sigla.\n\nSigla: " + unidadePrimaria.Sigla);
                        }

                        UnidadePrimaria novaUnidade = context.UnidadesPrimarias.Add(unidadePrimaria).Entity;
                        context.SaveChanges();

                        promise.Resolve(novaUnidade);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir uma Unidade Primária"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
        */
    }
}
