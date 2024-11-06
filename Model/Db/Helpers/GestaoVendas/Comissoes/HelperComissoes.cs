using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using RSG;
using System.Runtime.CompilerServices;

namespace controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes
{
    public class HelperComissoes
    {
        public static IPromise<List<ModelComissoesProduto>> ObtemComissoesProduto(int produtoId, int estadoId)
        {
            Promise<List<ModelComissoesProduto>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                        SELECT ClassificacaoId   = TB.classificacaoId
						     , ClassificacaoNome = TB.classificacaoNome
							 , ValorReal		 = ISNULL(valosReal, 0)
							 , Porcentagem		 = ISNULL(porcentagem, 0)
						
						  FROM (
						  		SELECT classificacaoId   = classificacao.id
						  			 , classificacaoNome = classificacao.nome
						  		  FROM classificacao
						  		 WHERE classificacao.deleted_at IS NULL
							   ) AS TB
						
							LEFT 
							JOIN (	
									SELECT classificacaoId = comissao.classificacao_id
									     , valosReal	   = valor_real
									     , porcentagem	   = porcentagem
										 
									  FROM comissao_item
									
									 inner 
									  join produto
									    on produto.deleted_at is null
									   and produto.id = comissao_item.produto_id
									   and produto.id = {0}
									
									 inner 
									  join comissao
									    on comissao.deleted_at is null
									   and comissao.id = comissao_item.comissao_id
									
									 inner 
									  join estado_comissao
									    on estado_comissao.deleted_at is null
									   and estado_comissao.Comissao_id = comissao.id
									   and estado_comissao.estado_id   = {1}		  
									  
									 WHERE comissao_item.deleted_at is null
									
									 group 
									    by comissao.classificacao_id
										 , valor_real
										 , porcentagem
							)
							AS TB2
							ON TB.classificacaoId = TB2.classificacaoId; ", produtoId, estadoId);

                    List<ModelComissoesProduto>? resultado = context.Database.SqlQuery<ModelComissoesProduto>(FormattableStringFactory.Create(sql)).ToList();

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
