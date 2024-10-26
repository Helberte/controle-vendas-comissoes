namespace controle_vendas_comissoes.View.Forms.Localidades.Estados
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
            dataGridEstados = new DataGridView();
            groupBox1 = new GroupBox();
            maskUF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            groupBox2 = new GroupBox();
            btInserirNovo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridEstados
            // 
            dataGridEstados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEstados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstados.Location = new Point(0, 92);
            dataGridEstados.Name = "dataGridEstados";
            dataGridEstados.Size = new Size(870, 294);
            dataGridEstados.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(maskUF);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Location = new Point(6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 79);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // maskUF
            // 
            maskUF.AllowPromptAsInput = true;
            maskUF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            maskUF.Location = new Point(532, 21);
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
            maskUF.TabIndex = 6;
            maskUF.TabStop = false;
            maskUF.TextAlign = HorizontalAlignment.Left;
            maskUF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskUF.TrailingIcon = null;
            maskUF.UseSystemPasswordChar = false;
            maskUF.ValidatingType = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Nome do Estado";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(6, 20);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(519, 50);
            boxNomeEstado.TabIndex = 5;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btInserirNovo);
            groupBox2.Location = new Point(728, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(136, 79);
            groupBox2.TabIndex = 14;
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
            btInserirNovo.Location = new Point(6, 19);
            btInserirNovo.Name = "btInserirNovo";
            btInserirNovo.Size = new Size(123, 50);
            btInserirNovo.TabIndex = 13;
            btInserirNovo.Text = "ADICIONAR";
            btInserirNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btInserirNovo.UseVisualStyleBackColor = false;
            // 
            // EstadosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 386);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridEstados);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            MinimumSize = new Size(886, 425);
            Name = "EstadosLista";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estados";
            ((System.ComponentModel.ISupportInitialize)dataGridEstados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridEstados;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskUF;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btInserirNovo;
    }
}