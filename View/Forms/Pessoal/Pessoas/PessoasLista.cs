using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Pessoas;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;

namespace controle_vendas_comissoes.View.Forms.Pessoal.Pessoas
{
    public partial class PessoasLista : Form
    {
        #region Construtores

        public PessoasLista()
        {
            InitializeComponent();

            dataGridPessoas.SetStyleDataGridView();

            DelegaEventos();

            ListarPessoas();
        }

        #endregion

        #region Eventos e Cliques

        private void BtAdicionar_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirPessoa();
        }

        private void BtBuscaClassificacao_Click(object? sender, EventArgs e)
        {
            BuscaClassificacoes modal = new(SetPropriedades);
            modal.ShowDialog();

            boxClassificacao.Focus();
        }

        #endregion

        #region Métodos

        private void DelegaEventos()
        {
            btAdicionar.Click += BtAdicionar_Click;
            btBuscaClassificacao.Click += BtBuscaClassificacao_Click;
        }

        private void ExibeModalInserirPessoa()
        {
            PessoasDetalhes modal = new()
            {
                Text = "Criar novo cadastro de pessoa"
            };

            modal.ShowDialog();

            ListarPessoas();
        }

        private void SetPropriedades(Classificacao classificacao)
        {
            boxClassificacao.Text = classificacao.Nome;
        }

        #endregion

        #region Requisições

        private void ListarPessoas()
        {
            HelperPessoas.ObtemPessoas().Then(listaPessoas =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridPessoas.DataSource = listaPessoas;

                    dataGridPessoas.Columns["CreatedAt"].Visible = false;
                    dataGridPessoas.Columns["ClassificacaoId"].Visible = false;
                    dataGridPessoas.Columns["EnderecoId"].Visible = false;
                    dataGridPessoas.Columns["EstadoId"].Visible   = false;

                    dataGridPessoas.Columns["ClassificacaoDescricao"].HeaderText = "Classificação";
                    dataGridPessoas.Columns["DataNascimento"].HeaderText = "Nascimento";

                    dataGridPessoas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dataGridPessoas.Columns["id"].Width = 60;
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
