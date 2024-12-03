namespace controle_vendas_comissoes.View.Forms.Modais
{
    partial class BuscaPessoas
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
            boxTextoPesquisa = new MaterialSkin.Controls.MaterialTextBox();
            dataGridPessoas = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(boxTextoPesquisa);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 74);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // boxTextoPesquisa
            // 
            boxTextoPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxTextoPesquisa.AnimateReadOnly = false;
            boxTextoPesquisa.BorderStyle = BorderStyle.None;
            boxTextoPesquisa.Depth = 0;
            boxTextoPesquisa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxTextoPesquisa.Hint = "Texto Pesquisa";
            boxTextoPesquisa.LeadingIcon = null;
            boxTextoPesquisa.Location = new Point(7, 18);
            boxTextoPesquisa.Margin = new Padding(2);
            boxTextoPesquisa.MaxLength = 50;
            boxTextoPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            boxTextoPesquisa.Multiline = false;
            boxTextoPesquisa.Name = "boxTextoPesquisa";
            boxTextoPesquisa.Size = new Size(770, 50);
            boxTextoPesquisa.TabIndex = 10;
            boxTextoPesquisa.Text = "";
            boxTextoPesquisa.TrailingIcon = null;
            // 
            // dataGridPessoas
            // 
            dataGridPessoas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPessoas.Location = new Point(0, 81);
            dataGridPessoas.Name = "dataGridPessoas";
            dataGridPessoas.Size = new Size(800, 369);
            dataGridPessoas.TabIndex = 5;
            dataGridPessoas.CellDoubleClick += DataGridPessoas_CellDoubleClick;
            // 
            // BuscaPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridPessoas);
            Controls.Add(groupBox1);
            MinimumSize = new Size(816, 489);
            Name = "BuscaPessoas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca Pessoas";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxTextoPesquisa;
        private DataGridView dataGridPessoas;
    }
}