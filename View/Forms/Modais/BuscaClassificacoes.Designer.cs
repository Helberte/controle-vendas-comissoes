namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class BuscaClassificacoes
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
            boxClassificacao = new MaterialSkin.Controls.MaterialTextBox();
            dataGridClassificacoes = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClassificacoes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(boxClassificacao);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 74);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxClassificacao
            // 
            boxClassificacao.AnimateReadOnly = false;
            boxClassificacao.BorderStyle = BorderStyle.None;
            boxClassificacao.Depth = 0;
            boxClassificacao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxClassificacao.Hint = "Classificação";
            boxClassificacao.LeadingIcon = null;
            boxClassificacao.Location = new Point(7, 18);
            boxClassificacao.Margin = new Padding(2);
            boxClassificacao.MaxLength = 50;
            boxClassificacao.MouseState = MaterialSkin.MouseState.OUT;
            boxClassificacao.Multiline = false;
            boxClassificacao.Name = "boxClassificacao";
            boxClassificacao.Size = new Size(536, 50);
            boxClassificacao.TabIndex = 10;
            boxClassificacao.Text = "";
            boxClassificacao.TrailingIcon = null;
            // 
            // dataGridClassificacoes
            // 
            dataGridClassificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridClassificacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClassificacoes.Location = new Point(0, 81);
            dataGridClassificacoes.Name = "dataGridClassificacoes";
            dataGridClassificacoes.Size = new Size(563, 303);
            dataGridClassificacoes.TabIndex = 4;
            // 
            // BuscaClassificacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 384);
            Controls.Add(dataGridClassificacoes);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(579, 423);
            MinimumSize = new Size(579, 423);
            Name = "BuscaClassificacoes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Classificações";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClassificacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxClassificacao;
        private DataGridView dataGridClassificacoes;
    }
}