using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    public partial class ProdutosDetalhes : Form
    {
        private bool bloqueiaAlteracaoCampo = false;

        public ProdutosDetalhes()
        {
            InitializeComponent();
        }

        private string DecimalParaString(decimal valor)
        {
            string strValor = valor.ToString();
            string sobra    = string.Empty;

            if (strValor.Split(',').Length > 1 )
                sobra = strValor.Split(',')[1];

            if (sobra.Length < 3 )
            {
                sobra    = sobra.PadRight(3, '0');
                strValor = strValor.Split(',')[0] + "," + sobra;
            }

            return strValor;
        }

        private void FormataCampoPeso(MaterialTextBox box)
        {
            try
            {
                if (bloqueiaAlteracaoCampo) return;

                bloqueiaAlteracaoCampo = true;

                #region Limpa o Texto 

                string texto        = box.Text;
                string novoTexto    = "";
                bool   achouVirgula = false;

                foreach (char caracter in texto)
                {
                    if (char.IsDigit(caracter))
                        novoTexto += caracter;
                    else
                    if (caracter == ',' && !achouVirgula)
                    {
                        novoTexto   += caracter;
                        achouVirgula = true;
                    }
                }

                // Atualiza o texto do campo somente se houve mudança
                if (novoTexto != texto)
                    box.Text   = novoTexto;

                #endregion

                decimal valor = 0m;

                if (!string.IsNullOrEmpty(box.Text))
                {
                    valor  = Convert.ToDecimal(box.Text.Replace(",", "").Replace(".", ""));
                    valor /= 1000;
                }

                if (valor > 0)
                    box.Text = DecimalParaString(valor);
                else
                    box.Text = "0,000";

                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
            catch (Exception)
            {
                box.Text = "0,000";
                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
        }

        private void BoxPeso_TextChanged(object sender, EventArgs e)
        {
            FormataCampoPeso((MaterialTextBox)sender);
        }

        private void BoxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))            
                e.Handled = true;
        }
    }
}
