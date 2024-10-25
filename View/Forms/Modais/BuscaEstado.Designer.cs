namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class BuscaEstado
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
            groupBox1 = new GroupBox();
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            dataGridEstados = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskUF);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 74);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // maskUF
            // 
            maskUF.AllowPromptAsInput = true;
            maskUF.AnimateReadOnly = false;
            maskUF.AsciiOnly = false;
            maskUF.BackgroundImageLayout = ImageLayout.None;
            maskUF.BeepOnError = false;
            maskUF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.Depth = 0;
            maskUF.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskUF.HelperText = "UF";
            maskUF.HidePromptOnLeave = false;
            maskUF.HideSelection = true;
            maskUF.Hint = "UF";
            maskUF.InsertKeyMode = InsertKeyMode.Default;
            maskUF.LeadingIcon = null;
            maskUF.Location = new Point(363, 19);
            maskUF.Mask = "AAAA";
            maskUF.MaxLength = 32767;
            maskUF.MouseState = MaterialSkin.MouseState.OUT;
            maskUF.Name = "maskUF";
            maskUF.PasswordChar = '\0';
            maskUF.PrefixSuffixText = null;
            maskUF.PromptChar = '_';
            maskUF.ReadOnly = false;
            maskUF.RejectInputOnFirstFailure = false;
            maskUF.ResetOnPrompt = true;
            maskUF.ResetOnSpace = true;
            maskUF.RightToLeft = RightToLeft.No;
            maskUF.SelectedText = "";
            maskUF.SelectionLength = 0;
            maskUF.SelectionStart = 0;
            maskUF.ShortcutsEnabled = true;
            maskUF.Size = new Size(177, 48);
            maskUF.SkipLiterals = true;
            maskUF.TabIndex = 11;
            maskUF.TabStop = false;
            maskUF.TextAlign = HorizontalAlignment.Left;
            maskUF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.TrailingIcon = null;
            maskUF.UseSystemPasswordChar = false;
            maskUF.ValidatingType = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(7, 18);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(350, 50);
            boxNomeEstado.TabIndex = 10;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
            // 
            // dataGridEstados
            // 
            dataGridEstados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstados.Location = new Point(0, 81);
            dataGridEstados.Name = "dataGridEstados";
            dataGridEstados.Size = new Size(563, 303);
            dataGridEstados.TabIndex = 3;
            // 
            // BuscaEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 384);
            Controls.Add(dataGridEstados);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(579, 423);
            MinimumSize = new Size(579, 423);
            Name = "BuscaEstado";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Estado";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private DataGridView dataGridEstados;
    }
}