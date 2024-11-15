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
            groupInfoBasica = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            boxModoUsar = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxComposicao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            groupInfoFisica = new GroupBox();
            boxPeso = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaUnidadePrimaria = new FontAwesome.Sharp.IconButton();
            boxUnidadePrimaria = new MaterialSkin.Controls.MaterialTextBox();
            groupTabPrecos = new GroupBox();
            boxPrecoVenda02 = new MaterialSkin.Controls.MaterialTextBox();
            boxPrecoCusto02 = new MaterialSkin.Controls.MaterialTextBox();
            boxPrecoVenda01 = new MaterialSkin.Controls.MaterialTextBox();
            boxPrecoCusto01 = new MaterialSkin.Controls.MaterialTextBox();
            groupBox4 = new GroupBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            groupInfoBasica.SuspendLayout();
            groupInfoFisica.SuspendLayout();
            groupTabPrecos.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupInfoBasica
            // 
            groupInfoBasica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupInfoBasica.Controls.Add(dataGridView1);
            groupInfoBasica.Controls.Add(label3);
            groupInfoBasica.Controls.Add(groupTabPrecos);
            groupInfoBasica.Controls.Add(label2);
            groupInfoBasica.Controls.Add(groupInfoFisica);
            groupInfoBasica.Controls.Add(label1);
            groupInfoBasica.Controls.Add(boxModoUsar);
            groupInfoBasica.Controls.Add(boxComposicao);
            groupInfoBasica.Controls.Add(boxDescricao);
            groupInfoBasica.Controls.Add(boxNomeProduto);
            groupInfoBasica.Location = new Point(5, 4);
            groupInfoBasica.Name = "groupInfoBasica";
            groupInfoBasica.Size = new Size(1161, 731);
            groupInfoBasica.TabIndex = 0;
            groupInfoBasica.TabStop = false;
            groupInfoBasica.Text = "Informações do Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 281);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 9;
            label3.Text = "Modo de Usar (Opcional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 180);
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
            boxModoUsar.Location = new Point(6, 300);
            boxModoUsar.MouseState = MaterialSkin.MouseState.HOVER;
            boxModoUsar.Name = "boxModoUsar";
            boxModoUsar.Size = new Size(476, 76);
            boxModoUsar.TabIndex = 4;
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
            boxComposicao.Location = new Point(6, 199);
            boxComposicao.MouseState = MaterialSkin.MouseState.HOVER;
            boxComposicao.Name = "boxComposicao";
            boxComposicao.Size = new Size(476, 76);
            boxComposicao.TabIndex = 3;
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
            boxDescricao.Size = new Size(476, 76);
            boxDescricao.TabIndex = 2;
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
            boxNomeProduto.Size = new Size(1149, 50);
            boxNomeProduto.TabIndex = 1;
            boxNomeProduto.Tag = "";
            boxNomeProduto.Text = "";
            boxNomeProduto.TrailingIcon = null;
            // 
            // groupInfoFisica
            // 
            groupInfoFisica.Controls.Add(boxPeso);
            groupInfoFisica.Controls.Add(btBuscaUnidadePrimaria);
            groupInfoFisica.Controls.Add(boxUnidadePrimaria);
            groupInfoFisica.Location = new Point(6, 382);
            groupInfoFisica.Name = "groupInfoFisica";
            groupInfoFisica.Size = new Size(476, 132);
            groupInfoFisica.TabIndex = 13;
            groupInfoFisica.TabStop = false;
            groupInfoFisica.Text = "Informaçõs Físicas";
            // 
            // boxPeso
            // 
            boxPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPeso.AnimateReadOnly = false;
            boxPeso.BorderStyle = BorderStyle.None;
            boxPeso.Depth = 0;
            boxPeso.Font = new Font("Microsoft Sans Serif", 12F);
            boxPeso.Hint = "Peso";
            boxPeso.LeadingIcon = null;
            boxPeso.Location = new Point(6, 20);
            boxPeso.Margin = new Padding(2);
            boxPeso.MaxLength = 10;
            boxPeso.MouseState = MaterialSkin.MouseState.OUT;
            boxPeso.Multiline = false;
            boxPeso.Name = "boxPeso";
            boxPeso.ShortcutsEnabled = false;
            boxPeso.Size = new Size(464, 50);
            boxPeso.TabIndex = 5;
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
            btBuscaUnidadePrimaria.Location = new Point(421, 76);
            btBuscaUnidadePrimaria.Name = "btBuscaUnidadePrimaria";
            btBuscaUnidadePrimaria.Size = new Size(49, 49);
            btBuscaUnidadePrimaria.TabIndex = 6;
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
            boxUnidadePrimaria.Size = new Size(410, 50);
            boxUnidadePrimaria.TabIndex = 13;
            boxUnidadePrimaria.Tag = "Estado";
            boxUnidadePrimaria.Text = "";
            boxUnidadePrimaria.TrailingIcon = null;
            // 
            // groupTabPrecos
            // 
            groupTabPrecos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupTabPrecos.Controls.Add(boxPrecoVenda02);
            groupTabPrecos.Controls.Add(boxPrecoCusto02);
            groupTabPrecos.Controls.Add(boxPrecoVenda01);
            groupTabPrecos.Controls.Add(boxPrecoCusto01);
            groupTabPrecos.Location = new Point(6, 541);
            groupTabPrecos.Name = "groupTabPrecos";
            groupTabPrecos.Size = new Size(476, 132);
            groupTabPrecos.TabIndex = 14;
            groupTabPrecos.TabStop = false;
            groupTabPrecos.Text = "Tabelas Preço";
            groupTabPrecos.Visible = false;
            // 
            // boxPrecoVenda02
            // 
            boxPrecoVenda02.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPrecoVenda02.AnimateReadOnly = false;
            boxPrecoVenda02.BorderStyle = BorderStyle.None;
            boxPrecoVenda02.Depth = 0;
            boxPrecoVenda02.Font = new Font("Microsoft Sans Serif", 12F);
            boxPrecoVenda02.Hint = "Preço Venda 2 - R$";
            boxPrecoVenda02.LeadingIcon = null;
            boxPrecoVenda02.Location = new Point(279, 76);
            boxPrecoVenda02.Margin = new Padding(2);
            boxPrecoVenda02.MaxLength = 10;
            boxPrecoVenda02.MouseState = MaterialSkin.MouseState.OUT;
            boxPrecoVenda02.Multiline = false;
            boxPrecoVenda02.Name = "boxPrecoVenda02";
            boxPrecoVenda02.ShortcutsEnabled = false;
            boxPrecoVenda02.Size = new Size(189, 50);
            boxPrecoVenda02.TabIndex = 10;
            boxPrecoVenda02.Tag = "";
            boxPrecoVenda02.Text = "0,00";
            boxPrecoVenda02.TrailingIcon = null;
            boxPrecoVenda02.TextChanged += BoxPreco_TextChanged;
            boxPrecoVenda02.KeyPress += BoxPreco_KeyPress;
            // 
            // boxPrecoCusto02
            // 
            boxPrecoCusto02.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPrecoCusto02.AnimateReadOnly = false;
            boxPrecoCusto02.BorderStyle = BorderStyle.None;
            boxPrecoCusto02.Depth = 0;
            boxPrecoCusto02.Font = new Font("Microsoft Sans Serif", 12F);
            boxPrecoCusto02.Hint = "Preço Custo 2 - R$";
            boxPrecoCusto02.LeadingIcon = null;
            boxPrecoCusto02.Location = new Point(279, 20);
            boxPrecoCusto02.Margin = new Padding(2);
            boxPrecoCusto02.MaxLength = 10;
            boxPrecoCusto02.MouseState = MaterialSkin.MouseState.OUT;
            boxPrecoCusto02.Multiline = false;
            boxPrecoCusto02.Name = "boxPrecoCusto02";
            boxPrecoCusto02.ShortcutsEnabled = false;
            boxPrecoCusto02.Size = new Size(189, 50);
            boxPrecoCusto02.TabIndex = 9;
            boxPrecoCusto02.Tag = "";
            boxPrecoCusto02.Text = "0,00";
            boxPrecoCusto02.TrailingIcon = null;
            boxPrecoCusto02.TextChanged += BoxPreco_TextChanged;
            boxPrecoCusto02.KeyPress += BoxPreco_KeyPress;
            // 
            // boxPrecoVenda01
            // 
            boxPrecoVenda01.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPrecoVenda01.AnimateReadOnly = false;
            boxPrecoVenda01.BorderStyle = BorderStyle.None;
            boxPrecoVenda01.Depth = 0;
            boxPrecoVenda01.Font = new Font("Microsoft Sans Serif", 12F);
            boxPrecoVenda01.Hint = "Preço Venda 1 - R$";
            boxPrecoVenda01.LeadingIcon = null;
            boxPrecoVenda01.Location = new Point(6, 76);
            boxPrecoVenda01.Margin = new Padding(2);
            boxPrecoVenda01.MaxLength = 10;
            boxPrecoVenda01.MouseState = MaterialSkin.MouseState.OUT;
            boxPrecoVenda01.Multiline = false;
            boxPrecoVenda01.Name = "boxPrecoVenda01";
            boxPrecoVenda01.ShortcutsEnabled = false;
            boxPrecoVenda01.Size = new Size(193, 50);
            boxPrecoVenda01.TabIndex = 8;
            boxPrecoVenda01.Tag = "";
            boxPrecoVenda01.Text = "0,00";
            boxPrecoVenda01.TrailingIcon = null;
            boxPrecoVenda01.TextChanged += BoxPreco_TextChanged;
            boxPrecoVenda01.KeyPress += BoxPreco_KeyPress;
            // 
            // boxPrecoCusto01
            // 
            boxPrecoCusto01.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPrecoCusto01.AnimateReadOnly = false;
            boxPrecoCusto01.BorderStyle = BorderStyle.None;
            boxPrecoCusto01.Depth = 0;
            boxPrecoCusto01.Font = new Font("Microsoft Sans Serif", 12F);
            boxPrecoCusto01.Hint = "Preço Custo 1 - R$";
            boxPrecoCusto01.LeadingIcon = null;
            boxPrecoCusto01.Location = new Point(6, 20);
            boxPrecoCusto01.Margin = new Padding(2);
            boxPrecoCusto01.MaxLength = 10;
            boxPrecoCusto01.MouseState = MaterialSkin.MouseState.OUT;
            boxPrecoCusto01.Multiline = false;
            boxPrecoCusto01.Name = "boxPrecoCusto01";
            boxPrecoCusto01.ShortcutsEnabled = false;
            boxPrecoCusto01.Size = new Size(193, 50);
            boxPrecoCusto01.TabIndex = 7;
            boxPrecoCusto01.Tag = "";
            boxPrecoCusto01.Text = "0,00";
            boxPrecoCusto01.TrailingIcon = null;
            boxPrecoCusto01.TextChanged += BoxPreco_TextChanged;
            boxPrecoCusto01.KeyPress += BoxPreco_KeyPress;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(btCancelar);
            groupBox4.Controls.Add(btSalvar);
            groupBox4.Controls.Add(btSalvarMais);
            groupBox4.Location = new Point(834, 741);
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
            btCancelar.TabIndex = 11;
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
            btSalvar.TabIndex = 10;
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
            btSalvarMais.TabIndex = 9;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(488, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(667, 629);
            dataGridView1.TabIndex = 15;
            // 
            // ProdutosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 805);
            Controls.Add(groupBox4);
            Controls.Add(groupInfoBasica);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "ProdutosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do Produto";
            groupInfoBasica.ResumeLayout(false);
            groupInfoBasica.PerformLayout();
            groupInfoFisica.ResumeLayout(false);
            groupTabPrecos.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInfoBasica;
        private MaterialSkin.Controls.MaterialTextBox boxNomeProduto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxDescricao;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxComposicao;
        private MaterialSkin.Controls.MaterialMultiLineTextBox boxModoUsar;
        private GroupBox groupInfoFisica;
        private FontAwesome.Sharp.IconButton btBuscaUnidadePrimaria;
        private MaterialSkin.Controls.MaterialTextBox boxUnidadePrimaria;
        private GroupBox groupTabPrecos;
        private MaterialSkin.Controls.MaterialTextBox boxPrecoVenda01;
        private MaterialSkin.Controls.MaterialTextBox boxPrecoCusto01;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
        private Label label1;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox boxPeso;
        private MaterialSkin.Controls.MaterialTextBox boxPrecoVenda02;
        private MaterialSkin.Controls.MaterialTextBox boxPrecoCusto02;
        private DataGridView dataGridView1;
    }
}