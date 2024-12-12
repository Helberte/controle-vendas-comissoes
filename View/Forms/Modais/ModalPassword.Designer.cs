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
            lblSenhaIcorreta = new Label();
            timerPassword = new System.Windows.Forms.Timer(components);
            boxPassword = new TextBox();
            btAutenticar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // lblSenhaIcorreta
            // 
            lblSenhaIcorreta.AutoSize = true;
            lblSenhaIcorreta.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaIcorreta.ForeColor = Color.Red;
            lblSenhaIcorreta.Location = new Point(12, 44);
            lblSenhaIcorreta.Name = "lblSenhaIcorreta";
            lblSenhaIcorreta.Size = new Size(115, 18);
            lblSenhaIcorreta.TabIndex = 3;
            lblSenhaIcorreta.Text = "Senha incorreta";
            lblSenhaIcorreta.Visible = false;
            // 
            // timerPassword
            // 
            timerPassword.Interval = 2000;
            timerPassword.Tick += TimerPassword_Tick;
            // 
            // boxPassword
            // 
            boxPassword.Location = new Point(15, 17);
            boxPassword.MaxLength = 4;
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '*';
            boxPassword.PlaceholderText = "Insira a senha";
            boxPassword.Size = new Size(408, 23);
            boxPassword.TabIndex = 4;
            boxPassword.UseSystemPasswordChar = true;
            boxPassword.KeyPress += BoxPassword_KeyPress;
            // 
            // btAutenticar
            // 
            btAutenticar.BackColor = Color.FromArgb(199, 199, 199);
            btAutenticar.FlatAppearance.BorderSize = 0;
            btAutenticar.FlatStyle = FlatStyle.Flat;
            btAutenticar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            btAutenticar.ForeColor = Color.White;
            btAutenticar.Location = new Point(223, 70);
            btAutenticar.Name = "btAutenticar";
            btAutenticar.Size = new Size(200, 30);
            btAutenticar.TabIndex = 6;
            btAutenticar.Text = "Autênticar";
            btAutenticar.UseVisualStyleBackColor = false;
            btAutenticar.Click += BtAutenticar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold);
            btCancelar.ForeColor = Color.White;
            btCancelar.Location = new Point(15, 70);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(200, 30);
            btCancelar.TabIndex = 7;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += BtCancelar_Click;
            // 
            // ModalPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 119);
            ControlBox = false;
            Controls.Add(btCancelar);
            Controls.Add(btAutenticar);
            Controls.Add(boxPassword);
            Controls.Add(lblSenhaIcorreta);
            Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(454, 158);
            MinimizeBox = false;
            MinimumSize = new Size(454, 158);
            Name = "ModalPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senha Autênticação";
            Load += ModalPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSenhaIcorreta;
        private System.Windows.Forms.Timer timerPassword;
        private TextBox boxPassword;
        private Button btAutenticar;
        private Button btCancelar;
    }
}