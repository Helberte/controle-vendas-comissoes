namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class ModalPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btAutenticar = new Button();
            btCancelar = new Button();
            lblSenhaIcorreta = new Label();
            timerPassword = new System.Windows.Forms.Timer(components);
            boxPassword = new TextBox();
            SuspendLayout();
            // 
            // btAutenticar
            // 
            btAutenticar.Location = new Point(223, 103);
            btAutenticar.Margin = new Padding(3, 4, 3, 4);
            btAutenticar.Name = "btAutenticar";
            btAutenticar.Size = new Size(200, 48);
            btAutenticar.TabIndex = 1;
            btAutenticar.Text = "Autênticar";
            btAutenticar.UseVisualStyleBackColor = true;
            btAutenticar.Click += BtAutenticar_Click;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(14, 103);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(200, 48);
            btCancelar.TabIndex = 2;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += BtCancelar_Click;
            // 
            // lblSenhaIcorreta
            // 
            lblSenhaIcorreta.AutoSize = true;
            lblSenhaIcorreta.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaIcorreta.ForeColor = Color.Red;
            lblSenhaIcorreta.Location = new Point(12, 79);
            lblSenhaIcorreta.Name = "lblSenhaIcorreta";
            lblSenhaIcorreta.Size = new Size(115, 18);
            lblSenhaIcorreta.TabIndex = 3;
            lblSenhaIcorreta.Text = "Senha incorreta";
            lblSenhaIcorreta.Visible = false;
            // 
            // timerPassword
            // 
            timerPassword.Interval = 2000;
            timerPassword.Tick += timerPassword_Tick;
            // 
            // boxPassword
            // 
            boxPassword.Location = new Point(15, 35);
            boxPassword.MaxLength = 4;
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '*';
            boxPassword.PlaceholderText = "Informe a senha";
            boxPassword.Size = new Size(408, 23);
            boxPassword.TabIndex = 4;
            boxPassword.UseSystemPasswordChar = true;
            boxPassword.WordWrap = false;
            // 
            // ModalPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 159);
            ControlBox = false;
            Controls.Add(boxPassword);
            Controls.Add(lblSenhaIcorreta);
            Controls.Add(btCancelar);
            Controls.Add(btAutenticar);
            Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(454, 175);
            MinimumSize = new Size(454, 175);
            Name = "ModalPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAutenticar;
        private Button btCancelar;
        private Label lblSenhaIcorreta;
        private System.Windows.Forms.Timer timerPassword;
        private TextBox boxPassword;
    }
}