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
            boxValorDesconto = new MaterialSkin.Controls.MaterialTextBox();
            boxDesconto = new MaterialSkin.Controls.MaterialTextBox();
            lblTotalComDesconto = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            lblValorDesconto = new Label();
            label5 = new Label();
            lblPorcentagemDesconto = new Label();
            label2 = new Label();
            lblTotalGeral = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lblTotalComDescontoProdutos = new Label();
            label14 = new Label();
            lblValorDescontoProdutos = new Label();
            label12 = new Label();
            lblPorcentagemDescontoProdutos = new Label();
            label10 = new Label();
            lblTotalGeralProdutos = new Label();
            label8 = new Label();
            lblQuantidadeItens = new Label();
            label3 = new Label();
            groupBoxTotaisClassificacoes = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutosVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissaoClassificacao).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeEstado
            // 
            lblNomeEstado.AutoSize = true;
            lblNomeEstado.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeEstado.Location = new Point(6, 9);
            lblNomeEstado.Name = "lblNomeEstado";
            lblNomeEstado.Size = new Size(189, 29);
            lblNomeEstado.TabIndex = 0;
            lblNomeEstado.Text = "Nome do Estado";
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
            boxTextoPesquisa.Size = new Size(856, 50);
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
            dataGridProdutos.Size = new Size(1087, 241);
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
            boxQuantidade.Location = new Point(557, 349);
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
            groupBox1.Size = new Size(545, 55);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // lblProdutoSelecionado
            // 
            lblProdutoSelecionado.AutoSize = true;
            lblProdutoSelecionado.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutoSelecionado.Location = new Point(53, 20);
            lblProdutoSelecionado.Name = "lblProdutoSelecionado";
            lblProdutoSelecionado.Size = new Size(180, 22);
            lblProdutoSelecionado.TabIndex = 6;
            lblProdutoSelecionado.Text = "NOME DO PRODUTO";
            // 
            // lblIdProdutoSelecionado
            // 
            lblIdProdutoSelecionado.AutoSize = true;
            lblIdProdutoSelecionado.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProdutoSelecionado.Location = new Point(6, 17);
            lblIdProdutoSelecionado.Name = "lblIdProdutoSelecionado";
            lblIdProdutoSelecionado.Size = new Size(51, 26);
            lblIdProdutoSelecionado.TabIndex = 5;
            lblIdProdutoSelecionado.Text = "000";
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
            btAdicionar.Location = new Point(947, 348);
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
            dataGridProdutosVenda.Size = new Size(623, 310);
            dataGridProdutosVenda.TabIndex = 8;
            // 
            // dataGridComissaoClassificacao
            // 
            dataGridComissaoClassificacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridComissaoClassificacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComissaoClassificacao.Location = new Point(629, 406);
            dataGridComissaoClassificacao.Name = "dataGridComissaoClassificacao";
            dataGridComissaoClassificacao.Size = new Size(458, 119);
            dataGridComissaoClassificacao.TabIndex = 9;
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
            boxValorDesconto.Location = new Point(685, 349);
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
            boxDesconto.Location = new Point(828, 349);
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
            // lblTotalComDesconto
            // 
            lblTotalComDesconto.AutoSize = true;
            lblTotalComDesconto.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblTotalComDesconto.Location = new Point(623, 19);
            lblTotalComDesconto.Name = "lblTotalComDesconto";
            lblTotalComDesconto.Size = new Size(17, 18);
            lblTotalComDesconto.TabIndex = 26;
            lblTotalComDesconto.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 9.749999F);
            label7.Location = new Point(507, 19);
            label7.Name = "label7";
            label7.Size = new Size(121, 18);
            label7.TabIndex = 25;
            label7.Text = "Total C. Desconto:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(lblValorDesconto);
            groupBox2.Controls.Add(lblTotalComDesconto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblPorcentagemDesconto);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lblTotalGeral);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(6, 718);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 46);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Totais do Pedido como um todo";
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblValorDesconto.Location = new Point(413, 19);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(17, 18);
            lblValorDesconto.TabIndex = 26;
            lblValorDesconto.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 9.749999F);
            label5.Location = new Point(330, 19);
            label5.Name = "label5";
            label5.Size = new Size(88, 18);
            label5.TabIndex = 25;
            label5.Text = "V. Desconto:";
            // 
            // lblPorcentagemDesconto
            // 
            lblPorcentagemDesconto.AutoSize = true;
            lblPorcentagemDesconto.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblPorcentagemDesconto.Location = new Point(261, 19);
            lblPorcentagemDesconto.Name = "lblPorcentagemDesconto";
            lblPorcentagemDesconto.Size = new Size(17, 18);
            lblPorcentagemDesconto.TabIndex = 24;
            lblPorcentagemDesconto.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9.749999F);
            label2.Location = new Point(179, 19);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 23;
            label2.Text = "% Desconto:";
            // 
            // lblTotalGeral
            // 
            lblTotalGeral.AutoSize = true;
            lblTotalGeral.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblTotalGeral.Location = new Point(96, 19);
            lblTotalGeral.Name = "lblTotalGeral";
            lblTotalGeral.Size = new Size(17, 18);
            lblTotalGeral.TabIndex = 13;
            lblTotalGeral.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 19);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 12;
            label4.Text = "Total Geral R$:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(lblTotalComDescontoProdutos);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(lblValorDescontoProdutos);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(lblPorcentagemDescontoProdutos);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblTotalGeralProdutos);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblQuantidadeItens);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(629, 531);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 185);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totais Produto";
            // 
            // lblTotalComDescontoProdutos
            // 
            lblTotalComDescontoProdutos.AutoSize = true;
            lblTotalComDescontoProdutos.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblTotalComDescontoProdutos.Location = new Point(117, 148);
            lblTotalComDescontoProdutos.Name = "lblTotalComDescontoProdutos";
            lblTotalComDescontoProdutos.Size = new Size(17, 18);
            lblTotalComDescontoProdutos.TabIndex = 23;
            lblTotalComDescontoProdutos.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(7, 148);
            label14.Name = "label14";
            label14.Size = new Size(114, 18);
            label14.TabIndex = 22;
            label14.Text = "Total C. Desc. R$:";
            // 
            // lblValorDescontoProdutos
            // 
            lblValorDescontoProdutos.AutoSize = true;
            lblValorDescontoProdutos.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblValorDescontoProdutos.Location = new Point(117, 117);
            lblValorDescontoProdutos.Name = "lblValorDescontoProdutos";
            lblValorDescontoProdutos.Size = new Size(17, 18);
            lblValorDescontoProdutos.TabIndex = 21;
            lblValorDescontoProdutos.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 117);
            label12.Name = "label12";
            label12.Size = new Size(116, 18);
            label12.TabIndex = 20;
            label12.Text = "Vlr. Desconto R$:";
            // 
            // lblPorcentagemDescontoProdutos
            // 
            lblPorcentagemDescontoProdutos.AutoSize = true;
            lblPorcentagemDescontoProdutos.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblPorcentagemDescontoProdutos.Location = new Point(117, 86);
            lblPorcentagemDescontoProdutos.Name = "lblPorcentagemDescontoProdutos";
            lblPorcentagemDescontoProdutos.Size = new Size(17, 18);
            lblPorcentagemDescontoProdutos.TabIndex = 19;
            lblPorcentagemDescontoProdutos.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 86);
            label10.Name = "label10";
            label10.Size = new Size(87, 18);
            label10.TabIndex = 18;
            label10.Text = "% Desconto:";
            // 
            // lblTotalGeralProdutos
            // 
            lblTotalGeralProdutos.AutoSize = true;
            lblTotalGeralProdutos.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblTotalGeralProdutos.Location = new Point(117, 56);
            lblTotalGeralProdutos.Name = "lblTotalGeralProdutos";
            lblTotalGeralProdutos.Size = new Size(17, 18);
            lblTotalGeralProdutos.TabIndex = 17;
            lblTotalGeralProdutos.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 56);
            label8.Name = "label8";
            label8.Size = new Size(97, 18);
            label8.TabIndex = 16;
            label8.Text = "Total Geral R$:";
            // 
            // lblQuantidadeItens
            // 
            lblQuantidadeItens.AutoSize = true;
            lblQuantidadeItens.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            lblQuantidadeItens.Location = new Point(117, 27);
            lblQuantidadeItens.Name = "lblQuantidadeItens";
            lblQuantidadeItens.Size = new Size(17, 18);
            lblQuantidadeItens.TabIndex = 15;
            lblQuantidadeItens.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 14;
            label3.Text = "Qtd. Itens:";
            // 
            // groupBoxTotaisClassificacoes
            // 
            groupBoxTotaisClassificacoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxTotaisClassificacoes.Location = new Point(855, 531);
            groupBoxTotaisClassificacoes.Name = "groupBoxTotaisClassificacoes";
            groupBoxTotaisClassificacoes.Size = new Size(220, 185);
            groupBoxTotaisClassificacoes.TabIndex = 29;
            groupBoxTotaisClassificacoes.TabStop = false;
            groupBoxTotaisClassificacoes.Text = "Totais Classificações";
            // 
            // AdicaoProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 768);
            Controls.Add(groupBoxTotaisClassificacoes);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(boxDesconto);
            Controls.Add(boxValorDesconto);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox boxValorDesconto;
        private MaterialSkin.Controls.MaterialTextBox boxDesconto;
        private Label lblTotalComDesconto;
        private Label label7;
        private GroupBox groupBox2;
        private Label lblValorDesconto;
        private Label label5;
        private Label lblPorcentagemDesconto;
        private Label label2;
        private Label lblTotalGeral;
        private Label label4;
        private GroupBox groupBox3;
        private Label lblQuantidadeItens;
        private Label label3;
        private Label lblTotalComDescontoProdutos;
        private Label label14;
        private Label lblValorDescontoProdutos;
        private Label label12;
        private Label lblPorcentagemDescontoProdutos;
        private Label label10;
        private Label lblTotalGeralProdutos;
        private Label label8;
        private GroupBox groupBoxTotaisClassificacoes;
    }
}