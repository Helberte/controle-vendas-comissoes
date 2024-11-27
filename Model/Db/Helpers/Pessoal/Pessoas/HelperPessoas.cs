using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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
                               [Id]                     = TB.id
                             , [Nome]                   = TB.nome
                             , [Sobrenome]              = sobrenome
                             , [Cpf]                    = cpf
                             , [Rg]                     = rg
                             , [DataNascimento]         = dataNascimento
                             , [ClassificacaoId]        = ISNULL(classificacaoId,    0)
                             , [ClassificacaoDescricao] = ISNULL(classificacaoNome, '')
                             , [CreatedAt]              = pessoaCreatedAt
                             , [EnderecoId]             = ISNULL(enderecoId ,  0)
                             , [EstadoNome]             = ISNULL(estado.nome , '')
                             , [EstadoUF]               = ISNULL(estado.UF , '')
                             , [CidadeNome]             = ISNULL(cidade.nome , '')
                             , [CidadeSigla]            = ISNULL(cidade.sigla , '')
                             , [CEP]                    = ISNULL(cep , '')
                             , [Rua]                    = ISNULL(rua , '')
                             , [Numero]                 = ISNULL(numero , '')
                             , [bairro]                 = ISNULL(bairro , '')
                        
                          FROM (
                                SELECT id   = pessoa.id
                                     , nome = pessoa.nome
                                     , sobrenome
                                     , cpf
                                     , rg
                                     , dataNascimento    = data_nascimento
                                     , pessoaCreatedAt   = pessoa.created_at
                                     , enderecoId        = endereco_id
                                     , classificacaoId   = classificacao.id
                                     , classificacaoNome = classificacao.nome
                        
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
                               ) AS TB
                        
                               LEFT
                               JOIN endereco
                                 ON endereco.deleted_at IS NULL
                                AND endereco.id = enderecoId
                        
                               LEFT
                               JOIN estado
                                 ON estado.deleted_at IS NULL
                                AND estado.id = endereco.estado_id
                        
                               LEFT
                               JOIN cidade
                                 ON cidade.deleted_at IS NULL
                                AND cidade.id = endereco.cidade_id
                        
                              ORDER
                                 BY CreatedAt DESC; ", textoFind);

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
                
        public static IPromise<Pessoa> AdicionaPessoa(Pessoa pessoa, Endereco? endereco)
        {
            Promise<Pessoa> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext          context     = new();
                    using IDbContextTransaction transaction = context.Database.BeginTransaction();                  

                    if (context.Pessoas is not null && context.Enderecos is not null)
                    {
                        Endereco? novoEndereco = null;
                        Pessoa?   pessoaExiste = context.Pessoas.Where(e => (e.Nome.Equals(pessoa.Nome) && e.Sobrenome.Equals(pessoa.Sobrenome)) ||
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
