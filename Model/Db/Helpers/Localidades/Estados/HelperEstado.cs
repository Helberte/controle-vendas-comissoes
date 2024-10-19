using controle_vendas_comissoes.Model.Db.Entidades;
using Microsoft.EntityFrameworkCore;
using RSG;

namespace controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados
{
    public class HelperEstado
    {
        public static IPromise<List<Estado>> ObtemEstados()
        {
            Promise<List<Estado>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Estados is not null)
                        promise.Resolve([..
                            context.Estados
                            .OrderByDescending(x => x.CreatedAt)
                            .Take(20)
                            .Select(estado => new Estado {
                                Id   = estado.Id,
                                Nome = estado.Nome,
                                UF   = estado.UF
                            })]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar os Estados"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }

        public static IPromise<Estado> AdicionaEstado(Estado estado)
        {
            Promise<Estado> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Estados is not null)
                    {
                        // verifica se já existe um estado com este nome
                        List<Estado> estadoExiste = [.. context.Estados.Where(e => EF.Functions.Like(e.Nome, "%" + estado.Nome + "%"))];

                        if (estadoExiste.Count > 0)
                            throw new Exception("Já existe um estado com este nome.\n\nNome: " + estado.Nome);

                        // verifica se já existe um estado com este UF
                        List<Estado> UFExiste = [.. context.Estados.Where(e => EF.Functions.Like(e.UF, "%" + estado.UF + "%"))];

                        if (UFExiste.Count > 0)
                            throw new Exception("Já existe um estado com esta UF.\n\nUF: " + estado.UF);

                        Estado novoEstado = context.Estados.Add(estado).Entity;
                        context.SaveChanges();

                        promise.Resolve(novoEstado);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir um Estado"));
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
