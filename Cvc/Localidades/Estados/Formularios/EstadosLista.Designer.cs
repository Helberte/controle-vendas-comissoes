namespace controle_vendas_comissoes.Cvc.Localidades.Estados.Formularios
{
    partial class EstadosLista
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
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            dataGridEstados = new DataGridView();
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btInserirNovo = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).BeginInit();
            SuspendLayout();
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Nome do Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(6, 71);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(387, 50);
            boxNomeEstado.TabIndex = 1;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
            // 
            // dataGridEstados
            // 
            dataGridEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstados.Dock = DockStyle.Bottom;
            dataGridEstados.Location = new Point(3, 129);
            dataGridEstados.Name = "dataGridEstados";
            dataGridEstados.Size = new Size(797, 381);
            dataGridEstados.TabIndex = 3;
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
            maskUF.Location = new Point(400, 72);
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
            maskUF.Size = new Size(177, 48);
            maskUF.SkipLiterals = true;
            maskUF.TabIndex = 2;
            maskUF.TabStop = false;
            maskUF.TextAlign = HorizontalAlignment.Left;
            maskUF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.TrailingIcon = null;
            maskUF.UseSystemPasswordChar = false;
            maskUF.ValidatingType = null;
            // 
            // btInserirNovo
            // 
            btInserirNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btInserirNovo.AutoSize = false;
            btInserirNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btInserirNovo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btInserirNovo.Depth = 0;
            btInserirNovo.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btInserirNovo.HighEmphasis = true;
            btInserirNovo.Icon = null;
            btInserirNovo.Location = new Point(584, 72);
            btInserirNovo.Margin = new Padding(4, 6, 4, 6);
            btInserirNovo.MouseState = MaterialSkin.MouseState.HOVER;
            btInserirNovo.Name = "btInserirNovo";
            btInserirNovo.NoAccentTextColor = Color.Empty;
            btInserirNovo.Size = new Size(212, 48);
            btInserirNovo.TabIndex = 3;
            btInserirNovo.Text = "Inserir novo";
            btInserirNovo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btInserirNovo.UseAccentColor = false;
            btInserirNovo.UseVisualStyleBackColor = true;
            // 
            // EstadosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 513);
            Controls.Add(btInserirNovo);
            Controls.Add(maskUF);
            Controls.Add(dataGridEstados);
            Controls.Add(boxNomeEstado);
            KeyPreview = true;
            Name = "EstadosLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estados";
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private DataGridView dataGridEstados;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private MaterialSkin.Controls.MaterialButton btInserirNovo;
    }
}