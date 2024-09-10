namespace controle_vendas_comissoes.Biblioteca.Utils.Modais.Loader
{
    partial class ModalCarregando
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
            metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            metroProgressSpinner1.BackColor = Color.Aqua;
            metroProgressSpinner1.CustomBackground = false;
            metroProgressSpinner1.Location = new Point(25, 72);
            metroProgressSpinner1.Maximum = 100;
            metroProgressSpinner1.Name = "metroProgressSpinner1";
            metroProgressSpinner1.Size = new Size(112, 108);
            metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Blue;
            metroProgressSpinner1.StyleManager = null;
            metroProgressSpinner1.TabIndex = 0;
            metroProgressSpinner1.Text = "metroProgressSpinner1";
            metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroProgressSpinner1.UseWaitCursor = true;
            // 
            // metroLabel1
            // 
            metroLabel1.CustomBackground = false;
            metroLabel1.FlatStyle = FlatStyle.System;
            metroLabel1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel1.Location = new Point(143, 110);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(129, 26);
            metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 1;
            metroLabel1.Text = "Carregando...";
            metroLabel1.TextAlign = ContentAlignment.MiddleCenter;
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel1.UseStyleColors = false;
            metroLabel1.UseWaitCursor = true;
            // 
            // ModalCarregando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 250);
            ControlBox = false;
            Controls.Add(metroLabel1);
            Controls.Add(metroProgressSpinner1);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(392, 266);
            MinimizeBox = false;
            MinimumSize = new Size(392, 266);
            Name = "ModalCarregando";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            UseWaitCursor = true;
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}