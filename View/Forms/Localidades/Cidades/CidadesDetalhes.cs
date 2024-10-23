using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Localidades.Cidades;

namespace controle_vendas_comissoes.View.Forms.Localidades.Cidades
{
    public partial class CidadesDetalhes : Form
    {
        #region Variaveis

        private Cidade? novaCidade = null;
        private static Action? action = null;

        #endregion

        #region Construtores

        public CidadesDetalhes()
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
                if (string.IsNullOrEmpty(boxNomeCidade.Text.Trim()))
                    throw new Exception("O nome da cidade está vazia");

                if (string.IsNullOrEmpty(boxSigla.Text.Trim()))
                    throw new Exception("O sigla está vazia");

                if (string.IsNullOrEmpty(boxNomeEstado.Text.Trim()))
                    throw new Exception("O nome do estado está vazio");

                if (string.IsNullOrEmpty(boxIdEstado.Text.Trim()))
                    throw new Exception("O Id do estado está vazio");

                novaCidade = new()
                {
                    Nome     = boxNomeCidade.Text.ToUpper().Trim(),
                    Sigla    = boxSigla.Text.ToUpper().Trim(),
                    EstadoId = Convert.ToInt32(boxIdEstado.Text)
                };

                AdicionaCidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelegaEventos()
        {
            btSalvarMais.Click  += BtSalvarMais_Click;
            btSalvar.Click      += BtSalvar_Click;
            btCancelar.Click    += BtCancelar_Click;
            btBuscaEstado.Click += BtBuscaEstado_Click;
        }

        private void LimpaCampos()
        {
            boxNomeCidade.Text = string.Empty;
            boxNomeEstado.Text = string.Empty;
            boxSigla.Text      = string.Empty;
            boxIdEstado.Text   = string.Empty;

            boxNomeCidade.Focus();
        }

        private void SetPropriedades(Estado estado)
        {
            boxNomeEstado.Text = estado.Nome;
            boxIdEstado.Text   = estado.Id.ToString();
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
                boxNomeCidade.Focus();
        }

        private void BtBuscaEstado_Click(object? sender, EventArgs e)
        {
            CidadesBuscaEstado buscaEstado = new(SetPropriedades);
            buscaEstado.ShowDialog();

            boxNomeEstado.Focus();
        }

        #endregion

        #region Requisições

        private void AdicionaCidade()
        {
            try
            {
                if (novaCidade is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperCidade.AdicionaCidade(novaCidade).Then(cidade =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show("Cidade inserida com sucesso!");

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
