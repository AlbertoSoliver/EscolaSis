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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensalidadeManter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRespPagto = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxAnoRefer = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbxMesRefer = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.NumericUpDown();
            this.txbDataVencim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDataEmissão = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.grpFormPagto = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txbValorPagtoMens = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.txbJuros = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.txbValorDesc = new System.Windows.Forms.NumericUpDown();
            this.txbDataPagto = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.cbxFormPagto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravarLancamento = new System.Windows.Forms.Button();
            this.chkRealizPagto = new System.Windows.Forms.CheckBox();
            this.cbxReferencia = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValor)).BeginInit();
            this.grpFormPagto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPagtoMens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxReferencia);
            this.groupBox1.Controls.Add(this.cbxRespPagto);
            this.groupBox1.Controls.Add(this.cbxAnoRefer);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.cbxMesRefer);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.txbValor);
            this.groupBox1.Controls.Add(this.txbDataVencim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbDataEmissão);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcela";
            // 
            // cbxRespPagto
            // 
            this.cbxRespPagto.DataSource = this.responsavelBindingSource;
            this.cbxRespPagto.DisplayMember = "Nome";
            this.cbxRespPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRespPagto.FormattingEnabled = true;
            this.cbxRespPagto.Location = new System.Drawing.Point(15, 149);
            this.cbxRespPagto.Name = "cbxRespPagto";
            this.cbxRespPagto.Size = new System.Drawing.Size(405, 21);
            this.cbxRespPagto.TabIndex = 53;
            this.cbxRespPagto.ValueMember = "TutorAlunoID";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // cbxAnoRefer
            // 
            this.cbxAnoRefer.FormattingEnabled = true;
            this.cbxAnoRefer.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxAnoRefer.Location = new System.Drawing.Point(358, 38);
            this.cbxAnoRefer.MaxLength = 4;
            this.cbxAnoRefer.Name = "cbxAnoRefer";
            this.cbxAnoRefer.Size = new System.Drawing.Size(62, 21);
            this.cbxAnoRefer.TabIndex = 52;
            this.cbxAnoRefer.Text = "1998";
            this.cbxAnoRefer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAnoRefer_KeyPress);
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
            // cbxMesRefer
            // 
            this.cbxMesRefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesRefer.FormattingEnabled = true;
            this.cbxMesRefer.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxMesRefer.Location = new System.Drawing.Point(272, 37);
            this.cbxMesRefer.Name = "cbxMesRefer";
            this.cbxMesRefer.Size = new System.Drawing.Size(80, 21);
            this.cbxMesRefer.TabIndex = 49;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(269, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 13);
            this.label26.TabIndex = 48;
            this.label26.Text = "Mês e Ano Referência";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(269, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 13);
            this.label37.TabIndex = 45;
            this.label37.Text = "Valor Mensalidade";
            // 
            // txbValor
            // 
            this.txbValor.DecimalPlaces = 2;
            this.txbValor.Location = new System.Drawing.Point(272, 90);
            this.txbValor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(149, 20);
            this.txbValor.TabIndex = 44;
            this.txbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValor.ThousandsSeparator = true;
            this.txbValor.ValueChanged += new System.EventHandler(this.txbValor_ValueChanged);
            // 
            // txbDataVencim
            // 
            this.txbDataVencim.CustomFormat = "";
            this.txbDataVencim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbDataVencim.Location = new System.Drawing.Point(147, 90);
            this.txbDataVencim.Name = "txbDataVencim";
            this.txbDataVencim.Size = new System.Drawing.Size(108, 20);
            this.txbDataVencim.TabIndex = 43;
            this.txbDataVencim.Value = new System.DateTime(2019, 2, 6, 0, 0, 0, 0);
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
            // txbDataEmissão
            // 
            this.txbDataEmissão.CustomFormat = "";
            this.txbDataEmissão.Enabled = false;
            this.txbDataEmissão.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbDataEmissão.Location = new System.Drawing.Point(15, 90);
            this.txbDataEmissão.Name = "txbDataEmissão";
            this.txbDataEmissão.Size = new System.Drawing.Size(105, 20);
            this.txbDataEmissão.TabIndex = 41;
            this.txbDataEmissão.Value = new System.DateTime(2019, 2, 6, 0, 0, 0, 0);
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
            // grpFormPagto
            // 
            this.grpFormPagto.Controls.Add(this.label41);
            this.grpFormPagto.Controls.Add(this.txbValorPagtoMens);
            this.grpFormPagto.Controls.Add(this.label40);
            this.grpFormPagto.Controls.Add(this.txbJuros);
            this.grpFormPagto.Controls.Add(this.label39);
            this.grpFormPagto.Controls.Add(this.txbValorDesc);
            this.grpFormPagto.Controls.Add(this.txbDataPagto);
            this.grpFormPagto.Controls.Add(this.label38);
            this.grpFormPagto.Controls.Add(this.cbxFormPagto);
            this.grpFormPagto.Controls.Add(this.label3);
            this.grpFormPagto.Enabled = false;
            this.grpFormPagto.Location = new System.Drawing.Point(12, 205);
            this.grpFormPagto.Name = "grpFormPagto";
            this.grpFormPagto.Size = new System.Drawing.Size(427, 137);
            this.grpFormPagto.TabIndex = 1;
            this.grpFormPagto.TabStop = false;
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
            // txbValorPagtoMens
            // 
            this.txbValorPagtoMens.DecimalPlaces = 2;
            this.txbValorPagtoMens.Location = new System.Drawing.Point(294, 91);
            this.txbValorPagtoMens.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbValorPagtoMens.Name = "txbValorPagtoMens";
            this.txbValorPagtoMens.ReadOnly = true;
            this.txbValorPagtoMens.Size = new System.Drawing.Size(126, 20);
            this.txbValorPagtoMens.TabIndex = 58;
            this.txbValorPagtoMens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValorPagtoMens.ThousandsSeparator = true;
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
            // txbJuros
            // 
            this.txbJuros.DecimalPlaces = 2;
            this.txbJuros.Location = new System.Drawing.Point(167, 91);
            this.txbJuros.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbJuros.Name = "txbJuros";
            this.txbJuros.Size = new System.Drawing.Size(110, 20);
            this.txbJuros.TabIndex = 56;
            this.txbJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbJuros.ThousandsSeparator = true;
            this.txbJuros.ValueChanged += new System.EventHandler(this.txbJuros_ValueChanged);
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
            // txbValorDesc
            // 
            this.txbValorDesc.DecimalPlaces = 2;
            this.txbValorDesc.Location = new System.Drawing.Point(15, 91);
            this.txbValorDesc.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbValorDesc.Name = "txbValorDesc";
            this.txbValorDesc.Size = new System.Drawing.Size(115, 20);
            this.txbValorDesc.TabIndex = 54;
            this.txbValorDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValorDesc.ThousandsSeparator = true;
            this.txbValorDesc.ValueChanged += new System.EventHandler(this.txbValorDesc_ValueChanged);
            // 
            // txbDataPagto
            // 
            this.txbDataPagto.CustomFormat = " ";
            this.txbDataPagto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
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
            // cbxFormPagto
            // 
            this.cbxFormPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormPagto.FormattingEnabled = true;
            this.cbxFormPagto.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxFormPagto.Location = new System.Drawing.Point(15, 43);
            this.cbxFormPagto.Name = "cbxFormPagto";
            this.cbxFormPagto.Size = new System.Drawing.Size(262, 21);
            this.cbxFormPagto.TabIndex = 51;
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
            // btnGravarLancamento
            // 
            this.btnGravarLancamento.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarLancamento.Image")));
            this.btnGravarLancamento.Location = new System.Drawing.Point(393, 354);
            this.btnGravarLancamento.Name = "btnGravarLancamento";
            this.btnGravarLancamento.Size = new System.Drawing.Size(46, 43);
            this.btnGravarLancamento.TabIndex = 50;
            this.btnGravarLancamento.UseVisualStyleBackColor = true;
            this.btnGravarLancamento.Click += new System.EventHandler(this.btnGravarLancamento_Click);
            // 
            // chkRealizPagto
            // 
            this.chkRealizPagto.AutoSize = true;
            this.chkRealizPagto.Location = new System.Drawing.Point(27, 205);
            this.chkRealizPagto.Name = "chkRealizPagto";
            this.chkRealizPagto.Size = new System.Drawing.Size(121, 17);
            this.chkRealizPagto.TabIndex = 61;
            this.chkRealizPagto.Text = "Realizar Pagamento";
            this.chkRealizPagto.UseVisualStyleBackColor = true;
            this.chkRealizPagto.Click += new System.EventHandler(this.chkRealizPagto_Click);
            // 
            // cbxReferencia
            // 
            this.cbxReferencia.FormattingEnabled = true;
            this.cbxReferencia.Location = new System.Drawing.Point(15, 37);
            this.cbxReferencia.MaxLength = 4;
            this.cbxReferencia.Name = "cbxReferencia";
            this.cbxReferencia.Size = new System.Drawing.Size(240, 21);
            this.cbxReferencia.TabIndex = 54;
            // 
            // MensalidadeManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 403);
            this.Controls.Add(this.chkRealizPagto);
            this.Controls.Add(this.btnGravarLancamento);
            this.Controls.Add(this.grpFormPagto);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensalidadeManter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Mensalidade";
            this.Load += new System.EventHandler(this.MensalidadeManter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValor)).EndInit();
            this.grpFormPagto.ResumeLayout(false);
            this.grpFormPagto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPagtoMens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txbDataEmissão;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker txbDataVencim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown txbValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMesRefer;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox grpFormPagto;
        private System.Windows.Forms.ComboBox cbxFormPagto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txbDataPagto;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown txbValorPagtoMens;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown txbJuros;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown txbValorDesc;
        private System.Windows.Forms.Button btnGravarLancamento;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbxAnoRefer;
        private System.Windows.Forms.ComboBox cbxRespPagto;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private System.Windows.Forms.CheckBox chkRealizPagto;
        private System.Windows.Forms.ComboBox cbxReferencia;
    }
}