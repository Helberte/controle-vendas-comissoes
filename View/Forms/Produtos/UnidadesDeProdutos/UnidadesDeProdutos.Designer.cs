namespace controle_vendas_comissoes.View.Forms.Produtos.UnidadesDeProdutos
{
    partial class UnidadesDeProdutos
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
            boxInformacoesUnidades = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            btInserirNovo = new FontAwesome.Sharp.IconButton();
            dataGridUnidades = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(boxInformacoesUnidades);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 76);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxInformacoesUnidades
            // 
            boxInformacoesUnidades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxInformacoesUnidades.AnimateReadOnly = false;
            boxInformacoesUnidades.BorderStyle = BorderStyle.None;
            boxInformacoesUnidades.Depth = 0;
            boxInformacoesUnidades.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxInformacoesUnidades.Hint = "Informações das Unidades";
            boxInformacoesUnidades.LeadingIcon = null;
            boxInformacoesUnidades.Location = new Point(5, 19);
            boxInformacoesUnidades.Margin = new Padding(2);
            boxInformacoesUnidades.MaxLength = 50;
            boxInformacoesUnidades.MouseState = MaterialSkin.MouseState.OUT;
            boxInformacoesUnidades.Multiline = false;
            boxInformacoesUnidades.Name = "boxInformacoesUnidades";
            boxInformacoesUnidades.Size = new Size(371, 50);
            boxInformacoesUnidades.TabIndex = 9;
            boxInformacoesUnidades.Text = "";
            boxInformacoesUnidades.TrailingIcon = null;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btInserirNovo);
            groupBox2.Location = new Point(392, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 76);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ação";
            // 
            // btInserirNovo
            // 
            btInserirNovo.BackColor = Color.FromArgb(199, 199, 199);
            btInserirNovo.FlatAppearance.BorderSize = 0;
            btInserirNovo.FlatStyle = FlatStyle.Flat;
            btInserirNovo.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserirNovo.ForeColor = Color.White;
            btInserirNovo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btInserirNovo.IconColor = Color.White;
            btInserirNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btInserirNovo.IconSize = 35;
            btInserirNovo.Location = new Point(6, 18);
            btInserirNovo.Name = "btInserirNovo";
            btInserirNovo.Size = new Size(123, 50);
            btInserirNovo.TabIndex = 11;
            btInserirNovo.Text = "ADICIONAR";
            btInserirNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btInserirNovo.UseVisualStyleBackColor = false;
            // 
            // dataGridUnidades
            // 
            dataGridUnidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUnidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUnidades.Location = new Point(0, 90);
            dataGridUnidades.Name = "dataGridUnidades";
            dataGridUnidades.Size = new Size(537, 252);
            dataGridUnidades.TabIndex = 5;
            // 
            // UnidadesDeProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 342);
            Controls.Add(dataGridUnidades);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(553, 381);
            MinimumSize = new Size(553, 381);
            Name = "UnidadesDeProdutos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unidades De Produtos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxInformacoesUnidades;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btInserirNovo;
        private DataGridView dataGridUnidades;
    }
}