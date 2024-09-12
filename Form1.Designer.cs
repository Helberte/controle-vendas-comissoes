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
            CardCabecalho = new MaterialSkin.Controls.MaterialCard();
            CardMenuLateral = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            CardMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // CardCabecalho
            // 
            CardCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CardCabecalho.BackColor = Color.FromArgb(255, 255, 255);
            CardCabecalho.Depth = 0;
            CardCabecalho.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardCabecalho.Location = new Point(6, 70);
            CardCabecalho.Margin = new Padding(6);
            CardCabecalho.MouseState = MaterialSkin.MouseState.HOVER;
            CardCabecalho.Name = "CardCabecalho";
            CardCabecalho.Padding = new Padding(14);
            CardCabecalho.Size = new Size(1077, 53);
            CardCabecalho.TabIndex = 0;
            // 
            // CardMenuLateral
            // 
            CardMenuLateral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardMenuLateral.BackColor = Color.FromArgb(255, 255, 255);
            CardMenuLateral.Controls.Add(label1);
            CardMenuLateral.Depth = 0;
            CardMenuLateral.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardMenuLateral.Location = new Point(6, 130);
            CardMenuLateral.Margin = new Padding(14);
            CardMenuLateral.MaximumSize = new Size(195, 743);
            CardMenuLateral.MinimumSize = new Size(195, 406);
            CardMenuLateral.MouseState = MaterialSkin.MouseState.HOVER;
            CardMenuLateral.Name = "CardMenuLateral";
            CardMenuLateral.Padding = new Padding(14);
            CardMenuLateral.Size = new Size(195, 488);
            CardMenuLateral.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 22);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // CvcMain
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1089, 640);
            Controls.Add(CardMenuLateral);
            Controls.Add(CardCabecalho);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(4);
            MinimumSize = new Size(916, 579);
            Name = "CvcMain";
            Padding = new Padding(4, 94, 4, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de vendas e comissões";
            WindowState = FormWindowState.Maximized;
            Load += CvcMain_Load;
            CardMenuLateral.ResumeLayout(false);
            CardMenuLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard CardCabecalho;
        private MaterialSkin.Controls.MaterialCard CardMenuLateral;
        private Label label1;
    }
}
