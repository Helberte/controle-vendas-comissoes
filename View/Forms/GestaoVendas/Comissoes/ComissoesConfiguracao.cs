using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.Produtos;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;
using controle_vendas_comissoes.View.Forms.Produtos.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes
{
    public partial class ComissoesConfiguracao : Form
    {
        #region Construtores

        public ComissoesConfiguracao()
        {
            InitializeComponent();

            ConfiguraLayout();

            DelegaEventos();

            ListarProdutos();
        }

        #endregion

        #region Eventos e Cliques

        private void BtAdicionarEstado_Click(object? sender, EventArgs e)
        {
            BuscaEstado modal = new(SetPropriedades);
            modal.ShowDialog();
        }

        private void dataGridProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count > 0)
            {
                lblIdProduto.Text        = ((DataGridView)sender).SelectedRows[0].Cells["Id"].Value.ToString();
                lblDescricaoProduto.Text = ((DataGridView)sender).SelectedRows[0].Cells["Nome"].Value.ToString();
            }
        }

        #endregion

        #region Métodos

        private void ConfiguraLayout()
        {
            dataGridProdutos.SetStyleDataGridView();
            dataGridEstados.SetStyleDataGridView();
            dataGridComissoes.SetStyleDataGridView();

            // grid estados
            dataGridEstados.ColumnCount = 3;
            dataGridEstados.Columns[0].Name = "Id";
            dataGridEstados.Columns[1].Name = "Nome";
            dataGridEstados.Columns[2].Name = "UF";

            dataGridEstados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridEstados.Columns[0].Width = 60;
            dataGridEstados.Columns[2].Width = 75;
        }

        private void DelegaEventos()
        {
            btInserirEstado.Click += BtAdicionarEstado_Click;
        }

        private void SetPropriedades(Estado estado)
        {
            string[] row0 = { estado.Id.ToString(), estado.Nome, estado.UF };
            dataGridEstados.Rows.Add(row0);
        }

        #endregion

        #region Requisições

        private void ListarProdutos()
        {
            HelperProdutos.ObtemProdtos().Then(listaProdutos =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    dataGridProdutos.DataSource = listaProdutos;

                    dataGridProdutos.Columns["UnidadePrimaria"].HeaderText = "Unidade Primária";
                    dataGridProdutos.Columns["PrecoCusto1"].HeaderText = "Preço de Custo 1";
                    dataGridProdutos.Columns["PrecoVenda1"].HeaderText = "Preço de Venda 1";
                    dataGridProdutos.Columns["PrecoCusto2"].HeaderText = "Preço de Custo 2";
                    dataGridProdutos.Columns["PrecoVenda2"].HeaderText = "Preço de Venda 2";

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
