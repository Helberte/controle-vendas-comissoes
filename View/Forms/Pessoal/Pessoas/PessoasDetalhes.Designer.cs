namespace controle_vendas_comissoes.View.Forms.Pessoal.Pessoas
{
    partial class PessoasDetalhes
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
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            boxNomeEstado = new MaterialSkin.Controls.MaterialTextBox();
            groupBox3 = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            materialMaskedTextBox4 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox3 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            groupBox4 = new GroupBox();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btBuscaEstado);
            groupBox1.Controls.Add(materialTextBox3);
            groupBox1.Controls.Add(materialTextBox2);
            groupBox1.Controls.Add(materialMaskedTextBox2);
            groupBox1.Controls.Add(materialMaskedTextBox1);
            groupBox1.Controls.Add(materialTextBox1);
            groupBox1.Controls.Add(boxNomeEstado);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(852, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Pessoais";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(691, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 58);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 22);
            dateTimePicker1.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 21);
            dateTimePicker1.TabIndex = 13;
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
            btBuscaEstado.Location = new Point(637, 80);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(49, 49);
            btBuscaEstado.TabIndex = 15;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Enabled = false;
            materialTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.Hint = "Id";
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(576, 80);
            materialTextBox3.Margin = new Padding(2);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(56, 50);
            materialTextBox3.TabIndex = 14;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Enabled = false;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Classificação";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(292, 80);
            materialTextBox2.Margin = new Padding(2);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(278, 50);
            materialTextBox2.TabIndex = 13;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.Hint = "RG";
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(157, 81);
            materialMaskedTextBox2.Mask = "00000000";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(129, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 11;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "CPF";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(7, 81);
            materialMaskedTextBox1.Mask = "000.000.000-00";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(144, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 10;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "   ,   ,   -";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Sobrenome";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(429, 22);
            materialTextBox1.Margin = new Padding(2);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(416, 50);
            materialTextBox1.TabIndex = 9;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // boxNomeEstado
            // 
            boxNomeEstado.AnimateReadOnly = false;
            boxNomeEstado.BorderStyle = BorderStyle.None;
            boxNomeEstado.Depth = 0;
            boxNomeEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeEstado.Hint = "Nome da Pessoa";
            boxNomeEstado.LeadingIcon = null;
            boxNomeEstado.Location = new Point(6, 22);
            boxNomeEstado.Margin = new Padding(2);
            boxNomeEstado.MaxLength = 50;
            boxNomeEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeEstado.Multiline = false;
            boxNomeEstado.Name = "boxNomeEstado";
            boxNomeEstado.Size = new Size(416, 50);
            boxNomeEstado.TabIndex = 8;
            boxNomeEstado.Text = "";
            boxNomeEstado.TrailingIcon = null;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(iconButton2);
            groupBox3.Controls.Add(materialTextBox7);
            groupBox3.Controls.Add(iconButton1);
            groupBox3.Controls.Add(materialTextBox6);
            groupBox3.Controls.Add(materialMaskedTextBox4);
            groupBox3.Controls.Add(materialMaskedTextBox3);
            groupBox3.Controls.Add(materialTextBox5);
            groupBox3.Controls.Add(materialTextBox4);
            groupBox3.Location = new Point(5, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(852, 133);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Endereço";
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.BackColor = Color.FromArgb(199, 199, 199);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.Location = new Point(796, 74);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(49, 49);
            iconButton2.TabIndex = 18;
            iconButton2.TextImageRelation = TextImageRelation.TextAboveImage;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // materialTextBox7
            // 
            materialTextBox7.AnimateReadOnly = false;
            materialTextBox7.BorderStyle = BorderStyle.None;
            materialTextBox7.Depth = 0;
            materialTextBox7.Enabled = false;
            materialTextBox7.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox7.Hint = "Cidade";
            materialTextBox7.LeadingIcon = null;
            materialTextBox7.Location = new Point(570, 74);
            materialTextBox7.Margin = new Padding(2);
            materialTextBox7.MaxLength = 50;
            materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox7.Multiline = false;
            materialTextBox7.Name = "materialTextBox7";
            materialTextBox7.Size = new Size(220, 50);
            materialTextBox7.TabIndex = 17;
            materialTextBox7.Text = "";
            materialTextBox7.TrailingIcon = null;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.BackColor = Color.FromArgb(199, 199, 199);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(515, 74);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(49, 49);
            iconButton1.TabIndex = 16;
            iconButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // materialTextBox6
            // 
            materialTextBox6.AnimateReadOnly = false;
            materialTextBox6.BorderStyle = BorderStyle.None;
            materialTextBox6.Depth = 0;
            materialTextBox6.Enabled = false;
            materialTextBox6.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox6.Hint = "Estado";
            materialTextBox6.LeadingIcon = null;
            materialTextBox6.Location = new Point(292, 74);
            materialTextBox6.Margin = new Padding(2);
            materialTextBox6.MaxLength = 50;
            materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox6.Multiline = false;
            materialTextBox6.Name = "materialTextBox6";
            materialTextBox6.Size = new Size(217, 50);
            materialTextBox6.TabIndex = 14;
            materialTextBox6.Text = "";
            materialTextBox6.TrailingIcon = null;
            // 
            // materialMaskedTextBox4
            // 
            materialMaskedTextBox4.AllowPromptAsInput = true;
            materialMaskedTextBox4.AnimateReadOnly = false;
            materialMaskedTextBox4.AsciiOnly = false;
            materialMaskedTextBox4.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox4.BeepOnError = false;
            materialMaskedTextBox4.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.Depth = 0;
            materialMaskedTextBox4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox4.HidePromptOnLeave = false;
            materialMaskedTextBox4.HideSelection = true;
            materialMaskedTextBox4.Hint = "Número";
            materialMaskedTextBox4.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox4.LeadingIcon = null;
            materialMaskedTextBox4.Location = new Point(157, 75);
            materialMaskedTextBox4.Mask = "0000000000";
            materialMaskedTextBox4.MaxLength = 32767;
            materialMaskedTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox4.Name = "materialMaskedTextBox4";
            materialMaskedTextBox4.PasswordChar = '\0';
            materialMaskedTextBox4.PrefixSuffixText = null;
            materialMaskedTextBox4.PromptChar = '_';
            materialMaskedTextBox4.ReadOnly = false;
            materialMaskedTextBox4.RejectInputOnFirstFailure = false;
            materialMaskedTextBox4.ResetOnPrompt = true;
            materialMaskedTextBox4.ResetOnSpace = true;
            materialMaskedTextBox4.RightToLeft = RightToLeft.No;
            materialMaskedTextBox4.SelectedText = "";
            materialMaskedTextBox4.SelectionLength = 0;
            materialMaskedTextBox4.SelectionStart = 0;
            materialMaskedTextBox4.ShortcutsEnabled = true;
            materialMaskedTextBox4.Size = new Size(129, 48);
            materialMaskedTextBox4.SkipLiterals = true;
            materialMaskedTextBox4.TabIndex = 12;
            materialMaskedTextBox4.TabStop = false;
            materialMaskedTextBox4.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox4.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.TrailingIcon = null;
            materialMaskedTextBox4.UseSystemPasswordChar = false;
            materialMaskedTextBox4.ValidatingType = null;
            // 
            // materialMaskedTextBox3
            // 
            materialMaskedTextBox3.AllowPromptAsInput = true;
            materialMaskedTextBox3.AnimateReadOnly = false;
            materialMaskedTextBox3.AsciiOnly = false;
            materialMaskedTextBox3.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox3.BeepOnError = false;
            materialMaskedTextBox3.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.Depth = 0;
            materialMaskedTextBox3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox3.HidePromptOnLeave = false;
            materialMaskedTextBox3.HideSelection = true;
            materialMaskedTextBox3.Hint = "CEP";
            materialMaskedTextBox3.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox3.LeadingIcon = null;
            materialMaskedTextBox3.Location = new Point(7, 75);
            materialMaskedTextBox3.Mask = "00.000-000000";
            materialMaskedTextBox3.MaxLength = 32767;
            materialMaskedTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox3.Name = "materialMaskedTextBox3";
            materialMaskedTextBox3.PasswordChar = '\0';
            materialMaskedTextBox3.PrefixSuffixText = null;
            materialMaskedTextBox3.PromptChar = '_';
            materialMaskedTextBox3.ReadOnly = false;
            materialMaskedTextBox3.RejectInputOnFirstFailure = false;
            materialMaskedTextBox3.ResetOnPrompt = true;
            materialMaskedTextBox3.ResetOnSpace = true;
            materialMaskedTextBox3.RightToLeft = RightToLeft.No;
            materialMaskedTextBox3.SelectedText = "";
            materialMaskedTextBox3.SelectionLength = 0;
            materialMaskedTextBox3.SelectionStart = 0;
            materialMaskedTextBox3.ShortcutsEnabled = true;
            materialMaskedTextBox3.Size = new Size(144, 48);
            materialMaskedTextBox3.SkipLiterals = true;
            materialMaskedTextBox3.TabIndex = 11;
            materialMaskedTextBox3.TabStop = false;
            materialMaskedTextBox3.Text = "  ,   -";
            materialMaskedTextBox3.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox3.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.TrailingIcon = null;
            materialMaskedTextBox3.UseSystemPasswordChar = false;
            materialMaskedTextBox3.ValidatingType = null;
            // 
            // materialTextBox5
            // 
            materialTextBox5.AnimateReadOnly = false;
            materialTextBox5.BorderStyle = BorderStyle.None;
            materialTextBox5.Depth = 0;
            materialTextBox5.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox5.Hint = "Bairro";
            materialTextBox5.LeadingIcon = null;
            materialTextBox5.Location = new Point(429, 19);
            materialTextBox5.Margin = new Padding(2);
            materialTextBox5.MaxLength = 50;
            materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox5.Multiline = false;
            materialTextBox5.Name = "materialTextBox5";
            materialTextBox5.Size = new Size(416, 50);
            materialTextBox5.TabIndex = 10;
            materialTextBox5.Text = "";
            materialTextBox5.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            materialTextBox4.AnimateReadOnly = false;
            materialTextBox4.BorderStyle = BorderStyle.None;
            materialTextBox4.Depth = 0;
            materialTextBox4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox4.Hint = "Rua";
            materialTextBox4.LeadingIcon = null;
            materialTextBox4.Location = new Point(7, 20);
            materialTextBox4.Margin = new Padding(2);
            materialTextBox4.MaxLength = 50;
            materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox4.Multiline = false;
            materialTextBox4.Name = "materialTextBox4";
            materialTextBox4.Size = new Size(415, 50);
            materialTextBox4.TabIndex = 9;
            materialTextBox4.Text = "";
            materialTextBox4.TrailingIcon = null;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(materialSwitch1);
            groupBox4.Controls.Add(btCancelar);
            groupBox4.Controls.Add(btSalvar);
            groupBox4.Controls.Add(btSalvarMais);
            groupBox4.Location = new Point(350, 316);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(507, 59);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ações";
            // 
            // btCancelar
            // 
            btCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCancelar.BackColor = Color.FromArgb(199, 199, 199);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.White;
            btCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btCancelar.IconColor = Color.White;
            btCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btCancelar.IconSize = 17;
            btCancelar.Location = new Point(402, 16);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 26;
            btCancelar.Text = "CANCELAR";
            btCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCancelar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            btSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvar.BackColor = Color.FromArgb(199, 199, 199);
            btSalvar.FlatAppearance.BorderSize = 0;
            btSalvar.FlatStyle = FlatStyle.Flat;
            btSalvar.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold);
            btSalvar.ForeColor = Color.White;
            btSalvar.IconChar = FontAwesome.Sharp.IconChar.None;
            btSalvar.IconColor = Color.Black;
            btSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvar.Location = new Point(299, 16);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 25;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = false;
            // 
            // btSalvarMais
            // 
            btSalvarMais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSalvarMais.BackColor = Color.FromArgb(199, 199, 199);
            btSalvarMais.FlatAppearance.BorderSize = 0;
            btSalvarMais.FlatStyle = FlatStyle.Flat;
            btSalvarMais.Font = new Font("Montserrat ExtraBold", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvarMais.ForeColor = Color.White;
            btSalvarMais.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btSalvarMais.IconColor = Color.White;
            btSalvarMais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSalvarMais.IconSize = 15;
            btSalvarMais.Location = new Point(196, 16);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 24;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(10, 15);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(159, 37);
            materialSwitch1.TabIndex = 27;
            materialSwitch1.Text = "Sem Endereço";
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // PessoasDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 383);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PessoasDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes da Pessoa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox boxNomeEstado;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}