using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Cidades;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Localidades.Cidades
{
    public partial class CidadesLista : Form
    {
        #region Construtores

        public CidadesLista()
        {
            InitializeComponent();

            dataGridCidades.SetStyleDataGridView();

            DelegaEventos();

            ListarCidades();
        }

        #endregion

        #region Eventos e Cliques

        private void BtInserirNovo_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirCidade();
        }

        private void BtBuscaEstado_Click(object? sender, EventArgs e)
        {
            CidadesBuscaEstado buscaEstado = new (SetPropriedades);
            buscaEstado.ShowDialog();

            boxNomeEstado.Focus();
        }

        #endregion

        #region Métodos

        private void DelegaEventos()
        {
            btInserirNovo.Click += BtInserirNovo_Click;
            btBuscaEstado.Click += BtBuscaEstado_Click;
        }

        private void ExibeModalInserirCidade()
        {
            CidadesDetalhes cidadesDetalhes = new()
            {
                Text = "Criar Nova Cidade"
            };

            cidadesDetalhes.ShowDialog();

            ListarCidades();
        }

        private void SetPropriedades(Estado estado)
        {
            boxNomeEstado.Text = estado.Nome;
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
