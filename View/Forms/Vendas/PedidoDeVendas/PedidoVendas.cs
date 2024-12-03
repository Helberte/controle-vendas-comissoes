using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;
using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas
{
    public partial class PedidoVendas : Form
    {
        #region Variaveis

        private bool bloqueiaAlteracaoCampo = false;

        private static Action? action = null;
        private List<TabelaPreco> listaTabelasPrecos = [];
        private List<Pessoa> pessoas = [];

        private UnidadePrimaria? unidadePrimaria = null;
        KeyPressEventHandler? keyPressEventHandler;
        EventHandler? eventHandler;

        #endregion

        #region Construtores

        public PedidoVendas()
        {
            InitializeComponent();

            DelegaEventos();
        }

        #endregion

        #region Métodos

        private void ValidaCampos()
        {
            
        }

        private void DelegaEventos()
        {
            
        }

        private void LimpaCampos()
        {
            
        }

        private static void LimpaCampos(GroupBox Group)
        {
           
        }

        private static void DesativaControles(GroupBox Group)
        {
           
        }

        private static void AtivaControles(GroupBox Group)
        {
            
        }

        private void SetPessoa(Pessoa pessoa, MaterialTextBox boxNome, Label lblClassificacao)
        {
            this.pessoas.Add(pessoa);

            boxNome.Text          = pessoa.Nome + " " + pessoa.Sobrenome;
            lblClassificacao.Text = string.IsNullOrEmpty(pessoa.Classificacao?.Nome) ? "N/A" : pessoa.Classificacao.Nome;
        }

        private string DecimalPesoParaString(decimal valor)
        {
            string strValor = valor.ToString();
            string sobra = string.Empty;

            if (strValor.Split(',').Length > 1)
                sobra = strValor.Split(',')[1];

            if (sobra.Length < 3)
            {
                sobra = sobra.PadRight(3, '0');
                strValor = strValor.Split(',')[0] + "," + sobra;
            }

            return strValor;
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

        private void FormataCampoDinheiro(MaterialTextBox box)
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

        private void FormataCampoPeso(MaterialTextBox box)
        {
            try
            {
                if (bloqueiaAlteracaoCampo) return;

                bloqueiaAlteracaoCampo = true;

                decimal valor = 0m;

                if (!string.IsNullOrEmpty(box.Text))
                {
                    valor = Convert.ToDecimal(box.Text.Replace(",", "").Replace(".", ""));
                    valor /= 1000;
                }

                if (valor > 0)
                    box.Text = DecimalPesoParaString(valor);
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

        private void FormataCampoDinheiro(System.Windows.Forms.TextBox box, decimal valorMaximo = 0)
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
                {
                    // se existir um valor máximo, considera ele
                    if (valorMaximo > 0 && valor > valorMaximo)
                        valor = valorMaximo;

                    box.Text = DecimalDInheiroParaString(valor);
                }
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


        #endregion

        #region Eventos e Cliques Keypress

        private void ProdutosDetalhes_Load(object sender, EventArgs e)
        {            
            dataGridProdutos.SetStyleDataGridView();
        }

        private void BtUnidadePrimaria_Click(object? sender, EventArgs e)
        {
            BuscaUnidadesPrimarias buscaUnidades = new(SetPropriedades);
            buscaUnidades.ShowDialog();

            boxUnidadePrimaria.Focus();
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

        private void BoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void BoxPreco_TextChanged(object sender, EventArgs e)
        {
            FormataCampoDinheiro((MaterialTextBox)sender);
        }

        private void BtNovo_Click(object? sender, EventArgs e)
        {
            LimpaCampos(groupInfoProduto);

            AtivaControles(groupInfoProduto);
            AtivaControles(groupInfoFisica);

            boxNomeProduto.Focus();
            dataGridEstadosPreco.Rows.Clear();
        }

        private void DataGridEstadosPreco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= keyPressEventHandler;
            e.Control.TextChanged -= eventHandler;

            if (dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoCusto1"].Index
                || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoVenda1"].Index
                || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoCusto2"].Index
                || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoVenda2"].Index)
            {
                if (e.Control is System.Windows.Forms.TextBox tb)
                {
                    if (tb != null)
                    {
                        keyPressEventHandler = new KeyPressEventHandler(CelulaComissao_KeyPress);
                        eventHandler = new EventHandler(CelulaGrid_TextChanged);

                        tb.KeyPress += keyPressEventHandler;
                        tb.TextChanged += eventHandler;
                    }
                }
            }
        }

        private void DataGridEstadosPreco_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int estadoId = Convert.ToInt32(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["Id"].Index].Value);
            int ordem;
            decimal custo;
            decimal venda;

            if (dataGridEstadosPreco.Columns["PrecoCusto1"].Index == e.ColumnIndex ||
                dataGridEstadosPreco.Columns["PrecoVenda1"].Index == e.ColumnIndex)
            {
                ordem = 1;
                custo = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoCusto1"].Index].Value);
                venda = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoVenda1"].Index].Value);
            }
            else
            if (dataGridEstadosPreco.Columns["PrecoCusto2"].Index == e.ColumnIndex ||
                dataGridEstadosPreco.Columns["PrecoVenda2"].Index == e.ColumnIndex)
            {
                ordem = 2;
                custo = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoCusto2"].Index].Value);
                venda = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoVenda2"].Index].Value);
            }
            else
                return;

            AdicionaPrecoProduto(new()
            {
                EstadoId = estadoId,
                Ordem = ordem,
                PrecoCusto = custo,
                PrecoVenda = venda
            });
        }

        private void CelulaGrid_TextChanged(object? sender, EventArgs e)
        {
            if (sender is not null)
                FormataCampoDinheiro((System.Windows.Forms.TextBox)sender);
        }

        private void CelulaComissao_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;
        }

        #endregion

        #region Requisições

        private void AdicionaPoduto()
        {
            try
            {
                if (novoProduto is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperProdutos.AdicionaProduto(novoProduto).Then(produto =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        boxIdProduto.Text = produto.Id.ToString();

                        MessageBox.Show("Produto inserido com sucesso!");

                        action?.Invoke();
                    });
                }).Catch(erro =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show(erro.Message);
                    });
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ObterPrecosProdutoEstados()
        {
            if (string.IsNullOrEmpty(boxIdProduto.Text.Trim())) return;

            HelperProdutos.ObtemPrecosProduto(Convert.ToInt32(boxIdProduto.Text.Trim()), 0).Then(estadosPreco =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridEstadosPreco.DataSource = estadosPreco;
                    dataGridEstadosPreco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridEstadosPreco.Columns["id"].Width = 60;

                    dataGridEstadosPreco.ReadOnly = false;

                    dataGridEstadosPreco.Columns["Id"].ReadOnly = true;
                    dataGridEstadosPreco.Columns["Nome"].ReadOnly = true;
                    dataGridEstadosPreco.Columns["UF"].ReadOnly = true;
                    dataGridEstadosPreco.Columns["PrecoCusto1"].ReadOnly = false;
                    dataGridEstadosPreco.Columns["PrecoVenda1"].ReadOnly = false;
                    dataGridEstadosPreco.Columns["PrecoCusto2"].ReadOnly = false;
                    dataGridEstadosPreco.Columns["PrecoVenda2"].ReadOnly = false;
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void AdicionaPrecoProduto(TabelaPreco tabelaPreco)
        {
            if (string.IsNullOrEmpty(boxIdProduto.Text.Trim())) return;

            HelperProdutos.AdicionaPrecoProduto(Convert.ToInt32(boxIdProduto.Text.Trim()), tabelaPreco)
            .Then(preco => { })
            .Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        #endregion       
    }
}
