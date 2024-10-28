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
            boxNomePessoa = new MaterialSkin.Controls.MaterialTextBox();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialMultiLineTextBox3 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            groupBox2 = new GroupBox();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxEstado = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Size = new Size(772, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Básicas";
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
            boxNomePessoa.Size = new Size(760, 50);
            boxNomePessoa.TabIndex = 2;
            boxNomePessoa.Tag = "";
            boxNomePessoa.Text = "";
            boxNomePessoa.TrailingIcon = null;
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Hint = "Descrição";
            materialMultiLineTextBox1.Location = new Point(6, 78);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(760, 49);
            materialMultiLineTextBox1.TabIndex = 4;
            materialMultiLineTextBox1.Text = "";
            // 
            // materialMultiLineTextBox2
            // 
            materialMultiLineTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox2.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox2.Depth = 0;
            materialMultiLineTextBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox2.Hint = "Descrição";
            materialMultiLineTextBox2.Location = new Point(6, 135);
            materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            materialMultiLineTextBox2.Size = new Size(760, 49);
            materialMultiLineTextBox2.TabIndex = 5;
            materialMultiLineTextBox2.Text = "";
            // 
            // materialMultiLineTextBox3
            // 
            materialMultiLineTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialMultiLineTextBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox3.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox3.Depth = 0;
            materialMultiLineTextBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox3.Hint = "Descrição";
            materialMultiLineTextBox3.Location = new Point(6, 192);
            materialMultiLineTextBox3.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox3.Name = "materialMultiLineTextBox3";
            materialMultiLineTextBox3.Size = new Size(760, 49);
            materialMultiLineTextBox3.TabIndex = 6;
            materialMultiLineTextBox3.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btBuscaEstado);
            groupBox2.Controls.Add(boxEstado);
            groupBox2.Controls.Add(materialMaskedTextBox1);
            groupBox2.Location = new Point(5, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 132);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informaçõs Físicas";
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
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
            materialMaskedTextBox1.Size = new Size(367, 48);
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
            // boxEstado
            // 
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
            // btBuscaEstado
            // 
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
            // ProdutosDeralhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 507);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProdutosDeralhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do Produto";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
    }
}