namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    partial class ProdutosDetalhes
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            boxModoUsar = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxComposicao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            boxPeso = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaUnidadePrimaria = new FontAwesome.Sharp.IconButton();
            boxUnidadePrimaria = new MaterialSkin.Controls.MaterialTextBox();
            groupBox3 = new GroupBox();
            boxPreco02 = new MaterialSkin.Controls.MaterialTextBox();
            boxPreco01 = new MaterialSkin.Controls.MaterialTextBox();
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(boxModoUsar);
            groupBox1.Controls.Add(boxComposicao);
            groupBox1.Controls.Add(boxDescricao);
            groupBox1.Controls.Add(boxNomeProduto);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(933, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Básicas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 223);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 9;
            label3.Text = "Modo de Usar (Opcional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 150);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 8;
            label2.Text = "Composição (Opcional)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 76);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 7;
            label1.Text = "Descrição (Opcional)";
            // 
            // boxModoUsar
            // 
            boxModoUsar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxModoUsar.BackColor = Color.FromArgb(255, 255, 255);
            boxModoUsar.BorderStyle = BorderStyle.None;
            boxModoUsar.Depth = 0;
            boxModoUsar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxModoUsar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            boxModoUsar.Hint = "Descrição";
            boxModoUsar.Location = new Point(6, 241);
            boxModoUsar.MouseState = MaterialSkin.MouseState.HOVER;
            boxModoUsar.Name = "boxModoUsar";
            boxModoUsar.Size = new Size(921, 49);
            boxModoUsar.TabIndex = 6;
            boxModoUsar.Text = "";
            // 
            // boxComposicao
            // 
            boxComposicao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxComposicao.BackColor = Color.FromArgb(255, 255, 255);
            boxComposicao.BorderStyle = BorderStyle.None;
            boxComposicao.Depth = 0;
            boxComposicao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxComposicao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            boxComposicao.Hint = "Descrição";
            boxComposicao.Location = new Point(6, 169);
            boxComposicao.MouseState = MaterialSkin.MouseState.HOVER;
            boxComposicao.Name = "boxComposicao";
            boxComposicao.Size = new Size(921, 49);
            boxComposicao.TabIndex = 5;
            boxComposicao.Text = "";
            // 
            // boxDescricao
            // 
            boxDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxDescricao.BackColor = Color.FromArgb(255, 255, 255);
            boxDescricao.BorderStyle = BorderStyle.None;
            boxDescricao.Depth = 0;
            boxDescricao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxDescricao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            boxDescricao.Hint = "Descrição";
            boxDescricao.Location = new Point(6, 96);
            boxDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            boxDescricao.Name = "boxDescricao";
            boxDescricao.Size = new Size(921, 49);
            boxDescricao.TabIndex = 4;
            boxDescricao.Text = "";
            // 
            // boxNomeProduto
            // 
            boxNomeProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomeProduto.AnimateReadOnly = false;
            boxNomeProduto.BorderStyle = BorderStyle.None;
            boxNomeProduto.Depth = 0;
            boxNomeProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeProduto.Hint = "Nome do Produto";
            boxNomeProduto.LeadingIcon = null;
            boxNomeProduto.Location = new Point(6, 22);
            boxNomeProduto.Margin = new Padding(2);
            boxNomeProduto.MaxLength = 50;
            boxNomeProduto.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeProduto.Multiline = false;
            boxNomeProduto.Name = "boxNomeProduto";
            boxNomeProduto.Size = new Size(921, 50);
            boxNomeProduto.TabIndex = 2;
            boxNomeProduto.Tag = "";
            boxNomeProduto.Text = "";
            boxNomeProduto.TrailingIcon = null;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(boxPeso);
            groupBox2.Controls.Add(btBuscaUnidadePrimaria);
            groupBox2.Controls.Add(boxUnidadePrimaria);
            groupBox2.Location = new Point(5, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 132);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informaçõs Físicas";
            // 
            // boxPeso
            // 
            boxPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPeso.AnimateReadOnly = false;
            boxPeso.BorderStyle = BorderStyle.None;
            boxPeso.Depth = 0;
            boxPeso.Font = new Font("Roboto", 12F);
            boxPeso.Hint = "Peso";
            boxPeso.LeadingIcon = null;
            boxPeso.Location = new Point(6, 20);
            boxPeso.Margin = new Padding(2);
            boxPeso.MaxLength = 10;
            boxPeso.MouseState = MaterialSkin.MouseState.OUT;
            boxPeso.Multiline = false;
            boxPeso.Name = "boxPeso";
            boxPeso.ShortcutsEnabled = false;
            boxPeso.Size = new Size(368, 50);
            boxPeso.TabIndex = 15;
            boxPeso.Tag = "";
            boxPeso.Text = "0,000";
            boxPeso.TrailingIcon = null;
            boxPeso.TextChanged += BoxPeso_TextChanged;
            boxPeso.KeyPress += BoxPeso_KeyPress;
            // 
            // btBuscaUnidadePrimaria
            // 
            btBuscaUnidadePrimaria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaUnidadePrimaria.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaUnidadePrimaria.FlatAppearance.BorderSize = 0;
            btBuscaUnidadePrimaria.FlatStyle = FlatStyle.Flat;
            btBuscaUnidadePrimaria.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaUnidadePrimaria.IconColor = Color.White;
            btBuscaUnidadePrimaria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaUnidadePrimaria.IconSize = 35;
            btBuscaUnidadePrimaria.Location = new Point(325, 76);
            btBuscaUnidadePrimaria.Name = "btBuscaUnidadePrimaria";
            btBuscaUnidadePrimaria.Size = new Size(49, 49);
            btBuscaUnidadePrimaria.TabIndex = 14;
            btBuscaUnidadePrimaria.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaUnidadePrimaria.UseVisualStyleBackColor = false;
            // 
            // boxUnidadePrimaria
            // 
            boxUnidadePrimaria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxUnidadePrimaria.AnimateReadOnly = false;
            boxUnidadePrimaria.BorderStyle = BorderStyle.None;
            boxUnidadePrimaria.Depth = 0;
            boxUnidadePrimaria.Enabled = false;
            boxUnidadePrimaria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxUnidadePrimaria.Hint = "Unidade Primária";
            boxUnidadePrimaria.LeadingIcon = null;
            boxUnidadePrimaria.Location = new Point(6, 76);
            boxUnidadePrimaria.Margin = new Padding(2);
            boxUnidadePrimaria.MaxLength = 50;
            boxUnidadePrimaria.MouseState = MaterialSkin.MouseState.OUT;
            boxUnidadePrimaria.Multiline = false;
            boxUnidadePrimaria.Name = "boxUnidadePrimaria";
            boxUnidadePrimaria.Size = new Size(314, 50);
            boxUnidadePrimaria.TabIndex = 13;
            boxUnidadePrimaria.Tag = "Estado";
            boxUnidadePrimaria.Text = "";
            boxUnidadePrimaria.TrailingIcon = null;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(boxPreco02);
            groupBox3.Controls.Add(boxPreco01);
            groupBox3.Location = new Point(389, 307);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 132);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tabelas Preço";
            // 
            // boxPreco02
            // 
            boxPreco02.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPreco02.AnimateReadOnly = false;
            boxPreco02.BorderStyle = BorderStyle.None;
            boxPreco02.Depth = 0;
            boxPreco02.Font = new Font("Roboto", 12F);
            boxPreco02.Hint = "Preço 2";
            boxPreco02.LeadingIcon = null;
            boxPreco02.Location = new Point(7, 77);
            boxPreco02.Margin = new Padding(2);
            boxPreco02.MaxLength = 10;
            boxPreco02.MouseState = MaterialSkin.MouseState.OUT;
            boxPreco02.Multiline = false;
            boxPreco02.Name = "boxPreco02";
            boxPreco02.ShortcutsEnabled = false;
            boxPreco02.Size = new Size(535, 50);
            boxPreco02.TabIndex = 4;
            boxPreco02.Tag = "";
            boxPreco02.Text = "0,00";
            boxPreco02.TrailingIcon = null;
            // 
            // boxPreco01
            // 
            boxPreco01.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPreco01.AnimateReadOnly = false;
            boxPreco01.BorderStyle = BorderStyle.None;
            boxPreco01.Depth = 0;
            boxPreco01.Font = new Font("Roboto", 12F);
            boxPreco01.Hint = "Preço 1";
            boxPreco01.LeadingIcon = null;
            boxPreco01.Location = new Point(7, 20);
            boxPreco01.Margin = new Padding(2);
            boxPreco01.MaxLength = 10;
            boxPreco01.MouseState = MaterialSkin.MouseState.OUT;
            boxPreco01.Multiline = false;
            boxPreco01.Name = "boxPreco01";
            boxPreco01.ShortcutsEnabled = false;
            boxPreco01.Size = new Size(535, 50);
            boxPreco01.TabIndex = 3;
            boxPreco01.Tag = "";
            boxPreco01.Text = "0,00";
            boxPreco01.TrailingIcon = null;
            boxPreco01.TextChanged += boxPreco01_TextChanged;
            boxPreco01.KeyPress += boxPreco01_KeyPress;
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
            // ProdutosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 583);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(960, 622);
            MinimumSize = new Size(799, 517);
            Name = "ProdutosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do Produto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeProduto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxDescricao;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxComposicao;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxModoUsar;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btBuscaUnidadePrimaria;
        private MaterialSkin.Controls.MaterialTextBox boxUnidadePrimaria;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox boxPreco02;
        private MaterialSkin.Controls.MaterialTextBox boxPreco01;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
        private Label label1;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox boxPeso;
    }
}