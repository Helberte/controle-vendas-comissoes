using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Cidades;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class BuscaCidade : Form
    {
        #region Variáveis

        readonly Action<Cidade>? ActionCidade;
        private readonly Estado? EstadoFiltro;

        #endregion

        #region Construtores

        public BuscaCidade(Action<Cidade>? action, Estado? EstadoFiltro)
        {
            InitializeComponent();

            dataGridCidades.SetStyleDataGridView();
            
            this.ActionCidade = action;
            this.EstadoFiltro = EstadoFiltro;

            if (EstadoFiltro is not null)
            {
                boxNomeEstado.Text    = EstadoFiltro.Nome.ToUpper();
                boxNomeEstado.Enabled = false;
                btBuscaEstado.Enabled = false;

                ListarCidades(EstadoFiltro.Id);
            }
            else
                ListarCidades();

            DelegaEventos();
        }

        #region Eventos e Cliques

        private void DataGridCidades_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView grid)
            {                
                this.ActionCidade?.Invoke(new Cidade()
                {
                    Id    = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["id"].Value ?? 0),
                    Nome  = grid.Rows[e.RowIndex].Cells["nome"].Value.ToString()  ?? "",
                    Sigla = grid.Rows[e.RowIndex].Cells["sigla"].Value.ToString() ?? ""
                });
            }

            this.Close();
        }

        #endregion

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            dataGridCidades.CellDoubleClick += DataGridCidades_CellDoubleClick;
        }

        #endregion

        #region Requisições

        private void ListarCidades()
        {
            HelperCidade.ObtemCidades().Then(listaCidades =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridCidades.DataSource = listaCidades;

                    dataGridCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridCidades.Columns["id"].Width = 60;

                });
            }).Catch(erro =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    MessageBox.Show(erro.Message);
                });
            });
        }

        private void ListarCidades(int EstadoId)
        {
            HelperCidade.ObtemCidades(EstadoId).Then(listaCidades =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridCidades.DataSource = listaCidades;

                    dataGridCidades.Columns["createdAt"].Visible = false;
                    dataGridCidades.Columns["updatedAt"].Visible = false;
                    dataGridCidades.Columns["deletedAt"].Visible = false;
                    dataGridCidades.Columns["createdBy"].Visible = false;
                    dataGridCidades.Columns["updatedBy"].Visible = false;
                    dataGridCidades.Columns["deletedBy"].Visible = false;

                    dataGridCidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridCidades.Columns["id"].Width = 60;

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
