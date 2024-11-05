using controle_vendas_comissoes.View.Forms.Modais;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace controle_vendas_comissoes.Controller.Utils
{
    public static class Utils
    {
        private static Thread? ThreadModalCarregando;
        private static ModalCarregando? modalCarregamento;

        public static void RunOnUiThread(Control controle, Action action)
        {
            try
            {
                controle.BeginInvoke(action);
            }
            catch (Exception)
            {

            }            
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

        public static void ValidaCPF(string CPF)
        {
            string mensagem = "O CPF é inválido";

            if (string.IsNullOrEmpty(CPF))
                throw new Exception(mensagem);

            int soma_1     = 0;
            int soma_2     = 0;
            decimal restoDiv_1 = 0m;
            decimal restoDiv_2 = 0m;
            int contador_1 = 0;

            int[] array_1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
            int[] array_2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

            string cpfLimpo       = CPF;
            string cpfValidacao_2 = "";

            if (cpfLimpo.Length != 11)
                throw new Exception(mensagem);

            // ------------------------------------------------------------------------------------------------

            for (int i = 0; i < cpfLimpo.Length; i++)            
                if (cpfLimpo[0] == cpfLimpo[i])
                    contador_1++;            

            if (contador_1 == 11)
                throw new Exception(mensagem);

            // ------------------------------------------------------------------------------------------------

            for (int i = 0; i < array_1.Length; i++)            
                soma_1 += (Convert.ToInt32(cpfLimpo[i].ToString()) * array_1[i]);
            
            restoDiv_1 = (soma_1 * 10) % 11;

            if (restoDiv_1 == 10) restoDiv_1 = 0;

            // 1° Validação
            if (Convert.ToInt32(cpfLimpo[9].ToString()) != restoDiv_1)
                throw new Exception(mensagem);

            // ------------------------------------------------------------------------------------------------

            cpfValidacao_2 = cpfLimpo[..9] + restoDiv_1.ToString();

            for (int i = 0; i < array_2.Length; i++)
                soma_2 += (Convert.ToInt32(cpfValidacao_2[i].ToString()) * array_2[i]);

            restoDiv_2 = (soma_2 * 10) % 11;

            if (restoDiv_2 == 10) restoDiv_2 = 0;

            // 2° Validação
            if (Convert.ToInt32(cpfLimpo[10].ToString()) != restoDiv_2)
                throw new Exception(mensagem);
        }
    
        public static decimal FormataDecimalMonetario(decimal valor)
        {
            try
            {
                return Convert.ToDecimal(valor % 1 == 0 ? valor.ToString("0.00") : valor.ToString("0.##"));
            }
            catch (Exception)
            {
                return valor;
            }            
        }

        public static decimal FormataPorcentagem(decimal valor)
        {
            try
            {
                return Convert.ToDecimal(valor.ToString("0.####"));
            }
            catch (Exception)
            {
                return valor;
            }
        }

        public static int ProcuraValorDataGridView(DataGridView dataGridView, string coluna, string valor)
        {
            try
            {
                DataGridViewRow row = dataGridView.Rows.Cast<DataGridViewRow>().Where((r) =>
                {
                    if (r.Cells[coluna].Value.ToString() == valor)
                    {
                        return true;
                    }
                    return false;

                }).First();

                return row.Index;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
