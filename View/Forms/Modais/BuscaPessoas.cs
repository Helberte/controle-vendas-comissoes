using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Pessoas;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class BuscaPessoas : Form
    {
        #region Variáveis

        private readonly Action<Pessoa>? ActionPessoa;

        #endregion

        #region Construtores

        public BuscaPessoas(Action<Pessoa>? action)
        {
            InitializeComponent();

            dataGridPessoas.SetStyleDataGridView();

            this.ActionPessoa = action;
            
            ListarPessoas();

            DelegaEventos();
        }

        #region Eventos e Cliques

        private void DataGridPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                Classificacao classificacao = new()
                {
                    Id   = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["ClassificacaoId"].Value.ToString() ?? "0"),
                    Nome = grid.Rows[e.RowIndex].Cells["ClassificacaoDescricao"].Value.ToString()          ?? "",
                };

                Estado estado = new()
                {
                    Nome = grid.Rows[e.RowIndex].Cells["EstadoNome"].Value.ToString() ?? "",
                    UF   = grid.Rows[e.RowIndex].Cells["EstadoUF"].Value.ToString()   ?? ""
                };

                Cidade cidade = new()
                {
                    Nome  = grid.Rows[e.RowIndex].Cells["CidadeNome"].Value.ToString()  ?? "",
                    Sigla = grid.Rows[e.RowIndex].Cells["CidadeSigla"].Value.ToString() ?? ""
                };

                Endereco endereco = new()
                {
                    Id     = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["EnderecoId"].Value.ToString() ?? "0"),
                    Cep    = grid.Rows[e.RowIndex].Cells["CEP"].Value.ToString()    ?? "",
                    Rua    = grid.Rows[e.RowIndex].Cells["Rua"].Value.ToString()    ?? "",
                    Numero = grid.Rows[e.RowIndex].Cells["Numero"].Value.ToString() ?? "",
                    Bairro = grid.Rows[e.RowIndex].Cells["bairro"].Value.ToString() ?? "",
                    Estado = estado,
                    Cidade = cidade,
                };

                this.ActionPessoa?.Invoke(new Pessoa()
                {
                    Id             = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Id"].Value    ?? 0),
                    Nome           = grid.Rows[e.RowIndex].Cells["Nome"].Value.ToString()       ?? "",
                    Sobrenome      = grid.Rows[e.RowIndex].Cells["Sobrenome"].Value.ToString()  ?? "",
                    Cpf            = grid.Rows[e.RowIndex].Cells["Cpf"].Value.ToString()        ?? "",
                    Rg             = grid.Rows[e.RowIndex].Cells["Rg"].Value.ToString()         ?? "",
                    DataNascimento = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["DataNascimento"].Value.ToString() ?? ""),
                    CreatedAt      = Convert.ToDateTime(grid.Rows[e.RowIndex].Cells["CreatedAt"].Value.ToString()      ?? ""),
                    Endereco       = endereco,
                    Classificacao  = classificacao                    
                });
            }

            this.Close();
        }

        #endregion

        #endregion

        #region Metodos

        private void DelegaEventos()
        {

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

                    dataGridPessoas.Columns["CreatedAt"].Visible       = false;
                    dataGridPessoas.Columns["ClassificacaoId"].Visible = false;
                    dataGridPessoas.Columns["EnderecoId"].Visible      = false;

                    dataGridPessoas.Columns["ClassificacaoDescricao"].HeaderText = "Classificação";
                    dataGridPessoas.Columns["DataNascimento"].HeaderText         = "Nascimento";

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
