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
            ProdutosDetalhes modal = new()
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
                    dataGridProdutos.Rows.Clear();

                    dataGridProdutos.ColumnCount = 6;
                    List<string[]> linhas = [];

                    dataGridProdutos.Columns[0].Name = "Id";
                    dataGridProdutos.Columns[1].Name = "Nome";
                    dataGridProdutos.Columns[2].Name = "UnidadePrimaria";
                    dataGridProdutos.Columns[3].Name = "Descricao";
                    dataGridProdutos.Columns[4].Name = "Composicao";
                    dataGridProdutos.Columns[5].Name = "ModoUsar";

                    foreach (Produto produto in listaProdutos)
                        linhas.Add([
                            produto.Id.ToString(),
                            produto.Nome,
                            produto.UnidadePrimaria?.Nome ?? "",
                            produto.Descricao ?? "",
                            produto.Composicao ?? "",
                            produto.ModoUsar ?? ""]);

                    for (int i = 0; i < linhas.Count; i++)
                        dataGridProdutos.Rows.Add(linhas[i]);

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
