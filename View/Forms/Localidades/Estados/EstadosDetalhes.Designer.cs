namespace controle_vendas_comissoes.View.Forms.Localidades.Estados
{
    partial class EstadosDetalhes
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
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btCancelar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskUF);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 91);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Estado";
            // 
            // maskUF
            // 
            maskUF.AllowPromptAsInput = true;
            maskUF.AnimateReadOnly = false;
            maskUF.AsciiOnly = false;
            maskUF.BackgroundImageLayout = ImageLayout.None;
            maskUF.BeepOnError = false;
            maskUF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.Depth = 0;
            maskUF.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskUF.HelperText = "UF";
            maskUF.HidePromptOnLeave = false;
            maskUF.HideSelection = true;
            maskUF.Hint = "UF";
            maskUF.InsertKeyMode = InsertKeyMode.Default;
            maskUF.LeadingIcon = null;
            maskUF.Location = new Point(390, 23);
            maskUF.Margin = new Padding(2);
            maskUF.Mask = "AAAA";
            maskUF.MaxLength = 32767;
            maskUF.MouseState = MaterialSkin.MouseState.OUT;
            maskUF.Name = "maskUF";
            maskUF.PasswordChar = '\0';
            maskUF.PrefixSuffixText = null;
            maskUF.PromptChar = '_';
            maskUF.ReadOnly = false;
            maskUF.RejectInputOnFirstFailure = false;
            maskUF.ResetOnPrompt = true;
            maskUF.ResetOnSpace = true;
            maskUF.RightToLeft = RightToLeft.No;
            maskUF.SelectedText = "";
            maskUF.SelectionLength = 0;
            maskUF.SelectionStart = 0;
            maskUF.ShortcutsEnabled = true;
            maskUF.Size = new Size(156, 48);
            maskUF.SkipLiterals = true;
            maskUF.TabIndex = 8;
            maskUF.TabStop = false;
            maskUF.TextAlign = HorizontalAlignment.Left;
            maskUF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.TrailingIcon = null;
            maskUF.UseSystemPasswordChar = false;
            maskUF.ValidatingType = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Nome do Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(6, 22);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(374, 50);
            boxNomeEstado.TabIndex = 7;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
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
            btSalvarMais.Location = new Point(257, 120);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 14;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
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
            btSalvar.Location = new Point(360, 120);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 15;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = false;
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
            btCancelar.Location = new Point(463, 120);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 16;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // EstadosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 163);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(581, 202);
            MinimumSize = new Size(581, 202);
            Name = "EstadosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhe do Estado";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
        private FontAwesome.Sharp.IconButton btCancelar;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private FontAwesome.Sharp.IconButton btInserirNovo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}