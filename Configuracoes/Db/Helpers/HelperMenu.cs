using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using Microsoft.EntityFrameworkCore;

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
    }
}
