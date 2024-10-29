namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class BuscaUnidadesPrimarias
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
            maskSigla = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeUnidade = new MaterialSkin.Controls.MaterialTextBox();
            dataGridUnidades = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(boxNomeUnidade);
            groupBox1.Controls.Add(maskSigla);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // maskSigla
            // 
            maskSigla.AllowPromptAsInput = true;
            maskSigla.AnimateReadOnly = false;
            maskSigla.AsciiOnly = false;
            maskSigla.BackgroundImageLayout = ImageLayout.None;
            maskSigla.BeepOnError = false;
            maskSigla.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskSigla.Depth = 0;
            maskSigla.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskSigla.HelperText = "Sigla";
            maskSigla.HidePromptOnLeave = false;
            maskSigla.HideSelection = true;
            maskSigla.Hint = "Sigla";
            maskSigla.InsertKeyMode = InsertKeyMode.Default;
            maskSigla.LeadingIcon = null;
            maskSigla.Location = new Point(363, 19);
            maskSigla.Mask = "AAAAAAAA";
            maskSigla.MaxLength = 32767;
            maskSigla.MouseState = MaterialSkin.MouseState.OUT;
            maskSigla.Name = "maskSigla";
            maskSigla.PasswordChar = '\0';
            maskSigla.PrefixSuffixText = null;
            maskSigla.PromptChar = '_';
            maskSigla.ReadOnly = false;
            maskSigla.RejectInputOnFirstFailure = false;
            maskSigla.ResetOnPrompt = true;
            maskSigla.ResetOnSpace = true;
            maskSigla.RightToLeft = RightToLeft.No;
            maskSigla.SelectedText = "";
            maskSigla.SelectionLength = 0;
            maskSigla.SelectionStart = 0;
            maskSigla.ShortcutsEnabled = true;
            maskSigla.Size = new Size(177, 48);
            maskSigla.SkipLiterals = true;
            maskSigla.TabIndex = 12;
            maskSigla.TabStop = false;
            maskSigla.TextAlign = HorizontalAlignment.Left;
            maskSigla.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskSigla.TrailingIcon = null;
            maskSigla.UseSystemPasswordChar = false;
            maskSigla.ValidatingType = null;
            // 
            // boxNomeUnidade
            // 
            boxNomeUnidade.AnimateReadOnly = false;
            boxNomeUnidade.BorderStyle = BorderStyle.None;
            boxNomeUnidade.Depth = 0;
            boxNomeUnidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeUnidade.Hint = "Nome Unidade";
            boxNomeUnidade.LeadingIcon = null;
            boxNomeUnidade.Location = new Point(7, 18);
            boxNomeUnidade.Margin = new Padding(2);
            boxNomeUnidade.MaxLength = 50;
            boxNomeUnidade.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeUnidade.Multiline = false;
            boxNomeUnidade.Name = "boxNomeUnidade";
            boxNomeUnidade.Size = new Size(350, 50);
            boxNomeUnidade.TabIndex = 13;
            boxNomeUnidade.Text = "";
            boxNomeUnidade.TrailingIcon = null;
            // 
            // dataGridUnidades
            // 
            dataGridUnidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUnidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUnidades.Location = new Point(0, 81);
            dataGridUnidades.Name = "dataGridUnidades";
            dataGridUnidades.Size = new Size(563, 303);
            dataGridUnidades.TabIndex = 4;
            // 
            // BuscaUnidadesPrimarias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 384);
            Controls.Add(dataGridUnidades);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(579, 423);
            MinimumSize = new Size(579, 423);
            Name = "BuscaUnidadesPrimarias";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Unidades Primarias";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskSigla;
        private MaterialSkin.Controls.MaterialTextBox boxNomeUnidade;
        private DataGridView dataGridUnidades;
    }
}