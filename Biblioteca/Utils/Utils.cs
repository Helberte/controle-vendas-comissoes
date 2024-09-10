using controle_vendas_comissoes.Biblioteca.Utils.Modais.Loader;

namespace controle_vendas_comissoes.Biblioteca.Utils
{    
    public static class Utils
    {
        private static Thread? loadingThread;
        private static ModalCarregando? modalLoad;

        public static void RunOnUiThread(Control controle, Action action)
        {
            controle.Invoke(action);
        }

        public static void ExibeCarregando(Control control)
        {
            int x = control.Location.X + (control.Width / 2);
            int y = control.Location.X + (control.Height / 2);

            loadingThread = new Thread(() =>
            {
                modalLoad = new();

                modalLoad.Location = new Point(x - (modalLoad.Width / 2), y - (modalLoad.Height / 2));

                // Executa o formulário de carregamento em uma thread separada
                Application.Run(modalLoad);
            });

            loadingThread.SetApartmentState(ApartmentState.STA); // Necessário para Windows Forms
            loadingThread.Start();
        }

        // Método para fechar o modal de carregamento
        public static void EscondeCarregando(Action? action = null)
        { 
            if (modalLoad != null && modalLoad.InvokeRequired)
            {
                // Invoca o fechamento do formulário na thread do UI
                modalLoad.Invoke(() =>
                {
                    modalLoad.Close();

                });
            }
            else
            {
                modalLoad?.Close();

            }

            action?.Invoke();

            // Espera a thread terminar antes de prosseguir
            loadingThread?.Join();
        }
    }
}
