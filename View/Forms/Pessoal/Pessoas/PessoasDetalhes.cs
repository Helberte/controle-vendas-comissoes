using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;
using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Forms.Pessoal.Pessoas
{
    public partial class PessoasDetalhes : Form
    {
        #region Variaveis

        private Pessoa? novaPessoa = null;
        private static Action? action = null;
        private Estado? EstadoEscolhido = null;

        #endregion

        #region Construtores

        public PessoasDetalhes()
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
                ValidaCampos(groupInformacoesPessoais);

                if (!switchSemEndereco.Checked)
                    ValidaCampos(groupEndereco);

                novaPessoa = new()
                {

                };

                AdicionaPessoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ValidaCampos(GroupBox groupControl)
        {
            foreach (Control controle in groupControl.Controls)
            {
                if (controle is MaterialTextBox box)
                {
                    if (string.IsNullOrEmpty(box.Text.Trim()))
                    {
                        box.Focus();

                        throw new Exception("O campo: " + box.Tag?.ToString() ?? "" + ", está vazio.");
                    }
                }

                if (controle is MaterialMaskedTextBox mask)
                {
                    if (string.IsNullOrEmpty(mask.GetText()))
                    {
                        mask.Focus();

                        throw new Exception("O campo: " + mask.Tag?.ToString() ?? "" + ", está vazio.");
                    }
                    else if ((mask.Tag?.ToString()?.ToUpper() ?? "").Equals("CPF"))                    
                        Utils.ValidaCPF(mask.GetText());                    
                }

                if (controle is MaterialComboBox combo)
                {
                    if (combo.SelectedIndex < 0)
                    {
                        combo.Focus();

                        throw new Exception("O campo: " + combo.Tag?.ToString() ?? "" + ", está vazio.");
                    }
                }
            }
        }

        private void DelegaEventos()
        {
            btSalvarMais.Click += BtSalvarMais_Click;
            btSalvar.Click += BtSalvar_Click;
            btCancelar.Click += BtCancelar_Click;
            btBuscaEstado.Click += BtBuscaEstado_Click;
            btBuscaCidade.Click += BtBuscaCidade_Click;
            switchSemEndereco.CheckedChanged += SwitchSemEndereco_CheckedChanged;
        }

        private void LimpaCampos()
        {
            LimpaCampos(groupInformacoesPessoais);
            LimpaCampos(groupEndereco);

            boxNomePessoa.Focus();
        }

        private static void LimpaCampos(GroupBox Group)
        {
            foreach (Control controle in Group.Controls)
            {
                if (controle is MaterialTextBox box)
                    box.Text = string.Empty;

                if (controle is MaterialMaskedTextBox mask)
                    mask.Text = string.Empty;

                if (controle is MaterialComboBox combo)
                    combo.SelectedIndex = 0;
            }
        }

        private void SetPropriedades(Estado estado)
        {
            this.EstadoEscolhido = estado;

            boxEstado.Text = EstadoEscolhido.Nome;
        }

        private void SetPropriedades(Cidade cidade)
        {
            boxCidade.Text = cidade.Nome;
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

            action = this.Dispose;
        }

        private void BtCancelar_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a edição atual?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                this.Close();
            }
            else
                boxNomePessoa.Focus();
        }

        private void BtBuscaEstado_Click(object? sender, EventArgs e)
        {
            BuscaEstado buscaEstado = new(SetPropriedades);
            buscaEstado.ShowDialog();

            boxCidade.Text = string.Empty;
            boxNomePessoa.Focus();            
        }

        private void BtBuscaCidade_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boxEstado.Text.Trim()))
            {
                MessageBox.Show("Informe o Estado antes de informar a Cidade.");

                btBuscaEstado.Focus();
            }
            else
            {
                BuscaCidade buscaCidade = new(SetPropriedades, EstadoEscolhido);
                buscaCidade.ShowDialog();

                boxCidade.Focus();
            }
        }

        private void SwitchSemEndereco_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is MaterialSwitch escolha && escolha.Checked)
                foreach (Control item in groupEndereco.Controls)
                    item.Enabled = false;
            else
                foreach (Control item in groupEndereco.Controls)
                {
                    if ((item.Tag?.ToString()?.ToUpper() ?? "") != "ESTADO" && (item.Tag?.ToString()?.ToUpper() ?? "") != "CIDADE")
                        item.Enabled = true;
                }                    
        }

        #endregion

        #region Requisições

        private void AdicionaPessoa()
        {
            try
            {
                //if (novaPessoa is null)
                //    throw new Exception("O objeto de inserção é inválido");

                //HelperCidade.AdicionaCidade(novaPessoa).Then(cidade =>
                //{
                //    Utils.RunOnUiThread(this, () =>
                //    {
                //        MessageBox.Show("Cidade inserida com sucesso!");

                //        action?.Invoke(groupInformacoesPessoais);
                //    });
                //}).Catch(erro =>
                //{
                //    Utils.RunOnUiThread(this, () =>
                //    {
                //        MessageBox.Show(erro.Message);
                //    });
                //});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
