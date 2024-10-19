using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Estados;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Controller.Utils;

namespace controle_vendas_comissoes.View.Forms.Localidades.Estados
{
    public partial class EstadosDetalhes : Form
    {
        #region Variaveis

        private Estado? novoEstado = null;
        private static Action? action = null;

        #endregion

        #region Construtores

        public EstadosDetalhes()
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
                if (string.IsNullOrEmpty(boxNomeEstado.Text.Trim()))
                    throw new Exception("O nome do estado está vazio");

                if (string.IsNullOrEmpty(maskUF.Text.Trim()))
                    throw new Exception("O nome da mascara está vazia");

                novoEstado = new()
                {
                    Nome = boxNomeEstado.Text.ToUpper().Trim(),
                    UF = maskUF.Text.ToUpper().Trim()
                };

                AdicionaEstado();
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
            boxNomeEstado.Text = string.Empty;
            maskUF.Text = string.Empty;

            boxNomeEstado.Focus();
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
                this.Dispose();
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
                boxNomeEstado.Focus();
        }

        #endregion

        #region Requisições

        private void AdicionaEstado()
        {
            try
            {
                if (novoEstado is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperEstado.AdicionaEstado(novoEstado).Then(estado =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show("Estado inserido com sucesso!");

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
