namespace controle_vendas_comissoes.View.Forms.Localidades.Cidades
{
    partial class CidadesDetalhes
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
            boxSigla = new MaterialSkin.Controls.MaterialTextBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
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
            groupBox1.Size = new Size(580, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações da Cidade";
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
            boxNomeCidade.Size = new Size(441, 50);
            boxNomeCidade.TabIndex = 9;
            boxNomeCidade.Text = "";
            boxNomeCidade.TrailingIcon = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(5, 73);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(514, 50);
            boxNomeEstado.TabIndex = 10;
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
            btBuscaEstado.Location = new Point(524, 72);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(50, 50);
            btBuscaEstado.TabIndex = 11;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
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
            boxSigla.Location = new Point(451, 19);
            boxSigla.Margin = new Padding(2);
            boxSigla.MaxLength = 50;
            boxSigla.MouseState = MaterialSkin.MouseState.OUT;
            boxSigla.Multiline = false;
            boxSigla.Name = "boxSigla";
            boxSigla.Size = new Size(123, 50);
            boxSigla.TabIndex = 12;
            boxSigla.Text = "";
            boxSigla.TrailingIcon = null;
            // 
            // btCancelar
            // 
            btCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btCancelar.IconColor = Color.White;
            btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btCancelar.IconSize = 17;
            btCancelar.Location = new Point(489, 158);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 19;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSalvar.BackColor = Color.FromArgb(199, 199, 199);
            btSalvar.FlatAppearance.BorderSize = 0;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold);
            btSalvar.ForeColor = Color.White;
            btSalvar.IconChar = FontAwesome.Sharp.IconChar.None;
            btSalvar.IconColor = Color.Black;
            btSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvar.Location = new Point(386, 158);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 18;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = false;
            // 
            // btSalvarMais
            // 
            btSalvarMais.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btSalvarMais.BackColor = Color.FromArgb(199, 199, 199);
            btSalvarMais.FlatAppearance.BorderSize = 0;
            btSalvarMais.FlatStyle = FlatStyle.Flat;
            btSalvarMais.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvarMais.ForeColor = Color.White;
            btSalvarMais.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btSalvarMais.IconColor = Color.White;
            btSalvarMais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvarMais.IconSize = 15;
            btSalvarMais.Location = new Point(283, 158);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 17;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // CidadesDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 202);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(823, 261);
            MinimumSize = new Size(609, 241);
            Name = "CidadesDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes da Cidade";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeCidade;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private MaterialSkin.Controls.MaterialTextBox boxSigla;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
    }
}