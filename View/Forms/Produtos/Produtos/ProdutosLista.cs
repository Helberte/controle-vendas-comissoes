using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;

namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    public partial class ProdutosLista : Form
    {
        #region Construtores

        public ProdutosLista()
        {
            InitializeComponent();

            dataGridProdutos.SetStyleDataGridView();

            DelegaEventos();

            ListarProdutos();
        }

        #endregion

        #region Eventos e Cliques

        private void BtAdicionar_Click(object? sender, EventArgs e)
        {
            ExibeModalInserirProdutos();
        }

        private void BtBuscaUnidadesPrimarias_Click(object? sender, EventArgs e)
        {
            BuscaUnidadesPrimarias modal = new(SetPropriedades);
            modal.ShowDialog();

            boxUnidadePrimaria.Focus();
        }

        #endregion

        #region Métodos

        private void DelegaEventos()
        {
            btAdicionar.Click += BtAdicionar_Click;
            btBuscaUnidadePrimaria.Click += BtBuscaUnidadesPrimarias_Click;
        }

        private void ExibeModalInserirProdutos()
        {
            ProdutosDeralhes modal = new()
            {
                Text = "Criar novo cadastro de Produto"
            };

            modal.ShowDialog();

            ListarProdutos();
        }

        private void SetPropriedades(UnidadePrimaria unidade)
        {
            boxUnidadePrimaria.Text = unidade.Nome;
        }

        #endregion

        #region Requisições

        private void ListarProdutos()
        {
            HelperProdutos.ObtemProdtos().Then(listaProdutos =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.DataSource          = listaProdutos;
                    dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridProdutos.Columns["id"].Width = 60;
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
