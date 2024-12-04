using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.Model.Db.Models;
using controle_vendas_comissoes.View.Extensions;
using System.Text.Json;

namespace controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes
{
    public partial class ComissoesConfiguracao : Form
    {
        private static int produtoId = 0;
        private static int estadoId  = 0;
        private static bool enviandoRequisicao = false;
        private bool bloqueiaAlteracaoCampo = false;
        private List<ModelComissoesProduto>? comissaoAtual = [];
        private ModelComissoesProduto? comissaoAlterada;
        KeyPressEventHandler? keyPressEventHandler;
        EventHandler?         eventHandler;

        #region Construtores

        public ComissoesConfiguracao()
        {
            InitializeComponent();

            ConfiguraLayout();

            DelegaEventos();

            ListarProdutos();           
        }

        #endregion

        #region Eventos e Cliques

        private void DataGridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                lblIdProduto.Text        = ((DataGridView)sender).SelectedRows[0].Cells["Id"].Value.ToString();
                lblDescricaoProduto.Text = ((DataGridView)sender).SelectedRows[0].Cells["Nome"].Value.ToString();

                produtoId = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["Id"].Value);

                ObterPrecosProdutoEstados();
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

        private void DataGridComissoes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            decimal precoVenda = 0m;

            if (dataGridComissoes.CurrentCell.ColumnIndex.Equals(dataGridComissoes.Columns["Valor 1"].Index))
                precoVenda = Convert.ToDecimal(dataGridEstados.CurrentRow.Cells[dataGridEstados.Columns["PrecoVenda1"].Index].Value);
            else 
            if (dataGridComissoes.CurrentCell.ColumnIndex.Equals(dataGridComissoes.Columns["Valor 2"].Index))
                precoVenda = Convert.ToDecimal(dataGridEstados.CurrentRow.Cells[dataGridEstados.Columns["PrecoVenda2"].Index].Value);

            e.Control.KeyPress    -= keyPressEventHandler;
            e.Control.TextChanged -= eventHandler;

