namespace controle_vendas_comissoes.View.Forms.Produtos.UnidadesDeProdutos
{
    partial class UnidadesDeProdutosDetalhes
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
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskSigla);
            groupBox1.Controls.Add(boxNomeUnidade);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 91);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da Unidade";
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
            maskSigla.Location = new Point(390, 23);
            maskSigla.Margin = new Padding(2);
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
            maskSigla.Size = new Size(156, 48);
            maskSigla.SkipLiterals = true;
            maskSigla.TabIndex = 8;
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
            boxNomeUnidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeUnidade.Hint = "Nome da Unidade";
            boxNomeUnidade.LeadingIcon = null;
            boxNomeUnidade.Location = new Point(6, 22);
            boxNomeUnidade.Margin = new Padding(2);
            boxNomeUnidade.MaxLength = 50;
            boxNomeUnidade.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeUnidade.Multiline = false;
            boxNomeUnidade.Name = "boxNomeUnidade";
            boxNomeUnidade.Size = new Size(374, 50);
            boxNomeUnidade.TabIndex = 7;
            boxNomeUnidade.Text = "";
            boxNomeUnidade.TrailingIcon = null;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btCancelar.IconColor = Color.White;
            btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btCancelar.IconSize = 17;
            btCancelar.Location = new Point(463, 120);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 19;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.FromArgb(199, 199, 199);
            btSalvar.FlatAppearance.BorderSize = 0;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold);
            btSalvar.ForeColor = Color.White;
            btSalvar.IconChar = FontAwesome.Sharp.IconChar.None;
            btSalvar.IconColor = Color.Black;
            btSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvar.Location = new Point(360, 120);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 18;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = false;
            // 
            // btSalvarMais
            // 
            btSalvarMais.BackColor = Color.FromArgb(199, 199, 199);
            btSalvarMais.FlatAppearance.BorderSize = 0;
            btSalvarMais.FlatStyle = FlatStyle.Flat;
            btSalvarMais.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvarMais.ForeColor = Color.White;
            btSalvarMais.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btSalvarMais.IconColor = Color.White;
            btSalvarMais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvarMais.IconSize = 15;
            btSalvarMais.Location = new Point(257, 120);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 17;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // UnidadesDeProdutosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 163);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(581, 202);
            MinimumSize = new Size(581, 202);
            Name = "UnidadesDeProdutosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhe da Unidade do Produto";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskSigla;
        private MaterialSkin.Controls.MaterialTextBox boxNomeUnidade;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
    }
}