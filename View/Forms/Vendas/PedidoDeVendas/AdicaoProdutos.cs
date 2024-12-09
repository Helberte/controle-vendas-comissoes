using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.Model.Db.Helpers.Vendas;
using controle_vendas_comissoes.Model.Db.Models;
using controle_vendas_comissoes.View.Extensions;
using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas
{
    public partial class AdicaoProdutos : Form
    {
        #region Variaveis

        private static bool bloqueiaAlteracaoCampo = false;

        private readonly Estado? estado;
        private static int produtoId = 0;
        private int[] classificacoes = [];
        private int[] pessoasIds = [];

        private static int quantidadeRowsSelecionadasGridItensVenda = 0;
        private PedidoVenda venda;

        #endregion

        #region Construtores

        public AdicaoProdutos(Estado estado, PedidoVenda venda, int[] classificacoes, int[] pessoasIds)
        {
            InitializeComponent();

            this.estado = estado;
            this.classificacoes = classificacoes;
            this.pessoasIds = pessoasIds;
            this.venda = venda;

            DelegaEventos();
            CarregaEstadoTela();

            ListarProdutos();
        }

        #endregion

        #region Métodos

        private void CarregaEstadoTela()
        {
            lblNomeEstado.Text = this.estado?.Nome ?? "N/A";
        }

        private void ValidaCampos()
        {

        }

        private void DelegaEventos()
        {

        }

        private void LimpaCampos()
        {

        }

        private void ZeraCamposDesconto()
        {
            bloqueiaAlteracaoCampo = true;
            boxDesconto.Text = "0,00";
            boxValorDesconto.Text = "0,00";
            bloqueiaAlteracaoCampo = false;
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

        private void FormataCampoDinheiro(MaterialTextBox box, decimal valorMaximo = 0, Action<decimal>? action = null)
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

                action?.Invoke(valor);
            }
            catch (Exception)
            {
                box.Text = "0,00";
                box.Select(box.Text.Length, 0);

                bloqueiaAlteracaoCampo = false;
            }
        }

        private void AdicionaTotaisComissaoTela(string nome, decimal tComissao, decimal tTotal)
        {
            foreach (Control item in groupBoxTotaisClassificacoes.Controls)
            {
                if (item is Label label && label.Text.Equals(nome))
                {
                    foreach (Control controle in groupBoxTotaisClassificacoes.Controls)
                    {
                        if (controle is Label texto)
                            if (texto.Tag is not null && texto.Tag.Equals(nome + "01"))
                                texto.Text = tComissao.ToString();
                    }

                    foreach (Control controle in groupBoxTotaisClassificacoes.Controls)
                    {
                        if (controle is Label texto)
                            if (texto.Tag is not null && texto.Tag.Equals(nome + "02"))
                                texto.Text = tTotal.ToString();
                    }

                    return;
                }
            }

            Label nomeComissao = new() { AutoSize = true };

            Label totalComissao = new() { AutoSize = true };
            Label totalComissaoValor = new() { AutoSize = true, Tag = nome + "01" };

            Label total = new() { AutoSize = true };
            Label totalValor = new() { AutoSize = true, Tag = nome + "02" };

            total.Tag = "ultimo";

            int altura = 27;

            nomeComissao.Text = nome;
            nomeComissao.Font = new Font("montserrat", 10, FontStyle.Bold);

            foreach (Control item in groupBoxTotaisClassificacoes.Controls)
            {
                if (item is Label label)
                {
                    if (label.Tag is not null)
                    {
                        if (label.Tag.ToString() == "ultimo")
                            altura = (label.Location.Y + label.Height + 6);
                    }
                }
            }

            groupBoxTotaisClassificacoes.Controls.Add(nomeComissao);
            nomeComissao.Location = new Point(6, altura);

            totalComissao.Text = "Total Comissão:";
            totalComissao.Font = new Font("montserrat", 10, FontStyle.Regular);
            groupBoxTotaisClassificacoes.Controls.Add(totalComissao);
            totalComissao.Location = new Point(6, nomeComissao.Location.Y + nomeComissao.Height + 5);

            totalComissaoValor.Text = tComissao.ToString();
            totalComissaoValor.Font = new Font("montserrat", 10, FontStyle.Bold);
            groupBoxTotaisClassificacoes.Controls.Add(totalComissaoValor);
            totalComissaoValor.Location = new Point(totalComissao.Location.X + totalComissao.Width + 5, totalComissao.Location.Y);

            total.Text = "Total:";
            total.Font = new Font("montserrat", 10, FontStyle.Regular);
            groupBoxTotaisClassificacoes.Controls.Add(total);
            total.Location = new Point(6, totalComissaoValor.Location.Y + totalComissaoValor.Height + 3);

            totalValor.Text = tTotal.ToString();
            totalValor.Font = new Font("montserrat", 10, FontStyle.Bold);
            groupBoxTotaisClassificacoes.Controls.Add(totalValor);
            totalValor.Location = new Point(totalComissaoValor.Location.X, total.Location.Y);
        }

        private void AtualizaTotaisComissoes()
        {
            foreach (int classificacao in classificacoes)
                ObtemTotaisComissaoClassificacaoVenda(classificacao);
        }

        private void ColunasSomenteLeituraGridProdutosVenda()
        {
            foreach (DataGridViewColumn item in dataGridProdutosVenda.Columns)
            {
                if (item.Name.Equals("check") ||
                    item.Name.Equals("Quantidade") ||
                    item.Name.Equals("PorcentagemDesconto") ||
                    item.Name.Equals("ValorDesconto"))
                    item.ReadOnly = false;
                else
                    item.ReadOnly = true;
            }
        }

        private void AtualizaTotalRowsSelecionadas(int total)
        {
            lblQuantidadeSelecionada.Text = total.ToString();
            quantidadeRowsSelecionadasGridItensVenda = total;

            btExcluirMarcados.Enabled = !total.Equals(0);

            if (total.Equals(0))
                checkBoxMarcarTodos.Checked = false;
        }

        #endregion

        #region Eventos e Cliques Keypress

        private void AdicaoProdutos_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.SetStyleDataGridView(25, 40, 8, 8);
                    dataGridComissaoClassificacao.SetStyleDataGridView(25, 40, 8, 8);

                    DataGridViewCheckBoxColumn columnCheck = new()
                    {
                        Name = "check",
                        HeaderText = "Ação",
                        Width = 50,
                        FillWeight = 10
                    };
                    dataGridProdutosVenda.Columns.Add(columnCheck);

                    dataGridProdutosVenda.SetStyleDataGridView(25, 40, 8, 8, false);
                });
            });
        }

        private void DataGridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                lblIdProdutoSelecionado.Text = ((DataGridView)sender).SelectedRows[0].Cells["ProdutoId"].Value.ToString();
                lblProdutoSelecionado.Text = ((DataGridView)sender).SelectedRows[0].Cells["ProdutoNome"].Value.ToString();

                produtoId = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["ProdutoId"].Value);

                ZeraCamposDesconto();

                ObtemComissoesProduto();
            }
        }

        private void BoxTextoPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string texto = ((MaterialTextBox)sender).Text.Trim();

                ListarProdutos(texto);
            }
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorUnidade = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells["PrecoVenda1"].Value.ToString());

                if (string.IsNullOrEmpty(boxQuantidade.Text.Trim()) || Convert.ToDecimal(boxQuantidade.Text.Trim()) <= 0m)
                    throw new Exception("Está sem quantidade de produtos.");

                if (valorUnidade <= 0)
                    throw new Exception("Não existe valor de venda configurado para este produto. Por favor, configure o valor a ser vendido.");

                // ---------------------------------------------------------------------------------------------------------------------------------------

                decimal quantidadeProduto = Convert.ToDecimal(boxQuantidade.Text.Trim());
                decimal valorDesconto = string.IsNullOrEmpty(boxValorDesconto.Text.Trim()) ? 0m : Convert.ToDecimal(boxValorDesconto.Text.Trim());
                decimal porcentagemDesconto = string.IsNullOrEmpty(boxDesconto.Text.Trim()) ? 0m : Convert.ToDecimal(boxDesconto.Text.Trim());

                AdicionaProdutoVenda(valorUnidade, quantidadeProduto, valorDesconto, porcentagemDesconto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BoxValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;

            if (string.IsNullOrEmpty(boxQuantidade.Text.Trim()) || Convert.ToDecimal(boxQuantidade.Text.Trim()) <= 0)
                e.Handled = true;
        }

        private void BtExcluirMarcados_Click(object sender, EventArgs e)
        {
            string     produtosRemover   = "";
            int        pedidoVendaItemId = 0;
            List<int>  idsItensVenda     = [];

            for (int i = 0; i < dataGridProdutosVenda.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell? celula = dataGridProdutosVenda.Rows[i].Cells[0] as DataGridViewCheckBoxCell;

                if (celula != null && Convert.ToBoolean(celula.Value))
                {
                    produtosRemover += dataGridProdutosVenda.Rows[i].Cells[dataGridProdutosVenda.Columns["ProdutoNome"].Index].Value.ToString() ?? "";
                    produtosRemover += " - Quantidade: " + dataGridProdutosVenda.Rows[i].Cells[dataGridProdutosVenda.Columns["Quantidade"].Index].Value.ToString();
                    produtosRemover += "\n";

                    pedidoVendaItemId = Convert.ToInt32(dataGridProdutosVenda.Rows[i].Cells[dataGridProdutosVenda.Columns["PedidoVendaItemId"].Index].Value.ToString() ?? "0");

                    if (pedidoVendaItemId.Equals(0))
                        throw new Exception("Existe um item que está sem o Id.");
                    else
                        idsItensVenda.Add(pedidoVendaItemId);
                }                
            }

            if (!string.IsNullOrEmpty(produtosRemover))
            {
                if (MessageBox.Show("Deseja remover da venda estes produtos?\n\n" + produtosRemover, 
                    "Atenção! Excluir produtos da venda",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeletaProdutosVenda([.. idsItensVenda]);
                }
            }            
        }

        private void BoxValorDesconto_TextChanged(object sender, EventArgs e)
        {
            decimal valorUnidade = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells["PrecoVenda1"].Value.ToString());

            FormataCampoDinheiro((MaterialTextBox)sender, valorUnidade, (valorDesconto) =>
            {
                decimal valorUnidade = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells["PrecoVenda1"].Value.ToString());

                decimal total = (valorDesconto * 100) / valorUnidade;

                bloqueiaAlteracaoCampo = true;
                boxDesconto.Text = total.ToString();
                bloqueiaAlteracaoCampo = false;
            });
        }

        private void BoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void BoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            MaterialTextBox box = (MaterialTextBox)sender;

            if (string.IsNullOrEmpty(box.Text) || Convert.ToDecimal(box.Text.Trim()) <= 0)
            {
                boxDesconto.Text = string.Empty;
                boxValorDesconto.Text = string.Empty;
            }
        }

        private void BoxDesconto_TextChanged(object sender, EventArgs e)
        {
            decimal valorUnidade = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells["PrecoVenda1"].Value.ToString());

            if (valorUnidade <= 0)
                ((MaterialTextBox)sender).Text = "0";

            FormataCampoDinheiro((MaterialTextBox)sender, 100, (porcentagem) =>
            {
                decimal valorUnidade = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells["PrecoVenda1"].Value.ToString());

                decimal total = (porcentagem / 100) * valorUnidade;

                bloqueiaAlteracaoCampo = true;
                boxValorDesconto.Text = total.ToString();
                bloqueiaAlteracaoCampo = false;
            });
        }

        private void BoxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;

            if (string.IsNullOrEmpty(boxQuantidade.Text.Trim()) || Convert.ToDecimal(boxQuantidade.Text.Trim()) <= 0)
                e.Handled = true;
        }

        private void dataGridProdutosVenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridProdutosVenda.Columns["check"].Index && e.RowIndex != -1)
            {
                bool valor = Convert.ToBoolean(dataGridProdutosVenda.Rows[e.RowIndex].Cells[0].Value);
                int totalAtual = Convert.ToInt32(lblQuantidadeSelecionada.Text);

                if (valor)
                    totalAtual += 1;
                else
                    totalAtual -= 1;

                AtualizaTotalRowsSelecionadas(totalAtual);

                lblQuantidadeSelecionada.Text = quantidadeRowsSelecionadasGridItensVenda.ToString();
            }
        }

        private void DataGridProdutosVenda_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridProdutosVenda.Columns["check"].Index && e.RowIndex != -1)
                dataGridProdutosVenda.EndEdit();
        }

        private void DataGridProdutosVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridProdutosVenda.Columns["check"].Index && e.RowIndex != -1)
                dataGridProdutosVenda.EndEdit();
        }

        private void CheckBoxMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridProdutosVenda.Rows)
                r.Cells[0].Value = ((CheckBox)sender).Checked;

            AtualizaTotalRowsSelecionadas(((CheckBox)sender).Checked ? dataGridProdutosVenda.Rows.Count : 0);
        }

        #endregion

        #region Requisições

        private void ListarProdutos(string textoPesquisa = "")
        {
            if (estado is null || estado.Id <= 0) return;

            HelperProdutos.ObtemPrecosPorEstado(estado.Id, textoPesquisa).Then(listaProdutos =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.DataSource = listaProdutos;

                    dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridProdutos.Columns["ProdutoId"].Width = 60;
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
            if (produtoId <= 0 || estado is null || estado.Id <= 0) return;

            HelperComissoes.ObtemComissoesProduto(produtoId, estado.Id, classificacoes).Then(comissoes =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridComissaoClassificacao.ColumnCount = 6;
                    List<string[]> rows = [];
                    dataGridComissaoClassificacao.Rows.Clear();

                    dataGridComissaoClassificacao.Columns[0].Name = "Id";
                    dataGridComissaoClassificacao.Columns[1].Name = "Classificação";
                    dataGridComissaoClassificacao.Columns[2].Name = "Valor 1";
                    dataGridComissaoClassificacao.Columns[3].Name = "% - 1";
                    dataGridComissaoClassificacao.Columns[4].Name = "Valor 2";
                    dataGridComissaoClassificacao.Columns[5].Name = "% - 2";

                    int[] idsClassificacoes = new int[comissoes.Count];

                    for (int i = 0; i < comissoes.Count; i++)
                        idsClassificacoes[i] = comissoes[i].ClassificacaoId;

                    IEnumerable<int> ids = idsClassificacoes.Distinct().ToList();

                    foreach (int item in ids)
                    {
                        List<ModelComissoesProduto> lista = comissoes.FindAll(c => c.ClassificacaoId == item).ToList();

                        ModelComissoesProduto? valor1 = lista.Find(r => r.Ordem.Equals(1));
                        ModelComissoesProduto? valor2 = lista.Find(r => r.Ordem.Equals(2));

                        decimal vReal1 = valor1?.ValorReal ?? 0m;
                        decimal porcentagem1 = valor1?.Porcentagem ?? 0m;

                        decimal vReal2 = valor2?.ValorReal ?? 0m;
                        decimal porcentagem2 = valor2?.Porcentagem ?? 0m;

                        rows.Add([
                            item.ToString(),
                            lista[0].ClassificacaoNome,
                            vReal1.ToString(),
                            porcentagem1.ToString(),
                            vReal2.ToString(),
                            porcentagem2.ToString()
                        ]);
                    }

                    foreach (string[] item in rows)
                        dataGridComissaoClassificacao.Rows.Add(item);

                    dataGridComissaoClassificacao.Columns["Id"].Visible = false;
                    dataGridComissaoClassificacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridComissaoClassificacao.Columns["Classificação"].ReadOnly = true;
                    dataGridComissaoClassificacao.Columns["Classificação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dataGridComissaoClassificacao.Columns["Valor 1"].ReadOnly = false;
                    dataGridComissaoClassificacao.Columns["% - 1"].ReadOnly = true;
                    dataGridComissaoClassificacao.Columns["Valor 2"].ReadOnly = false;
                    dataGridComissaoClassificacao.Columns["% - 2"].ReadOnly = true;

                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void AdicionaProdutoVenda(
            decimal precoVenda,
            decimal quantidadeProduto,
            decimal valorDesconto,
            decimal porcentagemDesconto)
        {
            if (estado is null || estado.Id <= 0) return;

            HelperPedidoVendas.AdicionaProduto(
                venda,
                pessoasIds,
                classificacoes,
                produtoId,
                estado.Id,
                1,
                precoVenda,
                quantidadeProduto,
                valorDesconto,
                porcentagemDesconto
                ).Then(pedidoVenda =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        ListaItensVenda();
                        ObtemTotaisProdutosVenda();
                        AtualizaTotaisComissoes();

                        venda = pedidoVenda;

                        lblTotalGeral.Text = Utils.FormataDecimalMonetario(venda.TotalGeral).ToString();
                        lblPorcentagemDesconto.Text = Utils.FormataPorcentagem(venda.PorcentagemDesconto).ToString();
                        lblValorDesconto.Text = Utils.FormataDecimalMonetario(venda.ValorDesconto).ToString();
                        lblTotalComDesconto.Text = Utils.FormataDecimalMonetario(venda.TotalComDesconto).ToString();
                    });
                }).Catch(erro =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show(erro.Message);
                    });
                });
        }

        private void ListaItensVenda()
        {
            if (venda is null || venda.Id <= 0) return;

            HelperPedidoVendas.ObtemItensVenda(venda.Id, classificacoes)
            .Then(itensVenda =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutosVenda.DataSource = itensVenda;

                    dataGridProdutosVenda.Columns["PedidoVendaItemId"].Visible = false;
                    dataGridProdutosVenda.Columns["ProdutoId"].HeaderText = "P. Id";
                    dataGridProdutosVenda.Columns["ProdutoNome"].HeaderText = "Nome";
                    dataGridProdutosVenda.Columns["PrecoVenda"].HeaderText = "P. Venda";
                    dataGridProdutosVenda.Columns["PorcentagemDesconto"].HeaderText = "% Desc";
                    dataGridProdutosVenda.Columns["ValorDesconto"].HeaderText = "V. Desc";
                    dataGridProdutosVenda.Columns["TotalComDesconto"].HeaderText = "Total C. Desc";
                    dataGridProdutosVenda.Columns["PedidoVendaItemCreatedAt"].HeaderText = "Adicionado Em";

                    ColunasSomenteLeituraGridProdutosVenda();
                    AtualizaTotalRowsSelecionadas(0);

                    dataGridProdutosVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void ObtemTotaisProdutosVenda()
        {
            if (venda is null || venda.Id <= 0) return;

            HelperPedidoVendas.TotalizadorVenda(venda.Id)
            .Then(totais =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    lblQuantidadeItens.Text = totais.QuantidadeItens.ToString();
                    lblTotalGeralProdutos.Text = totais.TotalGeral.ToString();
                    lblPorcentagemDescontoProdutos.Text = totais.PorcentagemDescontoProdutos.ToString();
                    lblValorDescontoProdutos.Text = totais.ValorDescontoProdutos.ToString();
                    lblTotalComDescontoProdutos.Text = totais.TotalComDescontoProdutos.ToString();
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void ObtemTotaisComissaoClassificacaoVenda(int classificacaoId)
        {
            if (venda is null || venda.Id <= 0) return;

            HelperPedidoVendas.TotalizadorComissaoClassificacaoVenda(venda.Id, classificacaoId)
            .Then(totais =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    if (totais is not null)
                        AdicionaTotaisComissaoTela(totais.Nome, totais.TotalComissao, totais.Total);
                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void DeletaProdutosVenda(int[] idsItensVenda)
        {
            if (venda is null || venda.Id <= 0) return;

            HelperPedidoVendas.RemoveProdutoVenda(venda.Id, idsItensVenda)
            .Then(pedidoVenda =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    ListaItensVenda();
                    ObtemTotaisProdutosVenda();
                    AtualizaTotaisComissoes();

                    lblTotalGeral.Text          = Utils.FormataDecimalMonetario(venda.TotalGeral).ToString();
                    lblPorcentagemDesconto.Text = Utils.FormataPorcentagem     (venda.PorcentagemDesconto).ToString();
                    lblValorDesconto.Text       = Utils.FormataDecimalMonetario(venda.ValorDesconto).ToString();
                    lblTotalComDesconto.Text    = Utils.FormataDecimalMonetario(venda.TotalComDesconto).ToString();
                });
            }).Catch(erro =>
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
