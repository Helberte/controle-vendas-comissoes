using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using RSG;

namespace controle_vendas_comissoes.Configuracoes.Db.Helpers
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
                            .OrderBy(x => x.CreatedBy)
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
