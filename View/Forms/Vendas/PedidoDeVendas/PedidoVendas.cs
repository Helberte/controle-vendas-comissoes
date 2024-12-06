using controle_vendas_comissoes.Model.Db.Entidades;
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

        private void BtBuscaPessoa01_Click(object sender, EventArgs e)
        {
            BuscaPessoas buscaPessoas = new((Pessoa pessoa) =>
            {
                if (boxIdPessoa02.Text.Trim().Equals(pessoa.Id.ToString()))                
                    return;                

                // -----------------------------------------------------------------------------------------

                // verifica se a pessoa é a mesma e remove
                int indexPessoa = this.pessoas.FindIndex(p => p.Id.Equals(pessoa.Id));

                if (indexPessoa >= 0)
                    this.pessoas.RemoveAt(indexPessoa);

                // remove a pessoa que já estava selecionada
                if (!string.IsNullOrEmpty(boxIdPessoa01.Text.Trim()))
                {
                    indexPessoa = this.pessoas.FindIndex(p => p.Id.Equals(Convert.ToInt32(boxIdPessoa01.Text)));

                    if (indexPessoa >= 0)
                        this.pessoas.RemoveAt(indexPessoa);
                }

                // -----------------------------------------------------------------------------------------

                this.pessoas.Add(pessoa);

                boxPessoa01.Text        = pessoa.Nome + " " + pessoa.Sobrenome;
                boxIdPessoa01.Text      = pessoa.Id.ToString();
                lblClassificacao01.Text = string.IsNullOrEmpty(pessoa.Classificacao?.Nome) ? "N/A" : pessoa.Classificacao.Nome;

                comboClassificacoEndereco.Items.Clear();

                foreach (Pessoa item in this.pessoas)                
                    if (!string.IsNullOrEmpty(item.Classificacao?.Nome))
                        comboClassificacoEndereco.Items.Add(item.Classificacao.Nome);            
            });

            buscaPessoas.ShowDialog();
        }

        private void BtBuscaPessoa02_Click(object sender, EventArgs e)
        {
            BuscaPessoas buscaPessoas = new((Pessoa pessoa) =>
            {
                if (boxIdPessoa01.Text.Trim().Equals(pessoa.Id.ToString()))                
                    return;                

                // -----------------------------------------------------------------------------------------

                // verifica se a pessoa é a mesma e remove
                int indexPessoa = this.pessoas.FindIndex(p => p.Id.Equals(pessoa.Id));

                if (indexPessoa >= 0)
                    this.pessoas.RemoveAt(indexPessoa);

                // remove a pessoa que já estava selecionada
                if (!string.IsNullOrEmpty(boxIdPessoa02.Text.Trim()))
                {
                    indexPessoa = this.pessoas.FindIndex(p => p.Id.Equals(Convert.ToInt32(boxIdPessoa02.Text)));

                    if (indexPessoa >= 0)
                        this.pessoas.RemoveAt(indexPessoa);
                }

                // -----------------------------------------------------------------------------------------

                this.pessoas.Add(pessoa);

                boxPessoa02.Text        = pessoa.Nome + " " + pessoa.Sobrenome;
                boxIdPessoa02.Text      = pessoa.Id.ToString();
                lblClassificacao02.Text = string.IsNullOrEmpty(pessoa.Classificacao?.Nome) ? "N/A" : pessoa.Classificacao.Nome;

                comboClassificacoEndereco.Items.Clear();

                foreach (Pessoa item in this.pessoas)
                    if (!string.IsNullOrEmpty(item.Classificacao?.Nome))
                        comboClassificacoEndereco.Items.Add(item.Classificacao.Nome);
            });

            buscaPessoas.ShowDialog();
        }

        private void BtAdicionaProduto_Click(object sender, EventArgs e)
        {
            Classificacao? classificacao = pessoas.Find(p => (p.Classificacao?.Nome ?? "").Equals(comboClassificacoEndereco.SelectedItem?.ToString() ?? ""))?.Classificacao;
            
            if (classificacao is null || classificacao.Id <= 0)            
                MessageBox.Show("É preciso informar uma classificação para que seja possível obter o estado da pessoa que será considerado para os preços.");
            else
            {
                Estado? estado = pessoas.Find(e => (e.Classificacao?.Id).Equals(classificacao.Id))?.Endereco?.Estado;

                if (estado is null || estado.Id <= 0)                
                    MessageBox.Show("Não foi possível obter o estado da pessoa.");
                else
                {
                    List<Classificacao?> pessoasClassificacoes  = pessoas.FindAll(p => p.Classificacao?.Id > 0).Select(x => x.Classificacao).ToList();
                    int[]                arrayIdsClassificacoes = [];

                    PedidoVenda pedidoVenda;

                    if (!string.IsNullOrEmpty(lblPedidoId.Text.Trim()) && Convert.ToInt32(lblPedidoId.Text.Trim()) > 0)                    
                        pedidoVenda = new() { Id = Convert.ToInt32(lblPedidoId.Text.Trim()) };                    
                    else
                    {
                        pedidoVenda = new()
                        {
                            Id                  = 0,
                            Data                = dateTimeDataPedido.Value,
                            Status              = "001", // pendente
                            Total               = 0,
                            PorcentagemDesconto = 0,
                            TotalComDesconto    = 0,
                            ValorDesconto       = 0
                        };
                    }

                    if (pessoasClassificacoes is not null && pessoasClassificacoes.Count > 0)
                    {
                        List<int> idsClassificacoes = [];

                        foreach (Classificacao? item in pessoasClassificacoes)                        
                            if (item is not null && item.Id > 0)                            
                                idsClassificacoes.Add(item.Id);

                        arrayIdsClassificacoes = [.. idsClassificacoes.Distinct()];

                        // ------------------------------------------------------------------------------------------------------------------------ //
                        // ------------------------------------------------------------------------------------------------------------------------ //
                        //                                                                                                                          //
                        //                          MANOBRA para quando tiver uma unica pessoa na venda e ela for GESTORA,                          //
                        //                                       muda a classificação para REPRESENTANTE                                            //
                        //                                          TEMPORÁRIO. ID REPRESENTANTE => 8                                               //
                        //                                                                                                                          //
                        // ------------------------------------------------------------------------------------------------------------------------ //
                        // ------------------------------------------------------------------------------------------------------------------------ //

                        if (arrayIdsClassificacoes.Length == 1 && (pessoasClassificacoes[0]?.Nome ?? "").Equals("GESTORA"))                        
                            arrayIdsClassificacoes[0] = 8;                        
                    }
                    
                    AdicaoProdutos adicaoProdutos = new (estado, pedidoVenda, arrayIdsClassificacoes, pessoas.Select(p => p.Id).Distinct().ToArray());
                    adicaoProdutos.ShowDialog();
                }                
            }
        }

        private void PedidoVendas_Load(object sender, EventArgs e)
        {
            dataGridProdutos.SetStyleDataGridView();
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

        //private void DataGridEstadosPreco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    e.Control.KeyPress -= keyPressEventHandler;
        //    e.Control.TextChanged -= eventHandler;

        //    if (dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoCusto1"].Index
        //        || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoVenda1"].Index
        //        || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoCusto2"].Index
        //        || dataGridEstadosPreco.CurrentCell.ColumnIndex == dataGridEstadosPreco.Columns["PrecoVenda2"].Index)
        //    {
        //        if (e.Control is System.Windows.Forms.TextBox tb)
        //        {
        //            if (tb != null)
        //            {
        //                keyPressEventHandler = new KeyPressEventHandler(CelulaComissao_KeyPress);
        //                eventHandler = new EventHandler(CelulaGrid_TextChanged);

        //                tb.KeyPress += keyPressEventHandler;
        //                tb.TextChanged += eventHandler;
        //            }
        //        }
        //    }
        //}

        //private void DataGridEstadosPreco_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    int estadoId = Convert.ToInt32(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["Id"].Index].Value);
        //    int ordem;
        //    decimal custo;
        //    decimal venda;

        //    if (dataGridEstadosPreco.Columns["PrecoCusto1"].Index == e.ColumnIndex ||
        //        dataGridEstadosPreco.Columns["PrecoVenda1"].Index == e.ColumnIndex)
        //    {
        //        ordem = 1;
        //        custo = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoCusto1"].Index].Value);
        //        venda = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoVenda1"].Index].Value);
        //    }
        //    else
        //    if (dataGridEstadosPreco.Columns["PrecoCusto2"].Index == e.ColumnIndex ||
        //        dataGridEstadosPreco.Columns["PrecoVenda2"].Index == e.ColumnIndex)
        //    {
        //        ordem = 2;
        //        custo = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoCusto2"].Index].Value);
        //        venda = Convert.ToDecimal(dataGridEstadosPreco.CurrentRow.Cells[dataGridEstadosPreco.Columns["PrecoVenda2"].Index].Value);
        //    }
        //    else
        //        return;

        //    AdicionaPrecoProduto(new()
        //    {
        //        EstadoId = estadoId,
        //        Ordem = ordem,
        //        PrecoCusto = custo,
        //        PrecoVenda = venda
        //    });
        //}

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

        #endregion
    }
}
