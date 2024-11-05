using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Helpers.GestaoVendas.Comissoes;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes
{
    public partial class ComissoesConfiguracao : Form
    {
        private static int produtoId = 0;
        private static int estadoId = 0;
        private static bool enviandoRequisicao = false;

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

        private void dataGridEstados_SelectionChanged(object sender, EventArgs e)
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
    }
}
