namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class BuscaCidade
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
            boxNomeCidade = new MaterialSkin.Controls.MaterialTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            dataGridCidades = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidades).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btBuscaEstado);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Controls.Add(boxNomeCidade);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 74);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxNomeCidade
            // 
            boxNomeCidade.AnimateReadOnly = false;
            boxNomeCidade.BorderStyle = BorderStyle.None;
            boxNomeCidade.Depth = 0;
            boxNomeCidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeCidade.Hint = "Cidade";
            boxNomeCidade.LeadingIcon = null;
            boxNomeCidade.Location = new Point(7, 18);
            boxNomeCidade.Margin = new Padding(2);
            boxNomeCidade.MaxLength = 50;
            boxNomeCidade.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeCidade.Multiline = false;
            boxNomeCidade.Name = "boxNomeCidade";
            boxNomeCidade.Size = new Size(298, 50);
            boxNomeCidade.TabIndex = 10;
            boxNomeCidade.Text = "";
            boxNomeCidade.TrailingIcon = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(312, 18);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(262, 50);
            boxNomeEstado.TabIndex = 11;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
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
            btBuscaEstado.Location = new Point(581, 18);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(49, 49);
            btBuscaEstado.TabIndex = 13;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
            // 
            // dataGridCidades
            // 
            dataGridCidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidades.Location = new Point(0, 81);
            dataGridCidades.Name = "dataGridCidades";
            dataGridCidades.Size = new Size(651, 303);
            dataGridCidades.TabIndex = 4;
            // 
            // BuscaCidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 384);
            Controls.Add(dataGridCidades);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimumSize = new Size(579, 423);
            Name = "BuscaCidade";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Cidade";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeCidade;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private DataGridView dataGridCidades;
    }
}