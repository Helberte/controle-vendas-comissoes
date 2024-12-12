namespace controle_vendas_comissoes.View.Forms.Modais
{
    public partial class ModalPassword : Form
    {
        private int ticks = 0;

        public ModalPassword()
        {
            InitializeComponent();
        }

        private void BtAutenticar_Click(object sender, EventArgs e)
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

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            if (ticks == 2)
            {
                timerPassword.Stop();
                timerPassword.Enabled    = false;
                lblSenhaIcorreta.Visible = false;
            }

            ticks++;
        }


        class VerticalTextBox : TextBox
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

                if (!string.IsNullOrEmpty(Text))
                {
                    var textSize = e.Graphics.MeasureString(Text, Font);
                    var y = (ClientSize.Height - textSize.Height) / 2;
                    e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new PointF(0, y));
                }
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x000F)
                {
                    using (var graphics = CreateGraphics())
                    {
                        OnPaint(new PaintEventArgs(graphics, ClientRectangle));
                    }
                    return;
                }

                base.WndProc(ref m);
            }
        }
    }
}
