using controle_vendas_comissoes.Model.Db.Entidades;
using Microsoft.EntityFrameworkCore;
using RSG;

namespace controle_vendas_comissoes.Model.Db.Helpers.Localidades.Cidades
{
    public class HelperCidade
    {
        public static IPromise<List<Cidade>> ObtemCidades()
        {
            Promise<List<Cidade>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Cidades is not null)
                        promise.Resolve([..
                            context.Cidades
                            .OrderByDescending(x => x.CreatedAt)
                            .Take(20)
                            .Select(estado => new Cidade
                            {
                                Id    = estado.Id,
                                Nome  = estado.Nome,
                                Sigla = estado.Sigla
                            })]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar as Cidades"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

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
        }
    }
}
