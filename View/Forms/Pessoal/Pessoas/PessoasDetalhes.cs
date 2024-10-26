using controle_vendas_comissoes.Controller.Utils;
using controle_vendas_comissoes.Model.Db.Entidades;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Classificacoes;
using controle_vendas_comissoes.Model.Db.Helpers.Pessoal.Pessoas;
using controle_vendas_comissoes.View.Extensions;
using controle_vendas_comissoes.View.Forms.Modais;
using MaterialSkin.Controls;

namespace controle_vendas_comissoes.View.Forms.Pessoal.Pessoas
{
    public partial class PessoasDetalhes : Form
    {
        #region Variaveis

        private int indexClassificacao = -1;

        private Pessoa?              novaPessoa      = null;
        private Endereco?            novoEndereco    = null;
        private static Action?       action          = null;
        private Estado?              estadoEscolhido = null;
        private Cidade?              cidadeEscolhida = null;
        private List<Classificacao>? classificacoes;

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
                {
                    ValidaCampos(groupEndereco);

                    if (estadoEscolhido is not null && cidadeEscolhida is not null)
                    {
                        novoEndereco = new Endereco()
                        {
                            Rua      = boxRua.Text.Trim().ToUpper(),
                            Cep      = maskCEP.GetText().ToUpper(),
                            Numero   = maskNumero.GetText(),
                            Bairro   = boxBairro.Text.Trim().ToUpper(),
                            CidadeId = cidadeEscolhida.Id,
                            EstadoId = estadoEscolhido.Id
                        };
                    }
                    else                    
                        throw new Exception("Problemas ao obter dados informados.");                    
                }
                                    
                novaPessoa = new()
                {
                    Cpf            = maskCPF.GetText(),
                    DataNascimento = DateTime.Parse(string.Format("{0:yyyy-mm-DD}", dateDataNascimento.Text)),
                    Nome           = boxNomePessoa.Text.ToUpper().Trim(),
                    Sobrenome      = boxNomeSobrenome.Text.ToUpper().Trim(),
                    Rg             = maskRG.GetText()                    
                };

                if (!(classificacoes?.Count.Equals(indexClassificacao) ?? true))                
                    novaPessoa.ClassificacaoId = classificacoes[indexClassificacao].Id;
                
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
            btSalvarMais.Click               += BtSalvarMais_Click;
            btSalvar.Click                   += BtSalvar_Click;
            btCancelar.Click                 += BtCancelar_Click;
            btBuscaEstado.Click              += BtBuscaEstado_Click;
            btBuscaCidade.Click              += BtBuscaCidade_Click;
            switchSemEndereco.CheckedChanged += SwitchSemEndereco_CheckedChanged;
            this.Load                        += PessoasDetalhes_Load;
            comboClassificacao.SelectedIndexChanged += ComboClassificacao_SelectedIndexChanged;
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
            this.estadoEscolhido = estado;

            boxEstado.Text = estadoEscolhido.Nome;
        }

        private void SetPropriedades(Cidade cidade)
        {
            this.cidadeEscolhida = cidade;

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

            action = this.Close;
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
                BuscaCidade buscaCidade = new(SetPropriedades, estadoEscolhido);
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

        private void PessoasDetalhes_Load(object? sender, EventArgs e)
        {
            ListarClassificacoes();
        }

        private void ComboClassificacao_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is MaterialComboBox combo)            
                indexClassificacao = combo.SelectedIndex;            
        }

        #endregion

        #region Requisições

        private void AdicionaPessoa()
        {
            try
            {
                if (novaPessoa is null)
                    throw new Exception("O objeto de inserção é inválido");

                HelperPessoas.AdicionaPessoa(novaPessoa, novoEndereco).Then(pessoa =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        MessageBox.Show("Pessoa inserida com sucesso!");

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

        private void ListarClassificacoes()
        {
            HelperClassificacoes.ObtemClassificacoes().Then(listaClassificacoes =>
            {
                Utils.RunOnUiThread(this, () =>
                {
                    this.classificacoes = listaClassificacoes;

                    comboClassificacao.Items.Clear();

                    foreach (Classificacao item in listaClassificacoes)                    
                        comboClassificacao.Items.Add(item.Nome);

                    comboClassificacao.Items.Add("NENHUMA");
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
