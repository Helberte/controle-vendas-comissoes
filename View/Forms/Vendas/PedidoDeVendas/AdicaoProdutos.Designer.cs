namespace controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas
{
    partial class AdicaoProdutos
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
            lblNomeEstado = new Label();
            boxTextoPesquisa = new MaterialSkin.Controls.MaterialTextBox();
            dataGridProdutos = new DataGridView();
            boxQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            groupBox1 = new GroupBox();
            lblProdutoSelecionado = new Label();
            lblIdProdutoSelecionado = new Label();
            btAdicionar = new FontAwesome.Sharp.IconButton();
            dataGridProdutosVenda = new DataGridView();
            dataGridComissaoClassificacao = new DataGridView();
            label4 = new Label();
            lblTotalGeral = new Label();
            boxValorDesconto = new MaterialSkin.Controls.MaterialTextBox();
            boxDesconto = new MaterialSkin.Controls.MaterialTextBox();
            dataGridTotaisVenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutosVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissaoClassificacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTotaisVenda).BeginInit();
            SuspendLayout();
            // 
            // lblNomeEstado
            // 
            lblNomeEstado.AutoSize = true;
            lblNomeEstado.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeEstado.Location = new Point(6, 9);
            lblNomeEstado.Name = "lblNomeEstado";
            lblNomeEstado.Size = new Size(217, 33);
            lblNomeEstado.TabIndex = 0;
            lblNomeEstado.Text = "Mato Grosso do Sul";
            // 
            // boxTextoPesquisa
            // 
            boxTextoPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxTextoPesquisa.AnimateReadOnly = false;
            boxTextoPesquisa.BorderStyle = BorderStyle.None;
            boxTextoPesquisa.Depth = 0;
            boxTextoPesquisa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxTextoPesquisa.Hint = "Informações do produto que deseja buscar";
            boxTextoPesquisa.LeadingIcon = null;
            boxTextoPesquisa.Location = new Point(12, 45);
            boxTextoPesquisa.MaximumSize = new Size(929, 50);
            boxTextoPesquisa.MaxLength = 50;
            boxTextoPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            boxTextoPesquisa.Multiline = false;
            boxTextoPesquisa.Name = "boxTextoPesquisa";
            boxTextoPesquisa.Size = new Size(854, 50);
            boxTextoPesquisa.TabIndex = 1;
            boxTextoPesquisa.Text = "";
            boxTextoPesquisa.TrailingIcon = null;
            boxTextoPesquisa.KeyPress += BoxTextoPesquisa_KeyPress;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(0, 101);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(1085, 241);
            dataGridProdutos.TabIndex = 2;
            dataGridProdutos.SelectionChanged += DataGridProdutos_SelectionChanged;
            // 
            // boxQuantidade
            // 
            boxQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxQuantidade.AnimateReadOnly = false;
            boxQuantidade.BorderStyle = BorderStyle.None;
            boxQuantidade.Depth = 0;
            boxQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxQuantidade.Hint = "Quantidade";
            boxQuantidade.LeadingIcon = null;
            boxQuantidade.Location = new Point(555, 349);
            boxQuantidade.MaxLength = 6;
            boxQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            boxQuantidade.Multiline = false;
            boxQuantidade.Name = "boxQuantidade";
            boxQuantidade.Size = new Size(122, 50);
            boxQuantidade.TabIndex = 5;
            boxQuantidade.Text = "";
            boxQuantidade.TrailingIcon = null;
            boxQuantidade.TextChanged += boxQuantidade_TextChanged;
            boxQuantidade.KeyPress += boxQuantidade_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblProdutoSelecionado);
            groupBox1.Controls.Add(lblIdProdutoSelecionado);
            groupBox1.Location = new Point(6, 343);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 55);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // lblProdutoSelecionado
            // 
            lblProdutoSelecionado.AutoSize = true;
            lblProdutoSelecionado.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutoSelecionado.Location = new Point(53, 20);
            lblProdutoSelecionado.Name = "lblProdutoSelecionado";
            lblProdutoSelecionado.Size = new Size(272, 25);
            lblProdutoSelecionado.TabIndex = 6;
            lblProdutoSelecionado.Text = "CURCUMA NOME DO PRODUTO";
            // 
            // lblIdProdutoSelecionado
            // 
            lblIdProdutoSelecionado.AutoSize = true;
            lblIdProdutoSelecionado.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProdutoSelecionado.Location = new Point(6, 17);
            lblIdProdutoSelecionado.Name = "lblIdProdutoSelecionado";
            lblIdProdutoSelecionado.Size = new Size(42, 30);
            lblIdProdutoSelecionado.TabIndex = 5;
            lblIdProdutoSelecionado.Text = "152";
            // 
            // btAdicionar
            // 
            btAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btAdicionar.BackColor = Color.FromArgb(199, 199, 199);
            btAdicionar.FlatAppearance.BorderSize = 0;
            btAdicionar.FlatStyle = FlatStyle.Flat;
            btAdicionar.Font = new Font("Montserrat SemiBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdicionar.ForeColor = Color.White;
            btAdicionar.IconChar = FontAwesome.Sharp.IconChar.None;
            btAdicionar.IconColor = Color.Black;
            btAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btAdicionar.Location = new Point(945, 348);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(128, 50);
            btAdicionar.TabIndex = 8;
            btAdicionar.Text = "ADICIONAR";
            btAdicionar.UseVisualStyleBackColor = false;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // dataGridProdutosVenda
            // 
            dataGridProdutosVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutosVenda.Location = new Point(0, 406);
            dataGridProdutosVenda.Name = "dataGridProdutosVenda";
            dataGridProdutosVenda.Size = new Size(621, 269);
            dataGridProdutosVenda.TabIndex = 8;
            // 
            // dataGridComissaoClassificacao
            // 
            dataGridComissaoClassificacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridComissaoClassificacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComissaoClassificacao.Location = new Point(627, 406);
            dataGridComissaoClassificacao.Name = "dataGridComissaoClassificacao";
            dataGridComissaoClassificacao.Size = new Size(458, 119);
            dataGridComissaoClassificacao.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 688);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 10;
            label4.Text = "Total Geral R$:";
            // 
            // lblTotalGeral
            // 
            lblTotalGeral.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalGeral.AutoSize = true;
            lblTotalGeral.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGeral.Location = new Point(124, 688);
            lblTotalGeral.Name = "lblTotalGeral";
            lblTotalGeral.Size = new Size(38, 25);
            lblTotalGeral.TabIndex = 11;
            lblTotalGeral.Text = "150";
            // 
            // boxValorDesconto
            // 
            boxValorDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxValorDesconto.AnimateReadOnly = false;
            boxValorDesconto.BorderStyle = BorderStyle.None;
            boxValorDesconto.Depth = 0;
            boxValorDesconto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxValorDesconto.Hint = "Valor Desconto";
            boxValorDesconto.LeadingIcon = null;
            boxValorDesconto.Location = new Point(683, 349);
            boxValorDesconto.MaxLength = 50;
            boxValorDesconto.MouseState = MaterialSkin.MouseState.OUT;
            boxValorDesconto.Multiline = false;
            boxValorDesconto.Name = "boxValorDesconto";
            boxValorDesconto.Size = new Size(138, 50);
            boxValorDesconto.TabIndex = 6;
            boxValorDesconto.Text = "";
            boxValorDesconto.TrailingIcon = null;
            boxValorDesconto.TextChanged += boxValorDesconto_TextChanged;
            boxValorDesconto.KeyPress += boxValorDesconto_KeyPress;
            // 
            // boxDesconto
            // 
            boxDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxDesconto.AnimateReadOnly = false;
            boxDesconto.BorderStyle = BorderStyle.None;
            boxDesconto.Depth = 0;
            boxDesconto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxDesconto.Hint = "% Desconto";
            boxDesconto.LeadingIcon = null;
            boxDesconto.Location = new Point(826, 349);
            boxDesconto.MaxLength = 50;
            boxDesconto.MouseState = MaterialSkin.MouseState.OUT;
            boxDesconto.Multiline = false;
            boxDesconto.Name = "boxDesconto";
            boxDesconto.Size = new Size(114, 50);
            boxDesconto.TabIndex = 7;
            boxDesconto.Text = "";
            boxDesconto.TrailingIcon = null;
            boxDesconto.TextChanged += boxDesconto_TextChanged;
            boxDesconto.KeyPress += boxDesconto_KeyPress;
            // 
            // dataGridTotaisVenda
            // 
            dataGridTotaisVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridTotaisVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTotaisVenda.Location = new Point(627, 531);
            dataGridTotaisVenda.Name = "dataGridTotaisVenda";
            dataGridTotaisVenda.Size = new Size(458, 144);
            dataGridTotaisVenda.TabIndex = 20;
            // 
            // AdicaoProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 719);
            Controls.Add(dataGridTotaisVenda);
            Controls.Add(boxDesconto);
            Controls.Add(boxValorDesconto);
            Controls.Add(lblTotalGeral);
            Controls.Add(label4);
            Controls.Add(dataGridComissaoClassificacao);
            Controls.Add(dataGridProdutosVenda);
            Controls.Add(btAdicionar);
            Controls.Add(groupBox1);
            Controls.Add(boxQuantidade);
            Controls.Add(dataGridProdutos);
            Controls.Add(boxTextoPesquisa);
            Controls.Add(lblNomeEstado);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(867, 758);
            Name = "AdicaoProdutos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Produtos";
            Load += AdicaoProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutosVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissaoClassificacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTotaisVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeEstado;
        private MaterialSkin.Controls.MaterialTextBox boxTextoPesquisa;
        private DataGridView dataGridProdutos;
        private MaterialSkin.Controls.MaterialTextBox boxQuantidade;
        private GroupBox groupBox1;
        private Label lblProdutoSelecionado;
        private Label lblIdProdutoSelecionado;
        private FontAwesome.Sharp.IconButton btAdicionar;
        private DataGridView dataGridProdutosVenda;
        private DataGridView dataGridComissaoClassificacao;
        private Label label4;
        private Label lblTotalGeral;
        private MaterialSkin.Controls.MaterialTextBox boxValorDesconto;
        private MaterialSkin.Controls.MaterialTextBox boxDesconto;
        private DataGridView dataGridTotaisVenda;
    }
}