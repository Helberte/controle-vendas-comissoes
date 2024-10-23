using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Classificacoes;

namespace controle_vendas_comissoes.View.Forms.Pessoal.Classificacoes
{
    public partial class ClassificacoesDetalhes : Form
    {
        #region Variaveis

        private Classificacao? novaClassificacao = null;
        private static Action? action            = null;

        #endregion

        #region Construtores

        public ClassificacoesDetalhes()
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
                if (string.IsNullOrEmpty(boxNomeClassificacao.Text.Trim()))
                    throw new Exception("O nome da Classificação está vazio");

                novaClassificacao = new()
                {
                    Nome = boxNomeClassificacao.Text.ToUpper().Trim()
                };

                AdicionaClassificacao();
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
            boxNomeClassificacao.Text = string.Empty;
            
            boxNomeClassificacao.Focus();
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

            action = () =>
            {
                this.Close();
            };
        }

        private void BtCancelar_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a edição atual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                this.Close();
            }
            else
                boxNomeClassificacao.Focus();
        }

        #endregion

        #region Requisições

        private void AdicionaClassificacao()
        {
            try
            {
                if (novaClassificacao is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperClassificacoes.AdicionaClassificacao(novaClassificacao).Then(classificacao =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show("Classificação inserida com sucesso!");

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
