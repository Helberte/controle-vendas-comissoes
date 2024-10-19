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
            CardCabecalho = new Panel();
            CardMenuLateral = new Panel();
            SuspendLayout();
            // 
            // CardCabecalho
            // 
            CardCabecalho.BackColor = Color.White;
            CardCabecalho.Dock = DockStyle.Top;
            CardCabecalho.Location = new Point(0, 0);
            CardCabecalho.Name = "CardCabecalho";
            CardCabecalho.Size = new Size(856, 53);
            CardCabecalho.TabIndex = 5;
            // 
            // CardMenuLateral
            // 
            CardMenuLateral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardMenuLateral.BackColor = Color.White;
            CardMenuLateral.Location = new Point(6, 59);
            CardMenuLateral.MaximumSize = new Size(196, 537);
            CardMenuLateral.Name = "CardMenuLateral";
            CardMenuLateral.Size = new Size(196, 419);
            CardMenuLateral.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 490);
            Controls.Add(CardMenuLateral);
            Controls.Add(CardCabecalho);
            MinimumSize = new Size(872, 529);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Vendas e Comissões";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel CardCabecalho;
        private Panel CardMenuLateral;
    }
}