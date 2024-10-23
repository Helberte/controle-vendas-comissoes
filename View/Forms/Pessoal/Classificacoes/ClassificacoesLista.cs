using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Classificacoes;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Pessoal.Classificacoes
{
    public partial class ClassificacoesLista : Form
    {
        #region Construtores

        public ClassificacoesLista()
        {
            InitializeComponent();

            dataGridClassificacoes.SetStyleDataGridView();

            DelegaEventos();

            ListarClassificacoes();
        }

        #endregion

        #region Eventos e Cliques

        private void BtInserirNovo_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirClassificacao();
        }

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            btInserirNovo.Click += BtInserirNovo_Click;
        }

        private void ExibeModalInserirClassificacao()
        {
            ClassificacoesDetalhes modal = new()
            {
                Text = "Criar Nova Classificação"
            };

            modal.ShowDialog();

            ListarClassificacoes();
        }

        #endregion

        #region Requisições

        private void ListarClassificacoes()
        {
            HelperClassificacoes.ObtemClassificacoes().Then(listaClassificacoes =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridClassificacoes.DataSource = listaClassificacoes;

                    dataGridClassificacoes.Columns["createdAt"].Visible = false;
                    dataGridClassificacoes.Columns["updatedAt"].Visible = false;
                    dataGridClassificacoes.Columns["deletedAt"].Visible = false;
                    dataGridClassificacoes.Columns["createdBy"].Visible = false;
                    dataGridClassificacoes.Columns["updatedBy"].Visible = false;
                    dataGridClassificacoes.Columns["deletedBy"].Visible = false;

                    dataGridClassificacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridClassificacoes.Columns["id"].Width = 60;

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
