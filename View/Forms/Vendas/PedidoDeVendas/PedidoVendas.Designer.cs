namespace controle_vendas_comissoes.View.Forms.Vendas.PedidoDeVendas
{
    partial class PedidoVendas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            btBuscaUnidadePrimaria = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Pedido";
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 29);
            label2.TabIndex = 1;
            label2.Text = "10";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 18);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Data Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(129, 38);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 21);
            dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(164, 190, 240);
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(975, 18);
            label4.Name = "label4";
            label4.Size = new Size(234, 49);
            label4.TabIndex = 4;
            label4.Text = "PENDENTE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconButton1);
            groupBox1.Controls.Add(btBuscaUnidadePrimaria);
            groupBox1.Controls.Add(materialTextBox2);
            groupBox1.Controls.Add(materialTextBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1197, 160);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Responsáveis pela Venda";
            // 
            // label5
            // 
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(10, 23);
            label5.Name = "label5";
            label5.Size = new Size(187, 50);
            label5.TabIndex = 2;
            label5.Text = "GESTORA";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Silver;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(10, 95);
            label6.Name = "label6";
            label6.Size = new Size(187, 50);
            label6.TabIndex = 3;
            label6.Text = "REPRESENTANTE";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Escolha uma pessoa";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(213, 23);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(922, 50);
            materialTextBox1.TabIndex = 4;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.Hint = "Escolha uma pessoa";
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(213, 95);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(922, 50);
            materialTextBox2.TabIndex = 5;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // btBuscaUnidadePrimaria
            // 
            btBuscaUnidadePrimaria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBuscaUnidadePrimaria.BackColor = Color.FromArgb(199, 199, 199);
            btBuscaUnidadePrimaria.FlatAppearance.BorderSize = 0;
            btBuscaUnidadePrimaria.FlatStyle = FlatStyle.Flat;
            btBuscaUnidadePrimaria.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            btBuscaUnidadePrimaria.IconColor = Color.White;
            btBuscaUnidadePrimaria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btBuscaUnidadePrimaria.IconSize = 35;
            btBuscaUnidadePrimaria.Location = new Point(1141, 22);
            btBuscaUnidadePrimaria.Name = "btBuscaUnidadePrimaria";
            btBuscaUnidadePrimaria.Size = new Size(50, 50);
            btBuscaUnidadePrimaria.TabIndex = 13;
            btBuscaUnidadePrimaria.TextImageRelation = TextImageRelation.TextAboveImage;
            btBuscaUnidadePrimaria.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(1141, 94);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 50);
            iconButton1.TabIndex = 14;
            iconButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // PedidoVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 510);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PedidoVendas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedido de Vendas";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btBuscaUnidadePrimaria;
    }
}