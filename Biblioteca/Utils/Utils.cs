
namespace controle_vendas_comissoes.Biblioteca.Utils
{    
    public static class Utils
    {
        public static void RunOnUiThread(Control controle, Action action)
        {
            controle.BeginInvoke(action);
        }      
    }
}
