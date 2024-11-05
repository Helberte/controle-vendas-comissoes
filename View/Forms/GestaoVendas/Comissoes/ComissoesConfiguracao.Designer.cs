namespace controle_vendas_comissoes.View.Forms.GestaoVendas.Comissoes
{
    partial class ComissoesConfiguracao
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
            boxInformacoesProduto = new MaterialSkin.Controls.MaterialTextBox();
            dataGridProdutos = new DataGridView();
            lblIdProduto = new Label();
            lblDescricaoProduto = new Label();
            dataGridEstados = new DataGridView();
            label3 = new Label();
            dataGridComissoes = new DataGridView();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissoes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(boxInformacoesProduto);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1084, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxInformacoesProduto
            // 
            boxInformacoesProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxInformacoesProduto.AnimateReadOnly = false;
            boxInformacoesProduto.BorderStyle = BorderStyle.None;
            boxInformacoesProduto.Depth = 0;
            boxInformacoesProduto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxInformacoesProduto.Hint = "Informações do produto";
            boxInformacoesProduto.LeadingIcon = null;
            boxInformacoesProduto.Location = new Point(6, 20);
            boxInformacoesProduto.MaxLength = 50;
            boxInformacoesProduto.MouseState = MaterialSkin.MouseState.OUT;
            boxInformacoesProduto.Multiline = false;
            boxInformacoesProduto.Name = "boxInformacoesProduto";
            boxInformacoesProduto.Size = new Size(1072, 50);
            boxInformacoesProduto.TabIndex = 6;
            boxInformacoesProduto.Text = "";
            boxInformacoesProduto.TrailingIcon = null;
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(6, 92);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.Size = new Size(546, 605);
            dataGridProdutos.TabIndex = 1;
            dataGridProdutos.SelectionChanged += DataGridProdutos_SelectionChanged;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProduto.Location = new Point(558, 92);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(43, 37);
            lblIdProduto.TabIndex = 2;
            lblIdProduto.Text = "15";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoProduto.Location = new Point(602, 100);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(230, 26);
            lblDescricaoProduto.TabIndex = 3;
            lblDescricaoProduto.Text = "OLEO DE COCO 20 ML";
            // 
            // dataGridEstados
            // 
            dataGridEstados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstados.Location = new Point(558, 159);
            dataGridEstados.Name = "dataGridEstados";
            dataGridEstados.Size = new Size(532, 383);
            dataGridEstados.TabIndex = 4;
            dataGridEstados.SelectionChanged += dataGridEstados_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 140);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 5;
            label3.Text = "Estados desta configuração de comissão";
            // 
            // dataGridComissoes
            // 
            dataGridComissoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridComissoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComissoes.Location = new Point(558, 563);
            dataGridComissoes.Name = "dataGridComissoes";
            dataGridComissoes.Size = new Size(532, 134);
            dataGridComissoes.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 545);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 16;
            label4.Text = "Classificações e suas comissões";
            // 
            // ComissoesConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 703);
            Controls.Add(label4);
            Controls.Add(dataGridComissoes);
            Controls.Add(label3);
            Controls.Add(dataGridEstados);
            Controls.Add(lblDescricaoProduto);
            Controls.Add(lblIdProduto);
            Controls.Add(dataGridProdutos);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimumSize = new Size(1113, 742);
            Name = "ComissoesConfiguracao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comissões Configuração";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxInformacoesProduto;
        private DataGridView dataGridProdutos;
        private Label lblIdProduto;
        private Label lblDescricaoProduto;
        private DataGridView dataGridEstados;
        private Label label3;
        private DataGridView dataGridComissoes;
        private Label label4;
    }
}