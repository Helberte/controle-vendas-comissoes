using controle_vendas_comissoes.Model.Db.Entidades;
using RSG;
 
namespace controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Classificacoes
{
    public class HelperClassificacoes
    {
        public static IPromise<List<Classificacao>> ObtemClassificacoes()
        {
            Promise<List<Classificacao>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Classificacoes is not null)
                        promise.Resolve([..
                            context.Classificacoes
                            .OrderByDescending(x => x.CreatedAt)
                            .Take(20)
                            .Select(estado => new Classificacao
                            {
                                Id = estado.Id,
                                Nome = estado.Nome
                            })]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar as Classificações"));
                }
                catch (Exception ex)
                {
                    promise.Reject(ex);
                }
            });

            return promise;
        }
                
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
    }
}
