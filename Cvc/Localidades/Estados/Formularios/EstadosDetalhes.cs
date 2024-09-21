using controle_vendas_comissoes.Biblioteca.Utils;
using controle_vendas_comissoes.Configuracoes.Db.Entidades;
using controle_vendas_comissoes.Configuracoes.Db.Helpers;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_vendas_comissoes.Cvc.Localidades.Estados.Formularios
{
    public partial class EstadosDetalhes : MaterialForm
    {
        #region Variaveis

        Estado? novoEstado = null;

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
                    UF   = maskUF.Text.ToUpper().Trim()
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
        }

        #endregion

        #region Eventos e Cliques

        private void BtSalvarMais_Click(object? sender, EventArgs e)
        {
            ValidaCampos();
        }

        #endregion

        #region Requisições

        private void AdicionaEstado()
        {
            try
            {                
                if (novoEstado is null)
                    throw new Exception("O objeto de inserção é inválido");

                Utils.ExibeCarregando(this);

                HelperEstado.AdicionaEstado(novoEstado).Then(estado =>
                {
                    Utils.RunOnUiThread(this, () =>
                    {
                        Utils.EscondeCarregando(() =>
                        {
                            this.Enabled = true;
                        });

                        //MessageBox.Show("Estado inserido com sucesso!");
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
