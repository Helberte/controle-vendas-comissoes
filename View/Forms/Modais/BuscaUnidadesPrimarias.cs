using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.UnidadesDeProdutos;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class BuscaUnidadesPrimarias : Form
    {
        #region Variáveis

        readonly Action<UnidadePrimaria>? ActionUnidadePrimaria;

        #endregion

        #region Construtores

        public BuscaUnidadesPrimarias(Action<UnidadePrimaria>? action)
        {
            InitializeComponent();

            dataGridUnidades.SetStyleDataGridView();

            this.ActionUnidadePrimaria = action;

            ListarUnidadesDeProdutos();

            DelegaEventos();
        }

        #region Eventos e Cliques

        private void dataGridUnidades_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                this.ActionUnidadePrimaria?.Invoke(new UnidadePrimaria()
                {
                    Id    = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["id"].Value ?? 0),
                    Nome  = grid.Rows[e.RowIndex].Cells["nome"].Value.ToString() ?? "",
                    Sigla = grid.Rows[e.RowIndex].Cells["sigla"].Value.ToString() ?? "",
                });
            }

            this.Close();
        }

        #endregion

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            dataGridUnidades.CellDoubleClick += dataGridUnidades_CellDoubleClick;
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
