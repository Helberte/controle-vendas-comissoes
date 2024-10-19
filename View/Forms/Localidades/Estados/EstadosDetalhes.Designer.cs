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
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            btCancelar = new MaterialSkin.Controls.MaterialButton();
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
            btSalvar.Location = new Point(703, 5);
            btSalvar.Margin = new Padding(4, 6, 4, 6);
            btSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btSalvar.Name = "btSalvar";
            btSalvar.NoAccentTextColor = Color.Empty;
            btSalvar.Size = new Size(138, 48);
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
            btSalvarMais.Location = new Point(557, 5);
            btSalvarMais.Margin = new Padding(4, 6, 4, 6);
            btSalvarMais.MouseState = MaterialSkin.MouseState.HOVER;
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.NoAccentTextColor = Color.Empty;
            btSalvarMais.Size = new Size(138, 48);
            btSalvarMais.TabIndex = 8;
            btSalvarMais.Text = "SALVAR +";
            btSalvarMais.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btSalvarMais.UseAccentColor = false;
            btSalvarMais.UseVisualStyleBackColor = true;
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
            maskUF.Location = new Point(399, 6);
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
            maskUF.Size = new Size(152, 48);
            maskUF.SkipLiterals = true;
            maskUF.TabIndex = 7;
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
            boxNomeEstado.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNomeEstado.Hint = "Nome do Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(5, 5);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(387, 50);
            boxNomeEstado.TabIndex = 6;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
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
            btCancelar.Location = new Point(703, 62);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(138, 48);
            btCancelar.TabIndex = 10;
            btCancelar.Text = "CANCELAR";
            btCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancelar.UseAccentColor = false;
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // EstadosDetalhes
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 148);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(btSalvarMais);
            Controls.Add(maskUF);
            Controls.Add(boxNomeEstado);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(862, 187);
            MinimumSize = new Size(862, 187);
            Name = "EstadosDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhe do Estado";
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btSalvar;
        private MaterialSkin.Controls.MaterialButton btSalvarMais;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private MaterialSkin.Controls.MaterialButton btCancelar;
    }
}