namespace controle_vendas_comissoes
{
    partial class CvcMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CvcMain));
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
            CardCabecalho.Size = new Size(1024, 53);
            CardCabecalho.TabIndex = 4;
            // 
            // CardMenuLateral
            // 
            CardMenuLateral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardMenuLateral.BackColor = Color.White;
            CardMenuLateral.Location = new Point(6, 60);
            CardMenuLateral.MaximumSize = new Size(196, 537);
            CardMenuLateral.Name = "CardMenuLateral";
            CardMenuLateral.Size = new Size(196, 392);
            CardMenuLateral.TabIndex = 2;
            // 
            // CvcMain
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1024, 540);
            Controls.Add(CardCabecalho);
            Controls.Add(CardMenuLateral);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            KeyPreview = true;
            Margin = new Padding(4);
            MinimumSize = new Size(916, 579);
            Name = "CvcMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de vendas e comissões";
            WindowState = FormWindowState.Maximized;
            Load += CvcMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel CardCabecalho;
        private Panel CardMenuLateral;
    }
}