            if (dataGridComissoes.CurrentCell.ColumnIndex == dataGridComissoes.Columns["Valor 1"].Index ||
                dataGridComissoes.CurrentCell.ColumnIndex == dataGridComissoes.Columns["Valor 2"].Index)
            {
                if (e.Control is System.Windows.Forms.TextBox tb)
                {
                    if (tb != null)
                    {
                        keyPressEventHandler = new KeyPressEventHandler(CelulaComissao_KeyPress);
                        eventHandler         = new EventHandler((object? sender, EventArgs e) =>
                        {
                            CelulaGrid_TextChanged(sender, e, precoVenda - 1);
                        });

                        tb.KeyPress    += keyPressEventHandler;
                        tb.TextChanged += eventHandler;
                    }
                }
            }
        }

        private void CelulaGrid_TextChanged(object? sender, EventArgs e, decimal valorMaximo = 0)
        {
            if (sender is not null)
                FormataCampoDinheiro((System.Windows.Forms.TextBox)sender, valorMaximo);
        }

        private void CelulaComissao_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void DataGridComissoes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bloqueiaAlteracaoCampo) return;

                bloqueiaAlteracaoCampo    = true;

                string  colunaPorcentagem = string.Empty;
                decimal precoVenda        = 0m;
                int     ordem             = 0;

                if (dataGridComissoes.Columns["Valor 1"].Index == e.ColumnIndex)
                {
                    precoVenda        = Convert.ToDecimal(dataGridEstados.CurrentRow.Cells[dataGridEstados.Columns["PrecoVenda1"].Index].Value);
                    colunaPorcentagem = "% - 1";
                    ordem             = 1;
                }
                else if (dataGridComissoes.Columns["Valor 2"].Index == e.ColumnIndex)
                {
                    precoVenda        = Convert.ToDecimal(dataGridEstados.CurrentRow.Cells[dataGridEstados.Columns["PrecoVenda2"].Index].Value);
                    colunaPorcentagem = "% - 2";
                    ordem             = 2;
                }
                else                
                    throw new Exception("Inconsistência ao alterar comissões do produto.");                

                if (precoVenda <= 0)
                {
                    dataGridComissoes.CurrentCell.Value = 0;

                    throw new Exception("O produto está sem o preço de venda para o preço " + ordem + ", adicione o " +
                        "preço do produto no cadastro e depois tente adicionar comissão.");
                }
                        
                decimal valorComissao = Convert.ToDecimal(dataGridComissoes.CurrentCell.Value);
                decimal porcentagem   = (valorComissao * 100) / precoVenda;

                dataGridComissoes.CurrentRow.Cells[dataGridComissoes.Columns[colunaPorcentagem].Index].Value = porcentagem;
                                
                int     produtoId           = Convert.ToInt32(dataGridProdutos.CurrentRow.Cells[dataGridProdutos.Columns["Id"].Index].Value);
                int     estadoId            = Convert.ToInt32(dataGridEstados.CurrentRow.Cells[dataGridEstados.Columns["Id"].Index].Value);
                int     classificacaoId     = Convert.ToInt32(dataGridComissoes.CurrentRow.Cells[dataGridComissoes.Columns["Id"].Index].Value);

                comissaoAlterada = comissaoAtual?.Find(c => c.ClassificacaoId.Equals(classificacaoId) && c.Ordem.Equals(ordem));

                decimal valorRealAnterior   = comissaoAlterada?.ValorReal   ?? 0m;
                decimal porcentagemAnterior = comissaoAlterada?.Porcentagem ?? 0m;

                InserirComissao(
                    produtoId,
                    estadoId,
                    classificacaoId,
                    porcentagem,
                    valorComissao,
                    valorRealAnterior,
                    porcentagemAnterior,
                    ordem
                );

                bloqueiaAlteracaoCampo = false;
            }
            catch (Exception ex)
            {
                bloqueiaAlteracaoCampo = false;

                MessageBox.Show(ex.Message.ToString());
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

        #endregion

        #region Requisições

        private void ListarProdutos()
        {
            HelperProdutos.ObtemProdutos().Then(listaProdutos =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.Rows.Clear();

                    dataGridProdutos.ColumnCount = 6;
                    List<string[]> linhas = [];

                    dataGridProdutos.Columns[0].Name = "Id";
                    dataGridProdutos.Columns[1].Name = "Nome";
                    dataGridProdutos.Columns[2].Name = "UnidadePrimaria";
                    dataGridProdutos.Columns[3].Name = "Descricao";
                    dataGridProdutos.Columns[4].Name = "ModoUsar";
                    dataGridProdutos.Columns[5].Name = "Composicao";

                    foreach (Produto produto in listaProdutos)                    
                        linhas.Add([ produto.Id.ToString()
                                                    , produto.Nome
                                                    , produto.UnidadePrimaria?.Nome ?? ""
                                                    , produto.Descricao ?? ""
                                                    , produto.ModoUsar ?? ""
                                                    , produto.Composicao ?? "" ]);
                    
                    for (int i = 0; i < linhas.Count; i++)                    
                        dataGridProdutos.Rows.Add(linhas[i]);
                    
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

        private void ObterPrecosProdutoEstados()
        {
            HelperProdutos.ObtemPrecosProduto(produtoId).Then(estadosPreco =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridEstados.DataSource          = estadosPreco;
                    dataGridEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridEstados.Columns["id"].Width = 60;
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

            HelperComissoes.ObtemComissoesProduto(produtoId, estadoId, []).Then(comissoes =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridComissoes.ColumnCount = 6;
                    List<string[]> rows = [];
                    dataGridComissoes.Rows.Clear();

                    dataGridComissoes.Columns[0].Name = "Id";
                    dataGridComissoes.Columns[1].Name = "Classificação";
                    dataGridComissoes.Columns[2].Name = "Valor 1";
                    dataGridComissoes.Columns[3].Name = "% - 1";
                    dataGridComissoes.Columns[4].Name = "Valor 2";
                    dataGridComissoes.Columns[5].Name = "% - 2";

                    string json   = JsonSerializer.Serialize(comissoes);
                    comissaoAtual = JsonSerializer.Deserialize<List<ModelComissoesProduto>>(json);

                    int[] idsClassificacoes = new int[comissoes.Count];
                    
                    for (int i = 0; i < comissoes.Count; i++)                    
                        idsClassificacoes[i] = comissoes[i].ClassificacaoId;

                    IEnumerable<int> ids = idsClassificacoes.Distinct().ToList();

                    foreach (int item in ids)
                    {
                        List<ModelComissoesProduto> lista = comissoes.FindAll(c => c.ClassificacaoId == item).ToList();

                        ModelComissoesProduto? valor1 = lista.Find(r => r.Ordem.Equals(1));
                        ModelComissoesProduto? valor2 = lista.Find(r => r.Ordem.Equals(2));

                        decimal vReal1       = valor1?.ValorReal   ?? 0m;
                        decimal porcentagem1 = valor1?.Porcentagem ?? 0m;

                        decimal vReal2       = valor2?.ValorReal   ?? 0m;
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
                        dataGridComissoes.Rows.Add(item);
                    
                    dataGridComissoes.Columns["Id"].Visible = false;
                    dataGridComissoes.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridComissoes.Columns["Classificação"].ReadOnly     = true;
                    dataGridComissoes.Columns["Classificação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dataGridComissoes.Columns["Valor 1"].ReadOnly   = false;
                    dataGridComissoes.Columns["% - 1"].ReadOnly     = true;
                    dataGridComissoes.Columns["Valor 2"].ReadOnly   = false;
                    dataGridComissoes.Columns["% - 2"].ReadOnly     = true;

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

        private void InserirComissao(
            int     produtoId,
            int     estadoId,
            int     classificacaoId,
            decimal porcentagem,
            decimal valorReal,
            decimal valorRealAnterior,
            decimal porcentagemAnterior,
            int     ordem)
        {
            HelperComissoes.AdicionaComissao(
                produtoId,
                estadoId,
                classificacaoId,
                porcentagem,
                valorReal,
                ordem,
                valorRealAnterior,
                porcentagemAnterior
            ).Then(comissaoItem => 
            { 
                if (comissaoAlterada is not null)
                {
                    comissaoAlterada.ValorReal   = comissaoItem.ValorReal;
                    comissaoAlterada.Porcentagem = comissaoItem.Porcentagem;
                }
            })
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
