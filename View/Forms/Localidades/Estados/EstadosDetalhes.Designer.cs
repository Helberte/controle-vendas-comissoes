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
            btSalvar = new MaterialSkin.Controls.MaterialButton();
            btSalvarMais = new MaterialSkin.Controls.MaterialButton();
            btCancelar = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btSalvar
            // 
            btSalvar.AutoSize = false;
            btSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btSalvar.Depth = 0;
            btSalvar.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSalvar.HighEmphasis = true;
            btSalvar.Icon = null;
            btSalvar.Location = new Point(360, 120);
            btSalvar.Margin = new Padding(3, 4, 3, 4);
            btSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btSalvar.Name = "btSalvar";
            btSalvar.NoAccentTextColor = Color.Empty;
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "SALVAR";
            btSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btSalvar.UseAccentColor = false;
            btSalvar.UseVisualStyleBackColor = true;
            // 
            // btSalvarMais
            // 
            btSalvarMais.AutoSize = false;
            btSalvarMais.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSalvarMais.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btSalvarMais.Depth = 0;
            btSalvarMais.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSalvarMais.HighEmphasis = true;
            btSalvarMais.Icon = null;
            btSalvarMais.Location = new Point(257, 120);
            btSalvarMais.Margin = new Padding(3, 4, 3, 4);
            btSalvarMais.MouseState = MaterialSkin.MouseState.HOVER;
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.NoAccentTextColor = Color.Empty;
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 8;
            btSalvarMais.Text = "SALVAR +";
            btSalvarMais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btSalvarMais.UseAccentColor = false;
            btSalvarMais.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.AutoSize = false;
            btCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancelar.Depth = 0;
            btCancelar.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCancelar.HighEmphasis = true;
            btCancelar.Icon = null;
            btCancelar.Location = new Point(463, 120);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 10;
            btCancelar.Text = "CANCELAR";
            btCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancelar.UseAccentColor = false;
            btCancelar.UseVisualStyleBackColor = true;
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
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            // EstadosDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 163);
            Controls.Add(groupBox1);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
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
        private MaterialSkin.Controls.MaterialButton btSalvar;
        private MaterialSkin.Controls.MaterialButton btSalvarMais;
        private MaterialSkin.Controls.MaterialButton btCancelar;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
    }
}