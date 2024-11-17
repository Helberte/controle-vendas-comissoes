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
            groupBox4 = new GroupBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            groupInfoFisica = new GroupBox();
            boxPeso = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaUnidadePrimaria = new FontAwesome.Sharp.IconButton();
            boxUnidadePrimaria = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            boxModoUsar = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxComposicao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxDescricao = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            boxNomeProduto = new MaterialSkin.Controls.MaterialTextBox();
            groupInfoBasica.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupInfoFisica.SuspendLayout();
            SuspendLayout();
            // 
            // groupInfoBasica
            // 
            groupInfoBasica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupInfoBasica.Controls.Add(groupBox4);
            groupInfoBasica.Controls.Add(dataGridView1);
            groupInfoBasica.Controls.Add(label3);
            groupInfoBasica.Controls.Add(label2);
            groupInfoBasica.Controls.Add(groupInfoFisica);
            groupInfoBasica.Controls.Add(label1);
            groupInfoBasica.Controls.Add(boxModoUsar);
            groupInfoBasica.Controls.Add(boxComposicao);
            groupInfoBasica.Controls.Add(boxDescricao);
            groupInfoBasica.Controls.Add(boxNomeProduto);
            groupInfoBasica.Location = new Point(5, 4);
            groupInfoBasica.Name = "groupInfoBasica";
            groupInfoBasica.Size = new Size(1162, 674);
            groupInfoBasica.TabIndex = 0;
            groupInfoBasica.TabStop = false;
            groupInfoBasica.Text = "Informações do Produto";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btCancelar);
            groupBox4.Controls.Add(btSalvar);
            groupBox4.Controls.Add(btSalvarMais);
            groupBox4.Location = new Point(6, 609);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(477, 59);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ações";
            // 
            // btCancelar
            // 
            btCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btCancelar.IconColor = Color.White;
            btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btCancelar.IconSize = 17;
            btCancelar.Location = new Point(327, 18);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(140, 33);
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
            btSalvar.Location = new Point(168, 18);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(140, 33);
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
            btSalvarMais.Location = new Point(9, 18);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(140, 33);
            btSalvarMais.TabIndex = 9;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(489, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(667, 572);
            dataGridView1.TabIndex = 15;
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
            // groupInfoFisica
            // 
            groupInfoFisica.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupInfoFisica.Controls.Add(boxPeso);
            groupInfoFisica.Controls.Add(btBuscaUnidadePrimaria);
            groupInfoFisica.Controls.Add(boxUnidadePrimaria);
            groupInfoFisica.Location = new Point(6, 386);
            groupInfoFisica.Name = "groupInfoFisica";
            groupInfoFisica.Size = new Size(477, 132);
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
            boxPeso.Size = new Size(465, 50);
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
            btBuscaUnidadePrimaria.Location = new Point(422, 76);
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
            boxUnidadePrimaria.Size = new Size(411, 50);
            boxUnidadePrimaria.TabIndex = 13;
            boxUnidadePrimaria.Tag = "Estado";
            boxUnidadePrimaria.Text = "";
            boxUnidadePrimaria.TrailingIcon = null;
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
            boxModoUsar.Size = new Size(477, 76);
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
            boxComposicao.Size = new Size(477, 76);
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
            boxDescricao.Size = new Size(477, 76);
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
            boxNomeProduto.Size = new Size(1150, 50);
            boxNomeProduto.TabIndex = 1;
            boxNomeProduto.Tag = "";
            boxNomeProduto.Text = "";
            boxNomeProduto.TrailingIcon = null;
            // 
            // ProdutosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 684);
            Controls.Add(groupInfoBasica);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(1561, 899);
            MinimumSize = new Size(1189, 723);
            Name = "ProdutosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes do Produto";
            groupInfoBasica.ResumeLayout(false);
            groupInfoBasica.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupInfoFisica.ResumeLayout(false);
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
        private Label label1;
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox boxPeso;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
    }
}