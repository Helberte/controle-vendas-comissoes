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
            dataGridEstados = new DataGridView();
            label3 = new Label();
            dataGridComissoes = new DataGridView();
            label4 = new Label();
            groupBox2 = new GroupBox();
            lblIdProduto = new Label();
            lblDescricaoProduto = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissoes).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(boxInformacoesProduto);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 79);
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
            boxInformacoesProduto.Size = new Size(534, 50);
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
            dataGridProdutos.Size = new Size(546, 689);
            dataGridProdutos.TabIndex = 1;
            dataGridProdutos.SelectionChanged += DataGridProdutos_SelectionChanged;
            // 
            // dataGridEstados
            // 
            dataGridEstados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstados.Location = new Point(558, 92);
            dataGridEstados.Name = "dataGridEstados";
            dataGridEstados.Size = new Size(476, 354);
            dataGridEstados.TabIndex = 4;
            dataGridEstados.SelectionChanged += DataGridEstados_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 72);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 5;
            label3.Text = "Estados desta configuração de comissão";
            // 
            // dataGridComissoes
            // 
            dataGridComissoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridComissoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComissoes.Location = new Point(558, 467);
            dataGridComissoes.Name = "dataGridComissoes";
            dataGridComissoes.Size = new Size(476, 297);
            dataGridComissoes.TabIndex = 15;
            dataGridComissoes.EditingControlShowing += DataGridComissoes_EditingControlShowing;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 449);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 16;
            label4.Text = "Classificações e suas comissões";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblIdProduto);
            groupBox2.Controls.Add(lblDescricaoProduto);
            groupBox2.Location = new Point(558, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 63);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto que será alterado";
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Font = new Font("Montserrat SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdProduto.Location = new Point(5, 16);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(43, 37);
            lblIdProduto.TabIndex = 5;
            lblIdProduto.Text = "15";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoProduto.Location = new Point(49, 23);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(230, 26);
            lblDescricaoProduto.TabIndex = 4;
            lblDescricaoProduto.Text = "OLEO DE COCO 20 ML";
            // 
            // ComissoesConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 787);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(dataGridComissoes);
            Controls.Add(label3);
            Controls.Add(dataGridEstados);
            Controls.Add(dataGridProdutos);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(1250, 826);
            MinimumSize = new Size(1057, 826);
            Name = "ComissoesConfiguracao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comissões Configuração";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridComissoes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxInformacoesProduto;
        private DataGridView dataGridProdutos;
        private DataGridView dataGridEstados;
        private Label label3;
        private DataGridView dataGridComissoes;
        private Label label4;
        private GroupBox groupBox2;
        private Label lblIdProduto;
        private Label lblDescricaoProduto;
    }
}