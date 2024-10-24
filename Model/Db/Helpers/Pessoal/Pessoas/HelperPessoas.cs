using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using RSG;
using System.Runtime.CompilerServices;

namespace controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Pessoas
{
    public class HelperPessoas
    {
        public static IPromise<List<ModelPessoasLista>> ObtemPessoas(string textoFind = "")
        {
            Promise<List<ModelPessoasLista>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    string sql = string.Format(@"
                        SELECT TOP 20
                               [Id]				        = pessoa.id
                             , [Nome]			        = pessoa.nome
                             , [Sobrenome]
                             , [Cpf]
                             , [Rg]
                             , [DataNascimento]         = data_nascimento
                             , [CreatedAt]              = pessoa.created_at
                             , [EnderecoId]             = endereco_id
                        	 , [ClassificacaoId]        = classificacao.id
                        	 , [ClassificacaoDescricao] = ISNULL(classificacao.nome, '')
                        
                          FROM pessoa
                        
                          LEFT 
                          JOIN classificacao
                            ON classificacao.deleted_at IS NULL
                           AND classificacao.id = pessoa.classificacao_id
                        
                         WHERE pessoa.deleted_at IS NULL
                           AND CONCAT( pessoa.nome + ' '
                        			 , sobrenome   + ' '
                        			 , pessoa.id   + ' '
                        			 , cpf         + ' '
                        			 , rg          + ' '
                        			 , CONVERT(VARCHAR, data_nascimento, 103)) LIKE '%{0}%'
                        
                         ORDER 
                            BY pessoa.created_at DESC ", textoFind);

                    List<ModelPessoasLista>? resultado = context.Database.SqlQuery<ModelPessoasLista>(FormattableStringFactory.Create(sql)).ToList();

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
        public static IPromise<Cidade> AdicionaCidade(Cidade cidade)
        {
            Promise<Cidade> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Cidades is not null)
                    {
                        List<Cidade> cidadeExiste = [.. context.Cidades.Where(e => EF.Functions.Like(e.Nome, "%" + cidade.Nome + "%"))];

                        if (cidadeExiste.Count > 0)
                            throw new Exception("Já existe uma cidade com este nome.\n\nNome: " + cidade.Nome);

                        List<Cidade> siglaExiste = [.. context.Cidades.Where(e => EF.Functions.Like(e.Sigla, "%" + cidade.Sigla + "%"))];

                        if (siglaExiste.Count > 0)
                            throw new Exception("Já existe uma cidade com esta sigla.\n\nSigla: " + cidade.Sigla);

                        // verifica se o estado informado existe
                        Estado? estadoExiste = (context.Estados?.Where(e => e.Id == cidade.EstadoId).FirstOrDefault()) ?? throw new Exception("O Estado Informado não existe.\nId do Estado: " + cidade.EstadoId);

                        // adiciona a cidade
                        Cidade novaCidade = context.Cidades.Add(cidade).Entity;
                        context.SaveChanges();

                        promise.Resolve(novaCidade);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir uma Cidade"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }*/
    }
}
