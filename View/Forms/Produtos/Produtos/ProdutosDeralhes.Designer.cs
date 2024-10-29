namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    partial class ProdutosDeralhes
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
            materialMultiLineTextBox3 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxNomePessoa = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            boxEstado = new MaterialSkin.Controls.MaterialTextBox();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            groupBox3 = new GroupBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            groupBox4 = new GroupBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(materialMultiLineTextBox3);
            groupBox1.Controls.Add(materialMultiLineTextBox2);
            groupBox1.Controls.Add(materialMultiLineTextBox1);
            groupBox1.Controls.Add(boxNomePessoa);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(933, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Básicas";
            // 
            // materialMultiLineTextBox3
            // 
            materialMultiLineTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox3.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox3.Depth = 0;
            materialMultiLineTextBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox3.Hint = "Descrição";
            materialMultiLineTextBox3.Location = new Point(6, 192);
            materialMultiLineTextBox3.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox3.Name = "materialMultiLineTextBox3";
            materialMultiLineTextBox3.Size = new Size(921, 49);
            materialMultiLineTextBox3.TabIndex = 6;
            materialMultiLineTextBox3.Text = "";
            // 
            // materialMultiLineTextBox2
            // 
            materialMultiLineTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox2.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox2.Depth = 0;
            materialMultiLineTextBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox2.Hint = "Descrição";
            materialMultiLineTextBox2.Location = new Point(6, 135);
            materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            materialMultiLineTextBox2.Size = new Size(921, 49);
            materialMultiLineTextBox2.TabIndex = 5;
            materialMultiLineTextBox2.Text = "";
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Hint = "Descrição";
            materialMultiLineTextBox1.Location = new Point(6, 78);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(921, 49);
            materialMultiLineTextBox1.TabIndex = 4;
            materialMultiLineTextBox1.Text = "";
            // 
            // boxNomePessoa
            // 
            boxNomePessoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomePessoa.AnimateReadOnly = false;
            boxNomePessoa.BorderStyle = BorderStyle.None;
            boxNomePessoa.Depth = 0;
            boxNomePessoa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomePessoa.Hint = "Nome do Produto";
            boxNomePessoa.LeadingIcon = null;
            boxNomePessoa.Location = new Point(6, 22);
            boxNomePessoa.Margin = new Padding(2);
            boxNomePessoa.MaxLength = 50;
            boxNomePessoa.MouseState = MaterialSkin.MouseState.OUT;
            boxNomePessoa.Multiline = false;
            boxNomePessoa.Name = "boxNomePessoa";
            boxNomePessoa.Size = new Size(921, 50);
            boxNomePessoa.TabIndex = 2;
            boxNomePessoa.Tag = "";
            boxNomePessoa.Text = "";
            boxNomePessoa.TrailingIcon = null;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btBuscaEstado);
            groupBox2.Controls.Add(boxEstado);
            groupBox2.Controls.Add(materialMaskedTextBox1);
            groupBox2.Location = new Point(5, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 132);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informaçõs Físicas";
            // 
            // btBuscaEstado
            // 
            btBuscaEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaEstado.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaEstado.FlatAppearance.BorderSize = 0;
            btBuscaEstado.FlatStyle = FlatStyle.Flat;
            btBuscaEstado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaEstado.IconColor = Color.White;
            btBuscaEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaEstado.IconSize = 35;
            btBuscaEstado.Location = new Point(325, 76);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(49, 49);
            btBuscaEstado.TabIndex = 14;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
            // 
            // boxEstado
            // 
            boxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxEstado.AnimateReadOnly = false;
            boxEstado.BorderStyle = BorderStyle.None;
            boxEstado.Depth = 0;
            boxEstado.Enabled = false;
            boxEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxEstado.Hint = "Unidade Primária";
            boxEstado.LeadingIcon = null;
            boxEstado.Location = new Point(6, 76);
            boxEstado.Margin = new Padding(2);
            boxEstado.MaxLength = 50;
            boxEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxEstado.Multiline = false;
            boxEstado.Name = "boxEstado";
            boxEstado.Size = new Size(314, 50);
            boxEstado.TabIndex = 13;
            boxEstado.Tag = "Estado";
            boxEstado.Text = "";
            boxEstado.TrailingIcon = null;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Peso Kg";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(6, 20);
            materialMaskedTextBox1.Mask = "00000000";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(368, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 8;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Tag = "";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(materialTextBox2);
            groupBox3.Controls.Add(materialTextBox1);
            groupBox3.Location = new Point(389, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 132);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tabelas Preço";
            // 
            // materialTextBox1
            // 
            materialTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Preço 1";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(7, 20);
            materialTextBox1.Margin = new Padding(2);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(535, 50);
            materialTextBox1.TabIndex = 3;
            materialTextBox1.Tag = "";
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Preço 2";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(7, 77);
            materialTextBox2.Margin = new Padding(2);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(535, 50);
            materialTextBox2.TabIndex = 4;
            materialTextBox2.Tag = "";
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(btCancelar);
            groupBox4.Controls.Add(btSalvar);
            groupBox4.Controls.Add(btSalvarMais);
            groupBox4.Location = new Point(606, 519);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(332, 59);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ações";
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
            btCancelar.Location = new Point(224, 18);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 18;
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
            btSalvar.Location = new Point(118, 18);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 17;
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
            btSalvarMais.Location = new Point(11, 18);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 16;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // ProdutosDeralhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 583);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(960, 622);
            MinimumSize = new Size(799, 517);
            Name = "ProdutosDeralhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do Produto";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomePessoa;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox3;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private MaterialSkin.Controls.MaterialTextBox boxEstado;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
    }
}