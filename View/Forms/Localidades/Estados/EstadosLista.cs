using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Localidades.Estados
{
    public partial class EstadosLista : Form
    {
        #region Construtores

        public EstadosLista()
        {
            InitializeComponent();

            dataGridEstados.SetStyleDataGridView();

            DelegaEventos();

            ListarEstados();
        }

        #endregion

        #region Eventos e Cliques

        private void BtInserirNovo_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirEstado();
        }

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            btInserirNovo.Click += BtInserirNovo_Click;
        }

        private void ExibeModalInserirEstado()
        {
            EstadosDetalhes estadosDetalhes = new()
            {
                Text = "Criar Novo Estado"
            };

            estadosDetalhes.ShowDialog();

            ListarEstados();
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
