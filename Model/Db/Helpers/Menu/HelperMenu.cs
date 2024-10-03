using RSG;

namespace controle_vendas_comissoes.Model.Db.Helpers.Menu
{
    public class HelperMenu
    {
        public static IPromise<List<Model.Db.Entidades.Menu>> ObtemMenus()
        {
            Promise<List<Model.Db.Entidades.Menu>> promise = new();

            Task.Run(() =>
            {
                try
                {
                    using AppDbContext context = new();

                    if (context.Menus is not null)
                        promise.Resolve([.. context.Menus]);
                    else
                        promise.Reject(new Exception("Ocorreu um erro ao buscar os menus"));
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
