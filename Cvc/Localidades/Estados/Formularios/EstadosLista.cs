using controle_vendas_comissoes.Biblioteca.Utils;
using controle_vendas_comissoes.Configuracoes.Db.Helpers;
using MaterialSkin.Controls;

namespace controle_vendas_comissoes.Cvc.Localidades.Estados.Formularios
{
    public partial class EstadosLista : MaterialForm
    {
        #region Construtores

        public EstadosLista()
        {
            InitializeComponent();
            DelegaEventos();
            
            ListarEstados();            
        }

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            btInserirNovo.Click += BtInserirNovo_Click;
        }

        #endregion

        #region Eventos e Cliques

        private void BtInserirNovo_Click(object? sender, EventArgs e)
        {
            EstadosDetalhes estadosDetalhes = new ()
            {
                Text = "Criar Novo Estado"
            };

            estadosDetalhes.ShowDialog();
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

                    dataGridEstados.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;

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
