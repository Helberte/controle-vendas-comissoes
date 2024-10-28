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
            boxTextoBusca = new MaterialSkin.Controls.MaterialTextBox();
            boxClassificacao = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaClassificacao = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            btAdicionar = new FontAwesome.Sharp.IconButton();
            dataGridPessoas = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btBuscaClassificacao);
            groupBox1.Controls.Add(boxClassificacao);
            groupBox1.Controls.Add(boxTextoBusca);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
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
            boxTextoBusca.Size = new Size(389, 50);
            boxTextoBusca.TabIndex = 10;
            boxTextoBusca.Text = "";
            boxTextoBusca.TrailingIcon = null;
            // 
            // boxClassificacao
            // 
            boxClassificacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxClassificacao.AnimateReadOnly = false;
            boxClassificacao.BorderStyle = BorderStyle.None;
            boxClassificacao.Depth = 0;
            boxClassificacao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxClassificacao.Hint = "Unidade Primária";
            boxClassificacao.LeadingIcon = null;
            boxClassificacao.Location = new Point(401, 19);
            boxClassificacao.Margin = new Padding(2);
            boxClassificacao.MaxLength = 50;
            boxClassificacao.MouseState = MaterialSkin.MouseState.OUT;
            boxClassificacao.Multiline = false;
            boxClassificacao.Name = "boxClassificacao";
            boxClassificacao.Size = new Size(247, 50);
            boxClassificacao.TabIndex = 11;
            boxClassificacao.Text = "";
            boxClassificacao.TrailingIcon = null;
            // 
            // btBuscaClassificacao
            // 
            btBuscaClassificacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaClassificacao.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaClassificacao.FlatAppearance.BorderSize = 0;
            btBuscaClassificacao.FlatStyle = FlatStyle.Flat;
            btBuscaClassificacao.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaClassificacao.IconColor = Color.White;
            btBuscaClassificacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaClassificacao.IconSize = 35;
            btBuscaClassificacao.Location = new Point(655, 18);
            btBuscaClassificacao.Name = "btBuscaClassificacao";
            btBuscaClassificacao.Size = new Size(50, 50);
            btBuscaClassificacao.TabIndex = 12;
            btBuscaClassificacao.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaClassificacao.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btAdicionar);
            groupBox2.Location = new Point(725, 9);
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
            // dataGridPessoas
            // 
            dataGridPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPessoas.Location = new Point(0, 94);
            dataGridPessoas.Name = "dataGridPessoas";
            dataGridPessoas.Size = new Size(872, 205);
            dataGridPessoas.TabIndex = 5;
            // 
            // ProdutosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 299);
            Controls.Add(dataGridPessoas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProdutosLista";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxTextoBusca;
        private MaterialSkin.Controls.MaterialTextBox boxClassificacao;
        private FontAwesome.Sharp.IconButton btBuscaClassificacao;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btAdicionar;
        private DataGridView dataGridPessoas;
    }
}