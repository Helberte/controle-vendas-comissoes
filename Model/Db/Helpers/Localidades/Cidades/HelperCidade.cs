using controle_vendas_comissoes.Model.Db.Entidades;
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

    }
}
