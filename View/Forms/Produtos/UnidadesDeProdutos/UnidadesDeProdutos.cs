using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.UnidadesDeProdutos;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Produtos.UnidadesDeProdutos
{
    public partial class UnidadesDeProdutos : Form
    {
        #region Construtores

        public UnidadesDeProdutos()
        {
            InitializeComponent();

            dataGridUnidades.SetStyleDataGridView();
            
            DelegaEventos();

            ListarUnidadesDeProdutos();
        }

        #endregion

        #region Eventos e Cliques

        private void BtInserirNovo_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirUnidade();
        }

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            btInserirNovo.Click += BtInserirNovo_Click;
        }

        private void ExibeModalInserirUnidade()
        {
            UnidadesDeProdutosDetalhes modal = new()
            {
                Text = "Criar Nova Unidade Primária"
            };

            modal.ShowDialog();

            ListarUnidadesDeProdutos();
        }

        #endregion

        #region Requisições

        private void ListarUnidadesDeProdutos()
        {
            HelperUnidadePrimaria.ObtemUnidadesPrimarias().Then(unidades =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridUnidades.DataSource = unidades;

                    dataGridUnidades.Columns["createdAt"].Visible = false;
                    dataGridUnidades.Columns["updatedAt"].Visible = false;
                    dataGridUnidades.Columns["deletedAt"].Visible = false;
                    dataGridUnidades.Columns["createdBy"].Visible = false;
                    dataGridUnidades.Columns["updatedBy"].Visible = false;
                    dataGridUnidades.Columns["deletedBy"].Visible = false;
                    dataGridUnidades.Columns["produtos"].Visible  = false;

                    dataGridUnidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridUnidades.Columns["id"].Width = 60;

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
