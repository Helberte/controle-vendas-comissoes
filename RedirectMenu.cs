using controle_vendas_comissoes.View.Forms.Localidades.Estados;
using controle_vendas_comissoes.View.Forms.Localidades.Cidades;

namespace controle_vendas_comissoes
{
    public static class RedirectMenu
    {
        public static void SendEstados()
        {
            EstadosLista rotina = new();
            rotina.ShowDialog();
        }

        public static void SendCidades()
        {
            CidadesLista rotina = new();
            rotina.ShowDialog();
        }
    }
}
 