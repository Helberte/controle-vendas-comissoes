using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Produtos.UnidadesDeProdutos;
using controle_vendas_comissoes.View.Extensions;

namespace controle_vendas_comissoes.View.Forms.Produtos.UnidadesDeProdutos
{
    public partial class UnidadesDeProdutosDetalhes : Form
    {
        #region Variaveis

        private UnidadePrimaria? novaUnidadePrimaria = null;
        private static Action? action = null;

        #endregion

        #region Construtores

        public UnidadesDeProdutosDetalhes()
        {
            InitializeComponent();

            DelegaEventos();
        }

        #endregion

        #region Métodos

        private void ValidaCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(boxNomeUnidade.Text.Trim()))
                    throw new Exception("O nome da Unidade Primária está vazia");

                if (string.IsNullOrEmpty(maskSigla.GetText()))
                    throw new Exception("A sigla da Unidade Primária está vazia");

                novaUnidadePrimaria = new()
                {
                    Nome  = boxNomeUnidade.Text.ToUpper().Trim(),
                    Sigla = maskSigla.GetText().ToUpper().Trim()
                };

                AdicionaUnidadePrimaria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelegaEventos()
        {
            btSalvarMais.Click += BtSalvarMais_Click;
            btSalvar.Click     += BtSalvar_Click;
            btCancelar.Click   += BtCancelar_Click;
        }

        private void LimpaCampos()
        {
            boxNomeUnidade.Text = string.Empty;
            maskSigla.Text      = string.Empty;

            boxNomeUnidade.Focus();
        }

        #endregion

        #region Eventos e Cliques

        private void BtSalvarMais_Click(object? sender, EventArgs e)
        {
            ValidaCampos();

            action = LimpaCampos;
        }

        private void BtSalvar_Click(object? sender, EventArgs e)
        {
            ValidaCampos();

            action = Close;
        }

        private void BtCancelar_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a edição atual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                this.Close();
            }
            else
                boxNomeUnidade.Focus();
        }

        #endregion

        #region Requisições

        private void AdicionaUnidadePrimaria()
        {
            try
            {
                if (novaUnidadePrimaria is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperUnidadePrimaria.AdicionaUnidadePrimaria(novaUnidadePrimaria).Then(unidade =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show("Unidade Primária inserida com sucesso!");

                        action?.Invoke();
                    });
                }).Catch(erro =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show(erro.Message);
                    });
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
