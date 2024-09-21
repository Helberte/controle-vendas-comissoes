using controle_vendas_comissoes.Biblioteca.Utils.Modais.Loader;

namespace controle_vendas_comissoes.Biblioteca.Utils
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
                // espera um pouco para a thread principal dar uma respirada
                Thread.Sleep(500);

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
         
        public static void SetEstiloDataGridView(DataGridView dataGridView)
        {
            string nomeFonte = "montserrat";

            // permite que altere a altura do cabeçalho
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO
            dataGridView.EnableHeadersVisualStyles = false;

            // pripriedades para o cabeçalho
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment          = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(247, 247, 247);
            dataGridView.ColumnHeadersDefaultCellStyle.Font               = new Font(nomeFonte, 10, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(0, 89, 83);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(226, 226, 226);

            // ajusta altura da linha do cabeçalho
            dataGridView.ColumnHeadersHeight = 43;

            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(112, 140, 237);

            // mudar de cor quando seleciona a linha / texto
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(222, 232, 248);
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 88, 255);

            // Coloca a cor de fundo nas linhas
            dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 254);
            dataGridView.RowsDefaultCellStyle.Font      = new Font(nomeFonte, 12, FontStyle.Regular);
            dataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(110, 102, 100);

            // configurações para todas as células

            // alinha o conteudo dentro da célula
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // deixa que eu escolha a autura de cada linha, ao invés de ficar por padrão
            dataGridView.AutoSizeRowsMode   = DataGridViewAutoSizeRowsMode.None;

            // altura das linhas
            dataGridView.RowTemplate.Height = 37;

            // indica que o usuário não vai poder editar linhas
            dataGridView.ReadOnly = true;

            //controles do grid completo
            dataGridView.BorderStyle     = BorderStyle.None;
            dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 254);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // estilo da borda do cabeçalho
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersVisible     = true;

            // quando clicar, seleciona a linha inteira
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // o usuário não poderá selecionar muitas linhas
            dataGridView.MultiSelect   = false;

            // retira a primeira coluna 
            dataGridView.RowHeadersVisible = false;

            // retira a ultima linha adicionada automaticamente, é utilizada para adicionar novas linhas
            dataGridView.AllowUserToAddRows = false;

            // não deixa o usuário deletar as linhas do grid
            dataGridView.AllowUserToDeleteRows = false;
        }
    }
}
