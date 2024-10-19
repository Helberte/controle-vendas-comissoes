using controle_vendas_comissoes.View.Forms.Localidades.Estados;

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
 