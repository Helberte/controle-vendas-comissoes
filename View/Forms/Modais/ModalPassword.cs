namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class ModalPassword : Form
    {
        private int ticks = 0;

        #region Construtores

        public ModalPassword()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos, Cliques e keypress

        private void BtAutenticar_Click(object sender, EventArgs e)
        {
            ValidaSenha();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalPassword_Load(object sender, EventArgs e)
        {
            boxPassword.Focus();
        }

        private void BoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ValidaSenha();
        }

        private void TimerPassword_Tick(object sender, EventArgs e)
        {
            if (ticks == 2)
            {
                timerPassword.Stop();
                timerPassword.Enabled    = false;
                lblSenhaIcorreta.Visible = false;
            }

            ticks++;
        }

        #endregion

        #region Métodos

        private void ValidaSenha()
        {
            if (boxPassword.Text.Trim() == "2486")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                boxPassword.Focus();
                lblSenhaIcorreta.Visible = true;

                ticks = 0;

                timerPassword.Enabled = true;
                timerPassword.Start();
            }
        }

        #endregion
    }
}
