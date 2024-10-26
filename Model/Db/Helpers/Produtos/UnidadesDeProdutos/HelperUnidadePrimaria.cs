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
                            .Take(20)
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
        /*
        public static IPromise<Classificacao> AdicionaClassificacao(Classificacao classificacao)
        {
            Promise<Classificacao> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Classificacoes is not null)
                    {
                        Classificacao? classificacaoExiste = context.Classificacoes.Where(e => e.Nome.Equals(classificacao.Nome.Trim().ToUpper())).FirstOrDefault();

                        if (classificacaoExiste is not null)
                            throw new Exception("Já existe uma classificação com este nome.\n\nNome: " + classificacao.Nome);

                        Classificacao novaClassificacao = context.Classificacoes.Add(classificacao).Entity;
                        context.SaveChanges();

                        promise.Resolve(novaClassificacao);
                    }
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao Inserir uma Classificação"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
        */
    }
}
