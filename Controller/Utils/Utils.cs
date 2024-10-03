using controle_vendas_comissoes.View.Forms.Modais;

namespace controle_vendas_comissoes.Controller.Utils
{
    public static class Utils
    {
        private static Thread? ThreadModalCarregando;
        private static ModalCarregando? modalCarregamento;

        public static void RunOnUiThread(Control controle, Action action)
        {
            controle.BeginInvoke(action);
        }

        public static void ExibeCarregando(Control control)
        {
            int x = control.Location.X + (control.Width / 2);
            int y = control.Location.X + (control.Height / 2);

            control.Enabled = false;

            ThreadModalCarregando = new Thread(() =>
            {
                modalCarregamento = new();

                modalCarregamento.Location = new Point(x - (modalCarregamento.Width / 2), y - (modalCarregamento.Height / 2));

                // Executa o formulário de carregamento em uma thread separada
                Application.Run(modalCarregamento);
            });

            ThreadModalCarregando.SetApartmentState(ApartmentState.STA); // Necessário para Windows Forms
            ThreadModalCarregando.Start();
        }

        public static void EscondeCarregando(Action? action = null)
        {
            Task.Run(() =>
            {
                if (modalCarregamento != null && modalCarregamento.InvokeRequired)
                {
                    // Invoca o fechamento do formulário na thread do UI
                    Utils.RunOnUiThread(modalCarregamento, () =>
                    {
                        modalCarregamento.Close();
                        modalCarregamento.Dispose();
                        modalCarregamento = null;
                    });
                }
                else
                {
                    modalCarregamento?.Close();
                    modalCarregamento?.Dispose();
                    modalCarregamento = null;
                }
            });
            action?.Invoke();

            // Espera a thread terminar antes de prosseguir
            ThreadModalCarregando?.Join();
        }
    }
}
