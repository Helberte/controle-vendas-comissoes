namespace controle_vendas_comissoes.Biblioteca.Extensions
{
    public static class DataGridViewExtension
    {
        public static void SetStyleDataGridView(this DataGridView Sender)
        {
            string nomeFonte = "montserrat";

            // permite que altere a altura do cabeçalho
            Sender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // ESTA PROPRIEDADE PERMITE ALTERAR OS ESTILOS PARA O CABEÇALHO
            Sender.EnableHeadersVisualStyles = false;

            // pripriedades para o cabeçalho
            Sender.ColumnHeadersDefaultCellStyle.Alignment          = DataGridViewContentAlignment.MiddleCenter;
            Sender.ColumnHeadersDefaultCellStyle.BackColor          = Color.FromArgb(247, 247, 247);
            Sender.ColumnHeadersDefaultCellStyle.Font               = new Font(nomeFonte, 10, FontStyle.Bold);
            Sender.ColumnHeadersDefaultCellStyle.ForeColor          = Color.FromArgb(0, 89, 83);
            Sender.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 226, 226);

            // ajusta altura da linha do cabeçalho
            Sender.ColumnHeadersHeight = 43;

            Sender.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            Sender.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 140, 237);

            // mudar de cor quando seleciona a linha / texto
            Sender.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 232, 248);
            Sender.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 88, 255);

            // Coloca a cor de fundo nas linhas
            Sender.RowsDefaultCellStyle.BackColor   = Color.FromArgb(255, 255, 254);
            Sender.RowsDefaultCellStyle.Font        = new Font(nomeFonte, 12, FontStyle.Regular);
            Sender.RowsDefaultCellStyle.ForeColor   = Color.FromArgb(110, 102, 100);

            // configurações para todas as células

            // alinha o conteudo dentro da célula
            Sender.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // deixa que eu escolha a autura de cada linha, ao invés de ficar por padrão
            Sender.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // altura das linhas
            Sender.RowTemplate.Height = 37;

            // indica que o usuário não vai poder editar linhas
            Sender.ReadOnly = true;

            //controles do grid completo
            Sender.BorderStyle     = BorderStyle.None;
            Sender.BackgroundColor = Color.FromArgb(255, 255, 254);
            Sender.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // estilo da borda do cabeçalho
            Sender.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Sender.ColumnHeadersVisible     = true;

            // quando clicar, seleciona a linha inteira
            Sender.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // o usuário não poderá selecionar muitas linhas
            Sender.MultiSelect = false;

            // retira a primeira coluna 
            Sender.RowHeadersVisible = false;

            // retira a ultima linha adicionada automaticamente, é utilizada para adicionar novas linhas
            Sender.AllowUserToAddRows = false;

            // não deixa o usuário deletar as linhas do grid
            Sender.AllowUserToDeleteRows = false;
        }
    }
}
