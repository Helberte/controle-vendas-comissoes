using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class BuscaEstado : Form
    {
        #region Variáveis

        readonly Action<Estado>? ActionEstado;

        #endregion

        #region Construtores

        public BuscaEstado(Action<Estado>? action)
        {
            InitializeComponent();

            dataGridEstados.SetStyleDataGridView();

            this.ActionEstado = action;

            ListarEstados();

            DelegaEventos();
        }

        #region Eventos e Cliques

        private void DataGridEstados_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                var teste = grid.Rows[e.RowIndex].Cells["nome"];

                this.ActionEstado?.Invoke(new Estado()
                {
                    Id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["id"].Value ?? 0),
                    Nome = grid.Rows[e.RowIndex].Cells["nome"].Value.ToString() ?? "",
                    UF = grid.Rows[e.RowIndex].Cells["uf"].Value.ToString() ?? ""
                });
            }

            this.Close();
        }

        #endregion

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            dataGridEstados.CellDoubleClick += DataGridEstados_CellDoubleClick;
        }

        #endregion

        #region Requisições

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

        #endregion
    }
}
