using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    public partial class ProdutosDeralhes : Form
    {
        private bool bloqueiaAlteracaoCampo = false;

        public ProdutosDeralhes()
        {
            InitializeComponent();
        }

        private void FormataCampoPeso(MaterialTextBox box)
        {
            try
            {
                if (bloqueiaAlteracaoCampo) return;

                bloqueiaAlteracaoCampo = true;

                

                if (!string.IsNullOrEmpty(box.Text))
                {
                    decimal valor = Convert.ToDecimal(box.Text.Replace(",", "").Replace(".", "").Replace("0", ""));

                    valor /= 1000;

                    box.Text = valor.ToString();
                  
                }
                else
                    box.Text = "0,000";

                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
            catch (Exception)
            {
                bloqueiaAlteracaoCampo = false;
            }
        }

        private void boxPeso_TextChanged(object sender, EventArgs e)
        {
            FormataCampoPeso((MaterialTextBox)sender);
        }

        private void boxPeso_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void boxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((MaterialTextBox)sender).Text.Length < 5)
            {
                ((MaterialTextBox)sender).Text = "0,000";
                ((MaterialTextBox)sender).Select(((MaterialTextBox)sender).Text.Length, 0);
            }


        }

        private void boxPeso_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
