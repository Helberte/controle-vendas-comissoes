namespace controle_vendas_comissoes.View.Forms.Main
{
    partial class FormMain
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
            CardCabecalho = new Panel();
            lblCidadeData = new Label();
            CardMenuLateral = new Panel();
            timerDataHora = new System.Windows.Forms.Timer(components);
            CardCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // CardCabecalho
            // 
            CardCabecalho.BackColor = Color.White;
            CardCabecalho.Controls.Add(lblCidadeData);
            CardCabecalho.Dock = DockStyle.Top;
            CardCabecalho.Location = new Point(0, 0);
            CardCabecalho.Name = "CardCabecalho";
            CardCabecalho.Size = new Size(876, 53);
            CardCabecalho.TabIndex = 5;
            // 
            // lblCidadeData
            // 
            lblCidadeData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCidadeData.AutoSize = true;
            lblCidadeData.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCidadeData.ForeColor = Color.FromArgb(130, 130, 130);
            lblCidadeData.Location = new Point(602, 16);
            lblCidadeData.Name = "lblCidadeData";
            lblCidadeData.Size = new Size(262, 22);
            lblCidadeData.TabIndex = 0;
            lblCidadeData.Text = "JARU - RO  00-00-0000 - 00:00";
            // 
            // CardMenuLateral
            // 
            CardMenuLateral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardMenuLateral.BackColor = Color.White;
            CardMenuLateral.Location = new Point(6, 68);
            CardMenuLateral.MaximumSize = new Size(196, 537);
            CardMenuLateral.Name = "CardMenuLateral";
            CardMenuLateral.Size = new Size(196, 419);
            CardMenuLateral.TabIndex = 6;
            // 
            // timerDataHora
            // 
            timerDataHora.Enabled = true;
            timerDataHora.Interval = 500;
            timerDataHora.Tick += timerDataHora_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 490);
            Controls.Add(CardMenuLateral);
            Controls.Add(CardCabecalho);
            MinimumSize = new Size(872, 529);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Vendas e Comissões";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            CardCabecalho.ResumeLayout(false);
            CardCabecalho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CardCabecalho;
        private Panel CardMenuLateral;
        private Label lblCidadeData;
        private System.Windows.Forms.Timer timerDataHora;
    }
}