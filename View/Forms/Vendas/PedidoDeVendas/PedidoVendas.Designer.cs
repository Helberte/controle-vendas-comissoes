namespace controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas
{
    partial class PedidoVendas
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
            label1 = new Label();
            lblPedidoId = new Label();
            label3 = new Label();
            dateTimeDataPedido = new DateTimePicker();
            lblStatus = new Label();
            groupBox1 = new GroupBox();
            boxIdPessoa02 = new MaterialSkin.Controls.MaterialTextBox();
            boxIdPessoa01 = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaPessoa02 = new FontAwesome.Sharp.IconButton();
            btBuscaPessoa01 = new FontAwesome.Sharp.IconButton();
            boxPessoa02 = new MaterialSkin.Controls.MaterialTextBox();
            boxPessoa01 = new MaterialSkin.Controls.MaterialTextBox();
            lblClassificacao02 = new Label();
            lblClassificacao01 = new Label();
            dataGridProdutos = new DataGridView();
            label7 = new Label();
            lblQtdItens = new Label();
            label9 = new Label();
            lblQtdProdutos = new Label();
            label11 = new Label();
            lblTotalGeral = new Label();
            label13 = new Label();
            lblPorcentagemDesconto = new Label();
            label15 = new Label();
            lblValorDesconto = new Label();
            btAdicionaProduto = new FontAwesome.Sharp.IconButton();
            label17 = new Label();
            comboClassificacoEndereco = new MaterialSkin.Controls.MaterialComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 0;
            label1.Text = "ID Pedido";
            // 
            // lblPedidoId
            // 
            lblPedidoId.BackColor = Color.LightGray;
            lblPedidoId.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidoId.ImageAlign = ContentAlignment.MiddleLeft;
            lblPedidoId.Location = new Point(12, 38);
            lblPedidoId.Name = "lblPedidoId";
            lblPedidoId.Size = new Size(73, 29);
            lblPedidoId.TabIndex = 1;
            lblPedidoId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 18);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 2;
            label3.Text = "Data Pedido";
            // 
            // dateTimeDataPedido
            // 
            dateTimeDataPedido.Format = DateTimePickerFormat.Short;
            dateTimeDataPedido.Location = new Point(129, 38);
            dateTimeDataPedido.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimeDataPedido.Name = "dateTimeDataPedido";
            dateTimeDataPedido.Size = new Size(115, 21);
            dateTimeDataPedido.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.FromArgb(164, 190, 240);
            lblStatus.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Transparent;
            lblStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatus.Location = new Point(746, 18);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(234, 49);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "PENDENTE";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(boxIdPessoa02);
            groupBox1.Controls.Add(boxIdPessoa01);
            groupBox1.Controls.Add(btBuscaPessoa02);
            groupBox1.Controls.Add(btBuscaPessoa01);
            groupBox1.Controls.Add(boxPessoa02);
            groupBox1.Controls.Add(boxPessoa01);
            groupBox1.Controls.Add(lblClassificacao02);
            groupBox1.Controls.Add(lblClassificacao01);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 129);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Responsáveis pela Venda";
            // 
            // boxIdPessoa02
            // 
            boxIdPessoa02.AnimateReadOnly = false;
            boxIdPessoa02.BorderStyle = BorderStyle.None;
            boxIdPessoa02.Depth = 0;
            boxIdPessoa02.Enabled = false;
            boxIdPessoa02.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxIdPessoa02.Hint = "ID";
            boxIdPessoa02.LeadingIcon = null;
            boxIdPessoa02.Location = new Point(203, 72);
            boxIdPessoa02.MaxLength = 50;
            boxIdPessoa02.MouseState = MaterialSkin.MouseState.OUT;
            boxIdPessoa02.Multiline = false;
            boxIdPessoa02.Name = "boxIdPessoa02";
            boxIdPessoa02.Size = new Size(62, 50);
            boxIdPessoa02.TabIndex = 16;
            boxIdPessoa02.Text = "";
            boxIdPessoa02.TrailingIcon = null;
            // 
            // boxIdPessoa01
            // 
            boxIdPessoa01.AnimateReadOnly = false;
            boxIdPessoa01.BorderStyle = BorderStyle.None;
            boxIdPessoa01.Depth = 0;
            boxIdPessoa01.Enabled = false;
            boxIdPessoa01.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxIdPessoa01.Hint = "ID";
            boxIdPessoa01.LeadingIcon = null;
            boxIdPessoa01.Location = new Point(203, 17);
            boxIdPessoa01.MaxLength = 50;
            boxIdPessoa01.MouseState = MaterialSkin.MouseState.OUT;
            boxIdPessoa01.Multiline = false;
            boxIdPessoa01.Name = "boxIdPessoa01";
            boxIdPessoa01.Size = new Size(62, 50);
            boxIdPessoa01.TabIndex = 15;
            boxIdPessoa01.Text = "";
            boxIdPessoa01.TrailingIcon = null;
            // 
            // btBuscaPessoa02
            // 
            btBuscaPessoa02.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaPessoa02.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaPessoa02.FlatAppearance.BorderSize = 0;
            btBuscaPessoa02.FlatStyle = FlatStyle.Flat;
            btBuscaPessoa02.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaPessoa02.IconColor = Color.White;
            btBuscaPessoa02.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaPessoa02.IconSize = 35;
            btBuscaPessoa02.Location = new Point(911, 71);
            btBuscaPessoa02.Name = "btBuscaPessoa02";
            btBuscaPessoa02.Size = new Size(50, 50);
            btBuscaPessoa02.TabIndex = 14;
            btBuscaPessoa02.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaPessoa02.UseVisualStyleBackColor = false;
            btBuscaPessoa02.Click += BtBuscaPessoa02_Click;
            // 
            // btBuscaPessoa01
            // 
            btBuscaPessoa01.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaPessoa01.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaPessoa01.FlatAppearance.BorderSize = 0;
            btBuscaPessoa01.FlatStyle = FlatStyle.Flat;
            btBuscaPessoa01.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaPessoa01.IconColor = Color.White;
            btBuscaPessoa01.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaPessoa01.IconSize = 35;
            btBuscaPessoa01.Location = new Point(911, 16);
            btBuscaPessoa01.Name = "btBuscaPessoa01";
            btBuscaPessoa01.Size = new Size(50, 50);
            btBuscaPessoa01.TabIndex = 13;
            btBuscaPessoa01.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaPessoa01.UseVisualStyleBackColor = false;
            btBuscaPessoa01.Click += BtBuscaPessoa01_Click;
            // 
            // boxPessoa02
            // 
            boxPessoa02.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPessoa02.AnimateReadOnly = false;
            boxPessoa02.BorderStyle = BorderStyle.None;
            boxPessoa02.Depth = 0;
            boxPessoa02.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxPessoa02.Hint = "Escolha uma pessoa";
            boxPessoa02.LeadingIcon = null;
            boxPessoa02.Location = new Point(271, 72);
            boxPessoa02.MaxLength = 50;
            boxPessoa02.MouseState = MaterialSkin.MouseState.OUT;
            boxPessoa02.Multiline = false;
            boxPessoa02.Name = "boxPessoa02";
            boxPessoa02.Size = new Size(634, 50);
            boxPessoa02.TabIndex = 5;
            boxPessoa02.Text = "";
            boxPessoa02.TrailingIcon = null;
            // 
            // boxPessoa01
            // 
            boxPessoa01.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxPessoa01.AnimateReadOnly = false;
            boxPessoa01.BorderStyle = BorderStyle.None;
            boxPessoa01.Depth = 0;
            boxPessoa01.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxPessoa01.Hint = "Escolha uma pessoa";
            boxPessoa01.LeadingIcon = null;
            boxPessoa01.Location = new Point(271, 17);
            boxPessoa01.MaxLength = 50;
            boxPessoa01.MouseState = MaterialSkin.MouseState.OUT;
            boxPessoa01.Multiline = false;
            boxPessoa01.Name = "boxPessoa01";
            boxPessoa01.Size = new Size(634, 50);
            boxPessoa01.TabIndex = 4;
            boxPessoa01.Text = "";
            boxPessoa01.TrailingIcon = null;
            // 
            // lblClassificacao02
            // 
            lblClassificacao02.BackColor = Color.Silver;
            lblClassificacao02.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassificacao02.ForeColor = Color.Transparent;
            lblClassificacao02.ImageAlign = ContentAlignment.MiddleLeft;
            lblClassificacao02.Location = new Point(10, 73);
            lblClassificacao02.Name = "lblClassificacao02";
            lblClassificacao02.Size = new Size(187, 42);
            lblClassificacao02.TabIndex = 3;
            lblClassificacao02.Text = "CLASSIFICAÇÃO";
            lblClassificacao02.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClassificacao01
            // 
            lblClassificacao01.BackColor = Color.Silver;
            lblClassificacao01.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassificacao01.ForeColor = Color.Transparent;
            lblClassificacao01.ImageAlign = ContentAlignment.MiddleLeft;
            lblClassificacao01.Location = new Point(10, 20);
            lblClassificacao01.Name = "lblClassificacao01";
            lblClassificacao01.Size = new Size(187, 42);
            lblClassificacao01.TabIndex = 2;
            lblClassificacao01.Text = "CLASSIFICAÇÃO";
            lblClassificacao01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(0, 260);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(991, 241);
            dataGridProdutos.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 520);
            label7.Name = "label7";
            label7.Size = new Size(145, 18);
            label7.TabIndex = 7;
            label7.Text = "Quantidade de Itens:";
            // 
            // lblQtdItens
            // 
            lblQtdItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQtdItens.AutoSize = true;
            lblQtdItens.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtdItens.Location = new Point(151, 518);
            lblQtdItens.Name = "lblQtdItens";
            lblQtdItens.Size = new Size(25, 22);
            lblQtdItens.TabIndex = 8;
            lblQtdItens.Text = "15";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(215, 520);
            label9.Name = "label9";
            label9.Size = new Size(172, 18);
            label9.TabIndex = 9;
            label9.Text = "Quantidade de Produtos:";
            // 
            // lblQtdProdutos
            // 
            lblQtdProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblQtdProdutos.AutoSize = true;
            lblQtdProdutos.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtdProdutos.Location = new Point(384, 518);
            lblQtdProdutos.Name = "lblQtdProdutos";
            lblQtdProdutos.Size = new Size(25, 22);
            lblQtdProdutos.TabIndex = 10;
            lblQtdProdutos.Text = "15";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(450, 520);
            label11.Name = "label11";
            label11.Size = new Size(97, 18);
            label11.TabIndex = 11;
            label11.Text = "Total Geral R$:";
            // 
            // lblTotalGeral
            // 
            lblTotalGeral.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalGeral.AutoSize = true;
            lblTotalGeral.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGeral.Location = new Point(543, 518);
            lblTotalGeral.Name = "lblTotalGeral";
            lblTotalGeral.Size = new Size(25, 22);
            lblTotalGeral.TabIndex = 12;
            lblTotalGeral.Text = "15";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(606, 520);
            label13.Name = "label13";
            label13.Size = new Size(180, 18);
            label13.TabIndex = 13;
            label13.Text = "Porcentagem Desconto %:";
            // 
            // lblPorcentagemDesconto
            // 
            lblPorcentagemDesconto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPorcentagemDesconto.AutoSize = true;
            lblPorcentagemDesconto.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorcentagemDesconto.Location = new Point(782, 518);
            lblPorcentagemDesconto.Name = "lblPorcentagemDesconto";
            lblPorcentagemDesconto.Size = new Size(25, 22);
            lblPorcentagemDesconto.TabIndex = 14;
            lblPorcentagemDesconto.Text = "15";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(835, 520);
            label15.Name = "label15";
            label15.Size = new Size(128, 18);
            label15.TabIndex = 15;
            label15.Text = "Valor Desconto R$:";
            // 
            // lblValorDesconto
            // 
            lblValorDesconto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblValorDesconto.AutoSize = true;
            lblValorDesconto.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorDesconto.Location = new Point(958, 518);
            lblValorDesconto.Name = "lblValorDesconto";
            lblValorDesconto.Size = new Size(25, 22);
            lblValorDesconto.TabIndex = 16;
            lblValorDesconto.Text = "15";
            // 
            // btAdicionaProduto
            // 
            btAdicionaProduto.BackColor = Color.FromArgb(199, 199, 199);
            btAdicionaProduto.FlatAppearance.BorderSize = 0;
            btAdicionaProduto.FlatStyle = FlatStyle.Flat;
            btAdicionaProduto.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            btAdicionaProduto.ForeColor = Color.DimGray;
            btAdicionaProduto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btAdicionaProduto.IconColor = Color.White;
            btAdicionaProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btAdicionaProduto.IconSize = 20;
            btAdicionaProduto.Location = new Point(12, 214);
            btAdicionaProduto.Name = "btAdicionaProduto";
            btAdicionaProduto.Size = new Size(279, 40);
            btAdicionaProduto.TabIndex = 17;
            btAdicionaProduto.Text = "Adicionar Produto";
            btAdicionaProduto.TextAlign = ContentAlignment.MiddleRight;
            btAdicionaProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAdicionaProduto.UseVisualStyleBackColor = false;
            btAdicionaProduto.Click += BtAdicionaProduto_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(302, 225);
            label17.Name = "label17";
            label17.Size = new Size(132, 18);
            label17.TabIndex = 18;
            label17.Text = "Produtos da Venda";
            // 
            // comboClassificacoEndereco
            // 
            comboClassificacoEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboClassificacoEndereco.AutoResize = false;
            comboClassificacoEndereco.BackColor = Color.FromArgb(255, 255, 255);
            comboClassificacoEndereco.Depth = 0;
            comboClassificacoEndereco.DrawMode = DrawMode.OwnerDrawVariable;
            comboClassificacoEndereco.DropDownHeight = 174;
            comboClassificacoEndereco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassificacoEndereco.DropDownWidth = 121;
            comboClassificacoEndereco.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboClassificacoEndereco.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboClassificacoEndereco.FormattingEnabled = true;
            comboClassificacoEndereco.Hint = "Endereço que será considerado";
            comboClassificacoEndereco.IntegralHeight = false;
            comboClassificacoEndereco.ItemHeight = 43;
            comboClassificacoEndereco.Location = new Point(606, 209);
            comboClassificacoEndereco.MaxDropDownItems = 4;
            comboClassificacoEndereco.MouseState = MaterialSkin.MouseState.OUT;
            comboClassificacoEndereco.Name = "comboClassificacoEndereco";
            comboClassificacoEndereco.Size = new Size(374, 49);
            comboClassificacoEndereco.StartIndex = 0;
            comboClassificacoEndereco.TabIndex = 19;
            // 
            // PedidoVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 553);
            Controls.Add(comboClassificacoEndereco);
            Controls.Add(label17);
            Controls.Add(btAdicionaProduto);
            Controls.Add(lblValorDesconto);
            Controls.Add(label15);
            Controls.Add(lblPorcentagemDesconto);
            Controls.Add(label13);
            Controls.Add(lblTotalGeral);
            Controls.Add(label11);
            Controls.Add(lblQtdProdutos);
            Controls.Add(label9);
            Controls.Add(lblQtdItens);
            Controls.Add(label7);
            Controls.Add(dataGridProdutos);
            Controls.Add(groupBox1);
            Controls.Add(lblStatus);
            Controls.Add(dateTimeDataPedido);
            Controls.Add(label3);
            Controls.Add(lblPedidoId);
            Controls.Add(label1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1007, 592);
            Name = "PedidoVendas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedido de Vendas";
            Load += PedidoVendas_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPedidoId;
        private Label label3;
        private DateTimePicker dateTimeDataPedido;
        private Label lblStatus;
        private GroupBox groupBox1;
        private Label lblClassificacao01;
        private MaterialSkin.Controls.MaterialTextBox boxPessoa02;
        private MaterialSkin.Controls.MaterialTextBox boxPessoa01;
        private Label lblClassificacao02;
        private FontAwesome.Sharp.IconButton btBuscaPessoa02;
        private FontAwesome.Sharp.IconButton btBuscaPessoa01;
        private DataGridView dataGridProdutos;
        private Label label7;
        private Label lblQtdItens;
        private Label label9;
        private Label lblQtdProdutos;
        private Label label11;
        private Label lblTotalGeral;
        private Label label13;
        private Label lblPorcentagemDesconto;
        private Label label15;
        private Label lblValorDesconto;
        private FontAwesome.Sharp.IconButton btAdicionaProduto;
        private Label label17;
        private MaterialSkin.Controls.MaterialTextBox boxIdPessoa01;
        private MaterialSkin.Controls.MaterialTextBox boxIdPessoa02;
        private MaterialSkin.Controls.MaterialComboBox comboClassificacoEndereco;
    }
}