﻿using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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

        public static IPromise<ComissaoItem> AdicionaComissao(
            int produtoId, 
            int estadoId,
            int classificacaoId,
            decimal porcentagem,
            decimal valorReal,
            decimal valorRealAnterior,
            decimal porcentagemAnterior
            )
        {
            Promise<ComissaoItem> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    ComissaoItem? comissaoItem;

                    if (context.Comissao is not null && context.EstadoComissao is not null && context.ComissaoItem is not null)
                    {
                        string sql = string.Format(@"
                        select ValorReal      = ISNULL(valor_real,  0)
                             , Porcentagem    = ISNULL(porcentagem, 0)
                             , ComissaoItemId = comissao_item.id
                         
                          from (
                                select comissaoId = comissao.id
                                  from (
                                        select classificacaoId   = classificacao.id
                                          from classificacao
                                         where classificacao.deleted_at is null
                                           and classificacao.id = {0}
                                       ) as TB
                         
                                   inner
                                    join comissao
                                      on comissao.deleted_at is null
                                     and comissao.classificacao_id = TB.classificacaoId
                         
                                   inner
                                    join estado_comissao
                                      on estado_comissao.deleted_at is null
                                     and estado_comissao.comissao_id = comissao.id
                                     and estado_comissao.estado_id   = {1}
                               ) as TB2
                            inner
                             join comissao_item
                               on comissao_item.deleted_at is null
                              and comissao_item.comissao_id = comissaoId
                              and comissao_item.produto_id  = {2}; ", classificacaoId, estadoId, produtoId);

                        List<ModelProdutoComissao>? resultado = context.Database.SqlQuery<ModelProdutoComissao>(FormattableStringFactory.Create(sql)).ToList();

                        // atualiza comissão existente
                        if (resultado is not null && resultado.Count > 0)
                        {
                            if (resultado.Count > 1)
                                throw new Exception("Inconsistência ao atualizar a comissão do produto, tente novamente!");

                            ModelProdutoComissao comissao = resultado[0];

                            if (!comissao.ValorReal.Equals(valorRealAnterior))
                                throw new Exception("O valor foi alterado por outra pessoa, atualize a grid e tente novamente.");

                            if (!comissao.Porcentagem.Equals(porcentagemAnterior))
                                throw new Exception("A porcentagem foi alterado por outra pessoa, atualize a grid e tente novamente.");

                            comissaoItem = context.ComissaoItem.Where(c => c.Id.Equals(comissao.ComissaoItemId)).FirstOrDefault();

                            if (comissaoItem is null)
                                throw new Exception("Comissão Item não encontrada.");

                            comissaoItem.UpdatedAt   = DateTime.Now;
                            comissaoItem.ValorReal   = valorReal;
                            comissaoItem.Porcentagem = porcentagem;

                            context.SaveChanges();
                        } 
                        else
                        {
                            Comissao comissao = new()
                            {
                                ClassificacaoId = classificacaoId
                            };

                            Comissao novaComissao = context.Comissao.Add(comissao).Entity;
                            context.SaveChanges();

                            EstadoComissao estadoComissao = new()
                            {
                                ComissaoId = novaComissao.Id,
                                EstadoId   = estadoId
                            };

                            context.EstadoComissao.Add(estadoComissao);
                            context.SaveChanges();

                            comissaoItem = new()
                            {
                                Porcentagem = porcentagem,
                                ValorReal   = valorReal,
                                ProdutoId   = produtoId,
                                ComissaoId  = novaComissao.Id
                            };

                            context.ComissaoItem.Add(comissaoItem);
                            context.SaveChanges();
                        }

                        transaction.Commit();

                        promise.Resolve(comissaoItem);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir uma Nova Comissao"));
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