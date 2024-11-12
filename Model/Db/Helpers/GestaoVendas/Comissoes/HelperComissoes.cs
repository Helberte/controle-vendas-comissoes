using controle_vendas_comissoes.Model.Db.Entidades;
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

        public static IPromise<ModelComissoesProduto> AdicionaPessoa(Pessoa pessoa, Endereco? endereco)
        {
            Promise<ModelComissoesProduto> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();

                    if (context.Pessoas is not null && context.Enderecos is not null)
                    {
                        Endereco? novoEndereco = null;
                        Pessoa? pessoaExiste = context.Pessoas.Where(e => (e.Nome.Equals(pessoa.Nome) && e.Sobrenome.Equals(pessoa.Sobrenome)) ||
                                                                             e.Cpf.Equals(pessoa.Cpf) ||
                                                                             e.Rg.Equals(pessoa.Rg)).FirstOrDefault();

                        if (pessoaExiste is not null)
                        {
                            if (pessoaExiste.Nome.Equals(pessoa.Nome) && pessoaExiste.Sobrenome.Equals(pessoa.Sobrenome))
                                throw new Exception("Já existe uma pessoa cadastrada com este nome e sobrenome.");

                            if (pessoaExiste.Cpf.Equals(pessoa.Cpf))
                                throw new Exception("Já existe uma pessoa cadastrada com este CPF.");

                            if (pessoaExiste.Rg.Equals(pessoa.Rg))
                                throw new Exception("Já existe uma pessoa cadastrada com este RG.");
                        }

                        if (pessoa.ClassificacaoId is not null && pessoa.ClassificacaoId > 0)
                        {
                            Classificacao? classificacao = context.Classificacoes?.Where(c => c.Id == pessoa.ClassificacaoId).FirstOrDefault();

                            if (classificacao is null)
                                throw new Exception("A classificação informada nou foi encontrada.");
                        }

                        // endereço
                        if (endereco is not null && !string.IsNullOrEmpty(endereco.Rua))
                        {
                            Estado? estado = context.Estados?.Where(e => e.Id == endereco.EstadoId).FirstOrDefault();

                            if (estado is null)
                                throw new Exception("O estado informado não existe!");

                            Cidade? cidade = context.Cidades?.Where(c => c.Id == endereco.CidadeId).FirstOrDefault();

                            if (cidade is null)
                                throw new Exception("A cidade informada não existe!");

                            if (!cidade.EstadoId.Equals(estado.Id))
                                throw new Exception("Esta cidade não pertence a este estado, favor, escolha uma que pertença");

                            // insere novo endereço
                            novoEndereco = context.Enderecos.Add(endereco).Entity;

                            context.SaveChanges();
                        }

                        if (novoEndereco is not null && novoEndereco.Id > 0)
                            pessoa.EnderecoId = novoEndereco.Id;

                        // adiciona a cidade
                        Pessoa novaPessoa = context.Pessoas.Add(pessoa).Entity;
                        context.SaveChanges();

                        transaction.Commit();

                        promise.Resolve(novaPessoa);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir uma Nova Pessoa"));
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
