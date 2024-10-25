using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Classificacoes;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class BuscaClassificacoes : Form
    {
        #region Variáveis

        readonly Action<Classificacao>? ActionClassificacao;

        #endregion

        #region Construtores

        public BuscaClassificacoes(Action<Classificacao>? action)
        {
            InitializeComponent();

            dataGridClassificacoes.SetStyleDataGridView();
            
            this.ActionClassificacao = action;

            ListarClassificacoes();

            DelegaEventos();
        }

        #region Eventos e Cliques

        private void DataGridClassificacoes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                this.ActionClassificacao?.Invoke(new Classificacao()
                {
                    Id   = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["id"].Value ?? 0),
                    Nome = grid.Rows[e.RowIndex].Cells["nome"].Value.ToString() ?? ""
                });
            }

            this.Close();
        }

        #endregion

        #endregion

        #region Metodos

        private void DelegaEventos()
        {
            dataGridClassificacoes.CellDoubleClick += DataGridClassificacoes_CellDoubleClick;
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
