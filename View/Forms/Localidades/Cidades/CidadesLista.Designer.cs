namespace controle_vendas_comissoes.View.Forms.Localidades.Cidades
{
    partial class CidadesLista
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
            boxSigla = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            boxNomeCidade = new MaterialSkin.Controls.MaterialTextBox();
            dataGridCidades = new DataGridView();
            groupBox2 = new GroupBox();
            btInserirNovo = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidades).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(boxSigla);
            groupBox1.Controls.Add(btBuscaEstado);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Controls.Add(boxNomeCidade);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxSigla
            // 
            boxSigla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxSigla.AnimateReadOnly = false;
            boxSigla.BorderStyle = BorderStyle.None;
            boxSigla.Depth = 0;
            boxSigla.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxSigla.Hint = "Sigla";
            boxSigla.LeadingIcon = null;
            boxSigla.Location = new Point(586, 19);
            boxSigla.Margin = new Padding(2);
            boxSigla.MaxLength = 50;
            boxSigla.MouseState = MaterialSkin.MouseState.OUT;
            boxSigla.Multiline = false;
            boxSigla.Name = "boxSigla";
            boxSigla.Size = new Size(119, 50);
            boxSigla.TabIndex = 11;
            boxSigla.Text = "";
            boxSigla.TrailingIcon = null;
            // 
            // btBuscaEstado
            // 
            btBuscaEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaEstado.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaEstado.FlatAppearance.BorderSize = 0;
            btBuscaEstado.FlatStyle = FlatStyle.Flat;
            btBuscaEstado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaEstado.IconColor = Color.White;
            btBuscaEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaEstado.IconSize = 35;
            btBuscaEstado.Location = new Point(531, 18);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(50, 50);
            btBuscaEstado.TabIndex = 10;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(287, 19);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(239, 50);
            boxNomeEstado.TabIndex = 9;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
            // 
            // boxNomeCidade
            // 
            boxNomeCidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomeCidade.AnimateReadOnly = false;
            boxNomeCidade.BorderStyle = BorderStyle.None;
            boxNomeCidade.Depth = 0;
            boxNomeCidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeCidade.Hint = "Cidade";
            boxNomeCidade.LeadingIcon = null;
            boxNomeCidade.Location = new Point(5, 19);
            boxNomeCidade.Margin = new Padding(2);
            boxNomeCidade.MaxLength = 50;
            boxNomeCidade.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeCidade.Multiline = false;
            boxNomeCidade.Name = "boxNomeCidade";
            boxNomeCidade.Size = new Size(273, 50);
            boxNomeCidade.TabIndex = 8;
            boxNomeCidade.Text = "";
            boxNomeCidade.TrailingIcon = null;
            // 
            // dataGridCidades
            // 
            dataGridCidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidades.Location = new Point(0, 90);
            dataGridCidades.Name = "dataGridCidades";
            dataGridCidades.Size = new Size(870, 296);
            dataGridCidades.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btInserirNovo);
            groupBox2.Location = new Point(724, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(139, 76);
            groupBox2.TabIndex = 2;
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
            btInserirNovo.Text = "Adicionar";
            btInserirNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btInserirNovo.UseVisualStyleBackColor = false;
            // 
            // CidadesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 386);
            Controls.Add(groupBox2);
            Controls.Add(dataGridCidades);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(886, 425);
            Name = "CidadesLista";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cidades";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCidades).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeCidade;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private MaterialSkin.Controls.MaterialTextBox boxSigla;
        private DataGridView dataGridCidades;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btInserirNovo;
    }
}