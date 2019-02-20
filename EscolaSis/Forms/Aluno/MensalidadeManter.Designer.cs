namespace EscolaSis.Forms.Aluno
{
    partial class MensalidadeManter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensalidadeManter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txbValorPatoMens = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txbDataPagto = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPatoMens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.comboBox12);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcela";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.comboBox12.Location = new System.Drawing.Point(294, 37);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(126, 21);
            this.comboBox12.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(291, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 13);
            this.label26.TabIndex = 48;
            this.label26.Text = "Mês e Ano Referência";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(291, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(31, 13);
            this.label37.TabIndex = 45;
            this.label37.Text = "Valor";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(294, 90);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 20);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 47;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 43;
            this.dateTimePicker2.Value = new System.DateTime(2019, 2, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Referência";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2019, 2, 6, 0, 0, 0, 0);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 40;
            this.label35.Text = "Emissão";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.txbValorPatoMens);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.txbDataPagto);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento da Parcela";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(291, 75);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 13);
            this.label41.TabIndex = 59;
            this.label41.Text = "Valor Pago";
            // 
            // txbValorPatoMens
            // 
            this.txbValorPatoMens.DecimalPlaces = 2;
            this.txbValorPatoMens.Location = new System.Drawing.Point(294, 91);
            this.txbValorPatoMens.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbValorPatoMens.Name = "txbValorPatoMens";
            this.txbValorPatoMens.ReadOnly = true;
            this.txbValorPatoMens.Size = new System.Drawing.Size(126, 20);
            this.txbValorPatoMens.TabIndex = 58;
            this.txbValorPatoMens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValorPatoMens.ThousandsSeparator = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(164, 75);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(70, 13);
            this.label40.TabIndex = 57;
            this.label40.Text = "Juros e Multa";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(167, 91);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown3.TabIndex = 56;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.ThousandsSeparator = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 75);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 13);
            this.label39.TabIndex = 55;
            this.label39.Text = "Desconto";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(15, 91);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown2.TabIndex = 54;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // txbDataPagto
            // 
            this.txbDataPagto.CustomFormat = " ";
            this.txbDataPagto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbDataPagto.Location = new System.Drawing.Point(294, 44);
            this.txbDataPagto.Name = "txbDataPagto";
            this.txbDataPagto.Size = new System.Drawing.Size(126, 20);
            this.txbDataPagto.TabIndex = 53;
            this.txbDataPagto.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txbDataPagto.ValueChanged += new System.EventHandler(this.txbDataPagto_ValueChanged);
            this.txbDataPagto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbDataPagto_KeyDown);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(291, 28);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(61, 13);
            this.label38.TabIndex = 52;
            this.label38.Text = "Pagamento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.comboBox1.Location = new System.Drawing.Point(15, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Forma de Pagamento";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(393, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 43);
            this.button5.TabIndex = 50;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(15, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(406, 20);
            this.textBox5.TabIndex = 51;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 13);
            this.label27.TabIndex = 50;
            this.label27.Text = "Responsável pelo Pagamento";
            // 
            // MensalidadeManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 385);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensalidadeManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Mensalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPatoMens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txbDataPagto;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown txbValorPatoMens;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label27;
    }
}