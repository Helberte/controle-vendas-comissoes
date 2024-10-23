namespace controle_vendas_comissoes.View.Forms.Pessoal.Classificacoes
{
    partial class ClassificacoesDetalhes
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
            boxNomeClassificacao = new MaterialSkin.Controls.MaterialTextBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(boxNomeClassificacao);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 91);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da Classificação";
            // 
            // boxNomeClassificacao
            // 
            boxNomeClassificacao.AnimateReadOnly = false;
            boxNomeClassificacao.BorderStyle = BorderStyle.None;
            boxNomeClassificacao.Depth = 0;
            boxNomeClassificacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeClassificacao.Hint = "Nome da Classificação";
            boxNomeClassificacao.LeadingIcon = null;
            boxNomeClassificacao.Location = new Point(6, 22);
            boxNomeClassificacao.Margin = new Padding(2);
            boxNomeClassificacao.MaxLength = 50;
            boxNomeClassificacao.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeClassificacao.Multiline = false;
            boxNomeClassificacao.Name = "boxNomeClassificacao";
            boxNomeClassificacao.Size = new Size(544, 50);
            boxNomeClassificacao.TabIndex = 7;
            boxNomeClassificacao.Text = "";
            boxNomeClassificacao.TrailingIcon = null;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btCancelar.IconColor = Color.White;
            btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btCancelar.IconSize = 17;
            btCancelar.Location = new Point(463, 121);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 20;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.FromArgb(199, 199, 199);
            btSalvar.FlatAppearance.BorderSize = 0;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold);
            btSalvar.ForeColor = Color.White;
            btSalvar.IconChar = FontAwesome.Sharp.IconChar.None;
            btSalvar.IconColor = Color.Black;
            btSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvar.Location = new Point(360, 121);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 19;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = false;
            // 
            // btSalvarMais
            // 
            btSalvarMais.BackColor = Color.FromArgb(199, 199, 199);
            btSalvarMais.FlatAppearance.BorderSize = 0;
            btSalvarMais.FlatStyle = FlatStyle.Flat;
            btSalvarMais.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvarMais.ForeColor = Color.White;
            btSalvarMais.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btSalvarMais.IconColor = Color.White;
            btSalvarMais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvarMais.IconSize = 15;
            btSalvarMais.Location = new Point(257, 121);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 18;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // ClassificacoesDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 162);
            Controls.Add(groupBox1);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
            MaximizeBox = false;
            MaximumSize = new Size(584, 201);
            MinimumSize = new Size(584, 201);
            Name = "ClassificacoesDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes da Classificação";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeClassificacao;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
    }
}