using controle_vendas_comissoes.Cvc.Localidades.Estados.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_vendas_comissoes
{
    public static class RedirectMenu
    {
        public static void SendEstados()
        {
            EstadosLista rotina = new();
            rotina.ShowDialog();
        }
    }
}
 