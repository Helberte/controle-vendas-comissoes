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
            groupInformacoesPessoais = new GroupBox();
            comboClassificacao = new MaterialSkin.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            dateDataNascimento = new DateTimePicker();
            maskRG = new MaterialSkin.Controls.MaterialMaskedTextBox();
            maskCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxNomeSobrenome = new MaterialSkin.Controls.MaterialTextBox();
            boxNomePessoa = new MaterialSkin.Controls.MaterialTextBox();
            groupEndereco = new GroupBox();
            btBuscaCidade = new FontAwesome.Sharp.IconButton();
            boxCidade = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaEstado = new FontAwesome.Sharp.IconButton();
            boxEstado = new MaterialSkin.Controls.MaterialTextBox();
            maskNumero = new MaterialSkin.Controls.MaterialMaskedTextBox();
            maskCEP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            boxBairro = new MaterialSkin.Controls.MaterialTextBox();
            boxRua = new MaterialSkin.Controls.MaterialTextBox();
            groupBox4 = new GroupBox();
            switchSemEndereco = new MaterialSkin.Controls.MaterialSwitch();
            btCancelar = new FontAwesome.Sharp.IconButton();
            btSalvar = new FontAwesome.Sharp.IconButton();
            btSalvarMais = new FontAwesome.Sharp.IconButton();
            groupInformacoesPessoais.SuspendLayout();
            groupBox2.SuspendLayout();
            groupEndereco.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupInformacoesPessoais
            // 
            groupInformacoesPessoais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupInformacoesPessoais.Controls.Add(comboClassificacao);
            groupInformacoesPessoais.Controls.Add(groupBox2);
            groupInformacoesPessoais.Controls.Add(maskRG);
            groupInformacoesPessoais.Controls.Add(maskCPF);
            groupInformacoesPessoais.Controls.Add(boxNomeSobrenome);
            groupInformacoesPessoais.Controls.Add(boxNomePessoa);
            groupInformacoesPessoais.Location = new Point(5, 4);
            groupInformacoesPessoais.Name = "groupInformacoesPessoais";
            groupInformacoesPessoais.Size = new Size(841, 137);
            groupInformacoesPessoais.TabIndex = 0;
            groupInformacoesPessoais.TabStop = false;
            groupInformacoesPessoais.Text = "Informações Pessoais";
            // 
            // comboClassificacao
            // 
            comboClassificacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboClassificacao.AutoResize = false;
            comboClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            comboClassificacao.Depth = 0;
            comboClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            comboClassificacao.DropDownHeight = 174;
            comboClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClassificacao.DropDownWidth = 121;
            comboClassificacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboClassificacao.FormattingEnabled = true;
            comboClassificacao.Hint = "Classificação";
            comboClassificacao.IntegralHeight = false;
            comboClassificacao.ItemHeight = 43;
            comboClassificacao.Items.AddRange(new object[] { "Gestor (a)", "Representante", "Nenhum" });
            comboClassificacao.Location = new Point(417, 80);
            comboClassificacao.MaxDropDownItems = 4;
            comboClassificacao.MouseState = MaterialSkin.MouseState.OUT;
            comboClassificacao.Name = "comboClassificacao";
            comboClassificacao.Size = new Size(258, 49);
            comboClassificacao.StartIndex = 0;
            comboClassificacao.TabIndex = 5;
            comboClassificacao.Tag = "Classificação";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(dateDataNascimento);
            groupBox2.Location = new Point(680, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 58);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Nascimento";
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Format = DateTimePickerFormat.Short;
            dateDataNascimento.Location = new Point(6, 22);
            dateDataNascimento.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateDataNascimento.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(140, 21);
            dateDataNascimento.TabIndex = 6;
            // 
            // maskRG
            // 
            maskRG.AllowPromptAsInput = true;
            maskRG.AnimateReadOnly = false;
            maskRG.AsciiOnly = false;
            maskRG.BackgroundImageLayout = ImageLayout.None;
            maskRG.BeepOnError = false;
            maskRG.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskRG.Depth = 0;
            maskRG.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskRG.HidePromptOnLeave = false;
            maskRG.HideSelection = true;
            maskRG.Hint = "RG";
            maskRG.InsertKeyMode = InsertKeyMode.Default;
            maskRG.LeadingIcon = null;
            maskRG.Location = new Point(209, 81);
            maskRG.Mask = "00000000";
            maskRG.MaxLength = 32767;
            maskRG.MouseState = MaterialSkin.MouseState.OUT;
            maskRG.Name = "maskRG";
            maskRG.PasswordChar = '\0';
            maskRG.PrefixSuffixText = null;
            maskRG.PromptChar = '_';
            maskRG.ReadOnly = false;
            maskRG.RejectInputOnFirstFailure = false;
            maskRG.ResetOnPrompt = true;
            maskRG.ResetOnSpace = true;
            maskRG.RightToLeft = RightToLeft.No;
            maskRG.SelectedText = "";
            maskRG.SelectionLength = 0;
            maskRG.SelectionStart = 0;
            maskRG.ShortcutsEnabled = true;
            maskRG.Size = new Size(202, 48);
            maskRG.SkipLiterals = true;
            maskRG.TabIndex = 4;
            maskRG.TabStop = false;
            maskRG.Tag = "RG";
            maskRG.TextAlign = HorizontalAlignment.Left;
            maskRG.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskRG.TrailingIcon = null;
            maskRG.UseSystemPasswordChar = false;
            maskRG.ValidatingType = null;
            // 
            // maskCPF
            // 
            maskCPF.AllowPromptAsInput = true;
            maskCPF.AnimateReadOnly = false;
            maskCPF.AsciiOnly = false;
            maskCPF.BackgroundImageLayout = ImageLayout.None;
            maskCPF.BeepOnError = false;
            maskCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskCPF.Depth = 0;
            maskCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskCPF.HidePromptOnLeave = false;
            maskCPF.HideSelection = true;
            maskCPF.Hint = "CPF";
            maskCPF.InsertKeyMode = InsertKeyMode.Default;
            maskCPF.LeadingIcon = null;
            maskCPF.Location = new Point(7, 81);
            maskCPF.Mask = "000.000.000-00";
            maskCPF.MaxLength = 32767;
            maskCPF.MouseState = MaterialSkin.MouseState.OUT;
            maskCPF.Name = "maskCPF";
            maskCPF.PasswordChar = '\0';
            maskCPF.PrefixSuffixText = null;
            maskCPF.PromptChar = '_';
            maskCPF.ReadOnly = false;
            maskCPF.RejectInputOnFirstFailure = false;
            maskCPF.ResetOnPrompt = true;
            maskCPF.ResetOnSpace = true;
            maskCPF.RightToLeft = RightToLeft.No;
            maskCPF.SelectedText = "";
            maskCPF.SelectionLength = 0;
            maskCPF.SelectionStart = 0;
            maskCPF.ShortcutsEnabled = true;
            maskCPF.Size = new Size(196, 48);
            maskCPF.SkipLiterals = true;
            maskCPF.TabIndex = 3;
            maskCPF.TabStop = false;
            maskCPF.Tag = "CPF";
            maskCPF.Text = "   ,   ,   -";
            maskCPF.TextAlign = HorizontalAlignment.Left;
            maskCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskCPF.TrailingIcon = null;
            maskCPF.UseSystemPasswordChar = false;
            maskCPF.ValidatingType = null;
            // 
            // boxNomeSobrenome
            // 
            boxNomeSobrenome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxNomeSobrenome.AnimateReadOnly = false;
            boxNomeSobrenome.BorderStyle = BorderStyle.None;
            boxNomeSobrenome.Depth = 0;
            boxNomeSobrenome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomeSobrenome.Hint = "Sobrenome";
            boxNomeSobrenome.LeadingIcon = null;
            boxNomeSobrenome.Location = new Point(418, 22);
            boxNomeSobrenome.Margin = new Padding(2);
            boxNomeSobrenome.MaxLength = 50;
            boxNomeSobrenome.MouseState = MaterialSkin.MouseState.OUT;
            boxNomeSobrenome.Multiline = false;
            boxNomeSobrenome.Name = "boxNomeSobrenome";
            boxNomeSobrenome.Size = new Size(416, 50);
            boxNomeSobrenome.TabIndex = 2;
            boxNomeSobrenome.Tag = "Sobrenome";
            boxNomeSobrenome.Text = "";
            boxNomeSobrenome.TrailingIcon = null;
            // 
            // boxNomePessoa
            // 
            boxNomePessoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxNomePessoa.AnimateReadOnly = false;
            boxNomePessoa.BorderStyle = BorderStyle.None;
            boxNomePessoa.Depth = 0;
            boxNomePessoa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxNomePessoa.Hint = "Nome da Pessoa";
            boxNomePessoa.LeadingIcon = null;
            boxNomePessoa.Location = new Point(6, 22);
            boxNomePessoa.Margin = new Padding(2);
            boxNomePessoa.MaxLength = 50;
            boxNomePessoa.MouseState = MaterialSkin.MouseState.OUT;
            boxNomePessoa.Multiline = false;
            boxNomePessoa.Name = "boxNomePessoa";
            boxNomePessoa.Size = new Size(405, 50);
            boxNomePessoa.TabIndex = 1;
            boxNomePessoa.Tag = "Nome Pessoa";
            boxNomePessoa.Text = "";
            boxNomePessoa.TrailingIcon = null;
            // 
            // groupEndereco
            // 
            groupEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupEndereco.Controls.Add(btBuscaCidade);
            groupEndereco.Controls.Add(boxCidade);
            groupEndereco.Controls.Add(btBuscaEstado);
            groupEndereco.Controls.Add(boxEstado);
            groupEndereco.Controls.Add(maskNumero);
            groupEndereco.Controls.Add(maskCEP);
            groupEndereco.Controls.Add(boxBairro);
            groupEndereco.Controls.Add(boxRua);
            groupEndereco.Location = new Point(5, 150);
            groupEndereco.Name = "groupEndereco";
            groupEndereco.Size = new Size(841, 133);
            groupEndereco.TabIndex = 1;
            groupEndereco.TabStop = false;
            groupEndereco.Text = "Endereço";
            // 
            // btBuscaCidade
            // 
            btBuscaCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaCidade.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaCidade.FlatAppearance.BorderSize = 0;
            btBuscaCidade.FlatStyle = FlatStyle.Flat;
            btBuscaCidade.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaCidade.IconColor = Color.White;
            btBuscaCidade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaCidade.IconSize = 35;
            btBuscaCidade.Location = new Point(785, 74);
            btBuscaCidade.Name = "btBuscaCidade";
            btBuscaCidade.Size = new Size(49, 49);
            btBuscaCidade.TabIndex = 14;
            btBuscaCidade.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaCidade.UseVisualStyleBackColor = false;
            // 
            // boxCidade
            // 
            boxCidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxCidade.AnimateReadOnly = false;
            boxCidade.BorderStyle = BorderStyle.None;
            boxCidade.Depth = 0;
            boxCidade.Enabled = false;
            boxCidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxCidade.Hint = "Cidade";
            boxCidade.LeadingIcon = null;
            boxCidade.Location = new Point(559, 74);
            boxCidade.Margin = new Padding(2);
            boxCidade.MaxLength = 50;
            boxCidade.MouseState = MaterialSkin.MouseState.OUT;
            boxCidade.Multiline = false;
            boxCidade.Name = "boxCidade";
            boxCidade.Size = new Size(220, 50);
            boxCidade.TabIndex = 13;
            boxCidade.Tag = "Cidade";
            boxCidade.Text = "";
            boxCidade.TrailingIcon = null;
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
            btBuscaEstado.Location = new Point(504, 74);
            btBuscaEstado.Name = "btBuscaEstado";
            btBuscaEstado.Size = new Size(49, 49);
            btBuscaEstado.TabIndex = 12;
            btBuscaEstado.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaEstado.UseVisualStyleBackColor = false;
            // 
            // boxEstado
            // 
            boxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxEstado.AnimateReadOnly = false;
            boxEstado.BorderStyle = BorderStyle.None;
            boxEstado.Depth = 0;
            boxEstado.Enabled = false;
            boxEstado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxEstado.Hint = "Estado";
            boxEstado.LeadingIcon = null;
            boxEstado.Location = new Point(292, 74);
            boxEstado.Margin = new Padding(2);
            boxEstado.MaxLength = 50;
            boxEstado.MouseState = MaterialSkin.MouseState.OUT;
            boxEstado.Multiline = false;
            boxEstado.Name = "boxEstado";
            boxEstado.Size = new Size(206, 50);
            boxEstado.TabIndex = 11;
            boxEstado.Tag = "Estado";
            boxEstado.Text = "";
            boxEstado.TrailingIcon = null;
            // 
            // maskNumero
            // 
            maskNumero.AllowPromptAsInput = true;
            maskNumero.AnimateReadOnly = false;
            maskNumero.AsciiOnly = false;
            maskNumero.BackgroundImageLayout = ImageLayout.None;
            maskNumero.BeepOnError = false;
            maskNumero.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskNumero.Depth = 0;
            maskNumero.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskNumero.HidePromptOnLeave = false;
            maskNumero.HideSelection = true;
            maskNumero.Hint = "Número";
            maskNumero.InsertKeyMode = InsertKeyMode.Default;
            maskNumero.LeadingIcon = null;
            maskNumero.Location = new Point(157, 75);
            maskNumero.Mask = "0000000000";
            maskNumero.MaxLength = 32767;
            maskNumero.MouseState = MaterialSkin.MouseState.OUT;
            maskNumero.Name = "maskNumero";
            maskNumero.PasswordChar = '\0';
            maskNumero.PrefixSuffixText = null;
            maskNumero.PromptChar = '_';
            maskNumero.ReadOnly = false;
            maskNumero.RejectInputOnFirstFailure = false;
            maskNumero.ResetOnPrompt = true;
            maskNumero.ResetOnSpace = true;
            maskNumero.RightToLeft = RightToLeft.No;
            maskNumero.SelectedText = "";
            maskNumero.SelectionLength = 0;
            maskNumero.SelectionStart = 0;
            maskNumero.ShortcutsEnabled = true;
            maskNumero.Size = new Size(129, 48);
            maskNumero.SkipLiterals = true;
            maskNumero.TabIndex = 10;
            maskNumero.TabStop = false;
            maskNumero.Tag = "Número";
            maskNumero.TextAlign = HorizontalAlignment.Left;
            maskNumero.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskNumero.TrailingIcon = null;
            maskNumero.UseSystemPasswordChar = false;
            maskNumero.ValidatingType = null;
            // 
            // maskCEP
            // 
            maskCEP.AllowPromptAsInput = true;
            maskCEP.AnimateReadOnly = false;
            maskCEP.AsciiOnly = false;
            maskCEP.BackgroundImageLayout = ImageLayout.None;
            maskCEP.BeepOnError = false;
            maskCEP.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskCEP.Depth = 0;
            maskCEP.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskCEP.HidePromptOnLeave = false;
            maskCEP.HideSelection = true;
            maskCEP.Hint = "CEP";
            maskCEP.InsertKeyMode = InsertKeyMode.Default;
            maskCEP.LeadingIcon = null;
            maskCEP.Location = new Point(7, 75);
            maskCEP.Mask = "00.000-000000";
            maskCEP.MaxLength = 32767;
            maskCEP.MouseState = MaterialSkin.MouseState.OUT;
            maskCEP.Name = "maskCEP";
            maskCEP.PasswordChar = '\0';
            maskCEP.PrefixSuffixText = null;
            maskCEP.PromptChar = '_';
            maskCEP.ReadOnly = false;
            maskCEP.RejectInputOnFirstFailure = false;
            maskCEP.ResetOnPrompt = true;
            maskCEP.ResetOnSpace = true;
            maskCEP.RightToLeft = RightToLeft.No;
            maskCEP.SelectedText = "";
            maskCEP.SelectionLength = 0;
            maskCEP.SelectionStart = 0;
            maskCEP.ShortcutsEnabled = true;
            maskCEP.Size = new Size(144, 48);
            maskCEP.SkipLiterals = true;
            maskCEP.TabIndex = 9;
            maskCEP.TabStop = false;
            maskCEP.Tag = "CEP";
            maskCEP.Text = "  ,   -";
            maskCEP.TextAlign = HorizontalAlignment.Left;
            maskCEP.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskCEP.TrailingIcon = null;
            maskCEP.UseSystemPasswordChar = false;
            maskCEP.ValidatingType = null;
            // 
            // boxBairro
            // 
            boxBairro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxBairro.AnimateReadOnly = false;
            boxBairro.BorderStyle = BorderStyle.None;
            boxBairro.Depth = 0;
            boxBairro.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxBairro.Hint = "Bairro";
            boxBairro.LeadingIcon = null;
            boxBairro.Location = new Point(418, 19);
            boxBairro.Margin = new Padding(2);
            boxBairro.MaxLength = 50;
            boxBairro.MouseState = MaterialSkin.MouseState.OUT;
            boxBairro.Multiline = false;
            boxBairro.Name = "boxBairro";
            boxBairro.Size = new Size(416, 50);
            boxBairro.TabIndex = 8;
            boxBairro.Tag = "Bairro";
            boxBairro.Text = "";
            boxBairro.TrailingIcon = null;
            // 
            // boxRua
            // 
            boxRua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxRua.AnimateReadOnly = false;
            boxRua.BorderStyle = BorderStyle.None;
            boxRua.Depth = 0;
            boxRua.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            boxRua.Hint = "Rua";
            boxRua.LeadingIcon = null;
            boxRua.Location = new Point(7, 20);
            boxRua.Margin = new Padding(2);
            boxRua.MaxLength = 50;
            boxRua.MouseState = MaterialSkin.MouseState.OUT;
            boxRua.Multiline = false;
            boxRua.Name = "boxRua";
            boxRua.Size = new Size(404, 50);
            boxRua.TabIndex = 7;
            boxRua.Tag = "Rua";
            boxRua.Text = "";
            boxRua.TrailingIcon = null;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox4.Controls.Add(switchSemEndereco);
            groupBox4.Controls.Add(btCancelar);
            groupBox4.Controls.Add(btSalvar);
            groupBox4.Controls.Add(btSalvarMais);
            groupBox4.Location = new Point(339, 366);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(507, 59);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ações";
            // 
            // switchSemEndereco
            // 
            switchSemEndereco.AutoSize = true;
            switchSemEndereco.Depth = 0;
            switchSemEndereco.Location = new Point(10, 15);
            switchSemEndereco.Margin = new Padding(0);
            switchSemEndereco.MouseLocation = new Point(-1, -1);
            switchSemEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            switchSemEndereco.Name = "switchSemEndereco";
            switchSemEndereco.Ripple = true;
            switchSemEndereco.Size = new Size(159, 37);
            switchSemEndereco.TabIndex = 15;
            switchSemEndereco.Text = "Sem Endereço";
            switchSemEndereco.UseVisualStyleBackColor = true;
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
            btCancelar.Location = new Point(402, 16);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 33);
            btCancelar.TabIndex = 18;
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
            btSalvar.Location = new Point(299, 16);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(97, 33);
            btSalvar.TabIndex = 17;
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
            btSalvarMais.Location = new Point(196, 16);
            btSalvarMais.Name = "btSalvarMais";
            btSalvarMais.Size = new Size(97, 33);
            btSalvarMais.TabIndex = 16;
            btSalvarMais.Text = "SALVAR";
            btSalvarMais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSalvarMais.UseVisualStyleBackColor = false;
            // 
            // PessoasDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 433);
            Controls.Add(groupBox4);
            Controls.Add(groupEndereco);
            Controls.Add(groupInformacoesPessoais);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(1009, 511);
            MinimumSize = new Size(836, 443);
            Name = "PessoasDetalhes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes da Pessoa";
            groupInformacoesPessoais.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupEndereco.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInformacoesPessoais;
        private MaterialSkin.Controls.MaterialTextBox boxNomePessoa;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskCPF;
        private MaterialSkin.Controls.MaterialTextBox boxNomeSobrenome;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskRG;
        private GroupBox groupBox2;
        private DateTimePicker dateDataNascimento;
        private GroupBox groupEndereco;
        private MaterialSkin.Controls.MaterialTextBox boxBairro;
        private MaterialSkin.Controls.MaterialTextBox boxRua;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskCEP;
        private MaterialSkin.Controls.MaterialMaskedTextBox maskNumero;
        private FontAwesome.Sharp.IconButton btBuscaCidade;
        private MaterialSkin.Controls.MaterialTextBox boxCidade;
        private FontAwesome.Sharp.IconButton btBuscaEstado;
        private MaterialSkin.Controls.MaterialTextBox boxEstado;
        private GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btCancelar;
        private FontAwesome.Sharp.IconButton btSalvar;
        private FontAwesome.Sharp.IconButton btSalvarMais;
        private MaterialSkin.Controls.MaterialSwitch switchSemEndereco;
        private MaterialSkin.Controls.MaterialComboBox comboClassificacao;
    }
}