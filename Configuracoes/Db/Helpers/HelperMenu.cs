using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using Microsoft.EntityFrameworkCore;
using RSG;

namespace controle_vendas_comissoes.Configuracoes.Db.Helpers
{
    public class HelperMenu
    {
        public async Task<List<Menu>> ListaMenus()
        {
            using AppDbContext context = new();
            List<Menu> menus = [];

            if (context.Menus is not null)
            {
                menus = await context.Menus.ToListAsync();
            }

            return menus;            
        }     

        public static IPromise<List<Menu>> ObtemMenus()
        {
            Promise<List<Menu>> promise = new();

            Task.Run(() =>
            {
                try
                {        
                    using AppDbContext context = new();
                    List<Menu> menus = [];

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
