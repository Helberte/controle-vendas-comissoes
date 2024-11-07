using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.View.Extensions;
using MaterialSkin.Controls;
using System.Windows.Controls;
using System.Windows.Forms;

namespace controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes
{
    public partial class ComissoesConfiguracao : Form
    {
        private static int produtoId = 0;
        private static int estadoId = 0;
        private static bool enviandoRequisicao = false;
        private bool bloqueiaAlteracaoCampo = false;

        #region Construtores

        public ComissoesConfiguracao()
        {
            InitializeComponent();

            ConfiguraLayout();

            DelegaEventos();

            ListarProdutos();
            ListarEstados();
        }

        #endregion

        #region Eventos e Cliques

        private void DataGridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                lblIdProduto.Text = ((DataGridView)sender).SelectedRows[0].Cells["Id"].Value.ToString();
                lblDescricaoProduto.Text = ((DataGridView)sender).SelectedRows[0].Cells["Nome"].Value.ToString();

                produtoId = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["Id"].Value);

                ObtemComissoesProduto();
            }
        }

        private void DataGridEstados_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                estadoId = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["Id"].Value);

                ObtemComissoesProduto();
            }
        }

        #endregion

        #region Métodos

        private void ConfiguraLayout()
        {
            dataGridProdutos.SetStyleDataGridView();
            dataGridEstados.SetStyleDataGridView();
            dataGridComissoes.SetStyleDataGridView();

            dataGridComissoes.ReadOnly = false;
        }

        private static void DelegaEventos()
        {

        }

        #endregion

        #region Requisições

        private void ListarProdutos()
        {
            HelperProdutos.ObtemProdtos().Then(listaProdutos =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.DataSource = listaProdutos;

                    dataGridProdutos.Columns["UnidadePrimaria"].HeaderText = "Unidade Primária";
                    dataGridProdutos.Columns["PrecoCusto1"].HeaderText = "Preço de Custo 1";
                    dataGridProdutos.Columns["PrecoVenda1"].HeaderText = "Preço de Venda 1";
                    dataGridProdutos.Columns["PrecoCusto2"].HeaderText = "Preço de Custo 2";
                    dataGridProdutos.Columns["PrecoVenda2"].HeaderText = "Preço de Venda 2";

                    dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridProdutos.Columns["id"].Width = 60;
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void ListarEstados()
        {
            HelperEstado.ObtemEstados().Then(listaEstados =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridEstados.DataSource = listaEstados;

                    dataGridEstados.Columns["createdAt"].Visible = false;
                    dataGridEstados.Columns["updatedAt"].Visible = false;
                    dataGridEstados.Columns["deletedAt"].Visible = false;
                    dataGridEstados.Columns["createdBy"].Visible = false;
                    dataGridEstados.Columns["updatedBy"].Visible = false;
                    dataGridEstados.Columns["deletedBy"].Visible = false;

                    dataGridEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridEstados.Columns["id"].Width = 60;
                    dataGridEstados.Columns["uf"].Width = 100;

                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void ObtemComissoesProduto()
        {
            if (enviandoRequisicao) return;

            if (!(produtoId > 0 && estadoId > 0)) return;

            enviandoRequisicao = true;

            HelperComissoes.ObtemComissoesProduto(produtoId, estadoId).Then(comissoes =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridComissoes.DataSource = comissoes;

                    dataGridComissoes.Columns["ClassificacaoId"].Visible = false;
                    dataGridComissoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridComissoes.Columns["ClassificacaoNome"].ReadOnly = true;
                    dataGridComissoes.Columns["Porcentagem"].ReadOnly = false;
                    dataGridComissoes.Columns["ValorReal"].ReadOnly = false;

                    enviandoRequisicao = false;
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    enviandoRequisicao = false;

                    MessageBox.Show(erro.Message);
                });
            });
        }

        #endregion

        private void DataGridComissoes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridComissoes.CurrentCell.ColumnIndex == dataGridComissoes.Columns["ValorReal"].Index) //Desired Column
            {
                if (e.Control is System.Windows.Forms.TextBox tb)
                {
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                        tb.TextChanged += new EventHandler(BoxPreco_TextChanged);
                    }  
                }
            }
        }

        private void BoxPreco_TextChanged(object? sender, EventArgs e)
        {
            if (sender is not null)
                FormataCampoDinheiro((System.Windows.Forms.TextBox)sender);
        }

        private void Column1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void FormataCampoDinheiro(System.Windows.Forms.TextBox box)
        {
            try
            {
                if (bloqueiaAlteracaoCampo) return;

                bloqueiaAlteracaoCampo = true;

                decimal valor = 0m;

                if (!string.IsNullOrEmpty(box.Text))
                {
                    valor = Convert.ToDecimal(box.Text.Replace(".", "").Replace(",", "."));
                    valor /= 100;
                }

                if (valor > 0)
                    box.Text = DecimalDInheiroParaString(valor);
                else
                    box.Text = "0,00";

                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
            catch (Exception)
            {
                box.Text = "0,00";
                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
        }

        private string DecimalDInheiroParaString(decimal valor)
        {
            string strValor = valor.ToString();
            string sobra = string.Empty;
            string valorCheio = string.Empty;
            string antesVirgula = string.Empty;

            if (strValor.Split(',').Length > 1)
                sobra = strValor.Split(',')[1];

            if (sobra.Length < 2)
            {
                sobra = sobra.PadRight(2, '0');
                strValor = strValor.Split(',')[0] + "," + sobra;
            }

            antesVirgula = strValor.Split(',')[0].Replace(".", "");

            decimal casas = antesVirgula.Length / 3m;

            if (casas > 1)
            {
                // se for numero com sobra => o inteiro é o número de pontos
                // se for numero redondo   => o inteiro - 1 será o número de pontos

                // números com sobra

                if ((antesVirgula.Length % 3m) > 0)
                {
                    string[] grupos = new string[Convert.ToInt32(Math.Floor(casas)) + 1];
                    string auxiliar = antesVirgula;

                    for (int i = 0; i < Convert.ToInt32(Math.Floor(casas)); i++)
                    {
                        grupos[i] = antesVirgula[(auxiliar.Length - 3)..];

                        auxiliar = antesVirgula[..^3];
                        antesVirgula = auxiliar;

                        if (i + 1 == Convert.ToInt32(Math.Floor(casas)))
                            grupos[i + 1] = auxiliar;
                    }

                    for (int i = grupos.Length - 1; i >= 0; i--)
                    {
                        valorCheio += grupos[i];

                        if (i != 0)
                            valorCheio += ".";
                    }

                    valorCheio += "," + strValor.Split(',')[1];

                    return valorCheio;
                }

                // números sem sobra

                if ((antesVirgula.Length % 3m) == 0)
                {
                    string[] grupos = new string[Convert.ToInt32(casas)];
                    string auxiliar = antesVirgula;

                    for (int i = 0; i < Convert.ToInt32(casas) - 1; i++)
                    {
                        grupos[i] = antesVirgula[(auxiliar.Length - 3)..];

                        auxiliar = antesVirgula[..^3];
                        antesVirgula = auxiliar;

                        if (i + 1 == Convert.ToInt32(casas) - 1)
                            grupos[i + 1] = auxiliar;
                    }

                    for (int i = grupos.Length - 1; i >= 0; i--)
                    {
                        valorCheio += grupos[i];

                        if (i != 0)
                            valorCheio += ".";
                    }

                    valorCheio += "," + strValor.Split(',')[1];

                    return valorCheio;
                }
            }

            return strValor;
        }

    }
}
