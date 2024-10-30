namespace controle_vendas_comissoes.View.Forms.Produtos.Produtos
{
    partial class ProdutosLista
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
            btBuscaUnidadePrimaria = new FontAwesome.Sharp.IconButton();
            boxUnidadePrimaria = new MaterialSkin.Controls.MaterialTextBox();
            boxTextoBusca = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            btAdicionar = new FontAwesome.Sharp.IconButton();
            dataGridProdutos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btBuscaUnidadePrimaria);
            groupBox1.Controls.Add(boxUnidadePrimaria);
            groupBox1.Controls.Add(boxTextoBusca);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
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
            btBuscaUnidadePrimaria.Location = new Point(645, 18);
            btBuscaUnidadePrimaria.Name = "btBuscaUnidadePrimaria";
            btBuscaUnidadePrimaria.Size = new Size(50, 50);
            btBuscaUnidadePrimaria.TabIndex = 12;
            btBuscaUnidadePrimaria.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaUnidadePrimaria.UseVisualStyleBackColor = false;
            // 
            // boxUnidadePrimaria
            // 
            boxUnidadePrimaria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxUnidadePrimaria.AnimateReadOnly = false;
            boxUnidadePrimaria.BorderStyle = BorderStyle.None;
            boxUnidadePrimaria.Depth = 0;
            boxUnidadePrimaria.Enabled = false;
            boxUnidadePrimaria.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxUnidadePrimaria.Hint = "Unidade Primária";
            boxUnidadePrimaria.LeadingIcon = null;
            boxUnidadePrimaria.Location = new Point(391, 19);
            boxUnidadePrimaria.Margin = new Padding(2);
            boxUnidadePrimaria.MaxLength = 50;
            boxUnidadePrimaria.MouseState = MaterialSkin.MouseState.OUT;
            boxUnidadePrimaria.Multiline = false;
            boxUnidadePrimaria.Name = "boxUnidadePrimaria";
            boxUnidadePrimaria.Size = new Size(247, 50);
            boxUnidadePrimaria.TabIndex = 11;
            boxUnidadePrimaria.Text = "";
            boxUnidadePrimaria.TrailingIcon = null;
            // 
            // boxTextoBusca
            // 
            boxTextoBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxTextoBusca.AnimateReadOnly = false;
            boxTextoBusca.BorderStyle = BorderStyle.None;
            boxTextoBusca.Depth = 0;
            boxTextoBusca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxTextoBusca.Hint = "Texto busca";
            boxTextoBusca.LeadingIcon = null;
            boxTextoBusca.Location = new Point(5, 19);
            boxTextoBusca.Margin = new Padding(2);
            boxTextoBusca.MaxLength = 50;
            boxTextoBusca.MouseState = MaterialSkin.MouseState.OUT;
            boxTextoBusca.Multiline = false;
            boxTextoBusca.Name = "boxTextoBusca";
            boxTextoBusca.Size = new Size(379, 50);
            boxTextoBusca.TabIndex = 10;
            boxTextoBusca.Text = "";
            boxTextoBusca.TrailingIcon = null;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btAdicionar);
            groupBox2.Location = new Point(715, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 76);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ação";
            // 
            // btAdicionar
            // 
            btAdicionar.BackColor = Color.FromArgb(199, 199, 199);
            btAdicionar.FlatAppearance.BorderSize = 0;
            btAdicionar.FlatStyle = FlatStyle.Flat;
            btAdicionar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdicionar.ForeColor = Color.White;
            btAdicionar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btAdicionar.IconColor = Color.White;
            btAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btAdicionar.IconSize = 35;
            btAdicionar.Location = new Point(6, 18);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(123, 50);
            btAdicionar.TabIndex = 11;
            btAdicionar.Text = "ADICIONAR";
            btAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(0, 94);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(862, 310);
            dataGridProdutos.TabIndex = 5;
            // 
            // ProdutosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 404);
            Controls.Add(dataGridProdutos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(878, 443);
            Name = "ProdutosLista";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxTextoBusca;
        private MaterialSkin.Controls.MaterialTextBox boxUnidadePrimaria;
        private FontAwesome.Sharp.IconButton btBuscaUnidadePrimaria;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btAdicionar;
        private DataGridView dataGridProdutos;
    }
}