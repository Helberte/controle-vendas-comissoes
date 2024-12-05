using controle_vendas_comissoes.Model.Db.Entidades;
using RSG;

namespace controle_vendas_comissoes.Model.Db.Helpers.Produtos.UnidadesDeProdutos
{
    public class HelperUnidadePrimaria
    {
        public static IPromise<List<UnidadePrimaria>> ObtemUnidadesPrimarias()
        {
            Promise<List<UnidadePrimaria>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.UnidadesPrimarias is not null)
                        promise.Resolve([..
                            context.UnidadesPrimarias
                            .OrderByDescending(x => x.CreatedAt)
                            .Select(unidades => new UnidadePrimaria
                            {
                                Id    = unidades.Id,
                                Nome  = unidades.Nome,
                                Sigla = unidades.Sigla
                            })]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar as Unidades Primarias"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
        
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
    }
}
