namespace EscolaSis.Forms.Aluno
{
    partial class MensalidadesPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensalidadesPeriodo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRespPagamneto = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMesFinal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDiaVenc = new System.Windows.Forms.NumericUpDown();
            this.cbxMesInicio = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxAnoMensalidade = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txbValorMensalidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarMensal = new System.Windows.Forms.Button();
            this.cbxReferencia = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaVenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorMensalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxReferencia);
            this.groupBox1.Controls.Add(this.cbxRespPagamneto);
            this.groupBox1.Controls.Add(this.cbxMesFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDiaVenc);
            this.groupBox1.Controls.Add(this.cbxMesInicio);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cbxAnoMensalidade);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.txbValorMensalidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paratrização das Mensalidades";
            // 
            // cbxRespPagamneto
            // 
            this.cbxRespPagamneto.DataSource = this.responsavelBindingSource;
            this.cbxRespPagamneto.DisplayMember = "Nome";
            this.cbxRespPagamneto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRespPagamneto.FormattingEnabled = true;
            this.cbxRespPagamneto.Location = new System.Drawing.Point(130, 144);
            this.cbxRespPagamneto.Name = "cbxRespPagamneto";
            this.cbxRespPagamneto.Size = new System.Drawing.Size(282, 21);
            this.cbxRespPagamneto.TabIndex = 7;
            this.cbxRespPagamneto.ValueMember = "TutorAlunoID";
            this.cbxRespPagamneto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // cbxMesFinal
            // 
            this.cbxMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesFinal.FormattingEnabled = true;
            this.cbxMesFinal.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxMesFinal.Location = new System.Drawing.Point(264, 50);
            this.cbxMesFinal.Name = "cbxMesFinal";
            this.cbxMesFinal.Size = new System.Drawing.Size(151, 21);
            this.cbxMesFinal.TabIndex = 3;
            this.cbxMesFinal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mês Referencia Final";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Dia Vencimento";
            // 
            // txbDiaVenc
            // 
            this.txbDiaVenc.Location = new System.Drawing.Point(9, 99);
            this.txbDiaVenc.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.txbDiaVenc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbDiaVenc.Name = "txbDiaVenc";
            this.txbDiaVenc.Size = new System.Drawing.Size(74, 20);
            this.txbDiaVenc.TabIndex = 4;
            this.txbDiaVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDiaVenc.ThousandsSeparator = true;
            this.txbDiaVenc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxMesInicio
            // 
            this.cbxMesInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesInicio.FormattingEnabled = true;
            this.cbxMesInicio.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxMesInicio.Location = new System.Drawing.Point(98, 50);
            this.cbxMesInicio.Name = "cbxMesInicio";
            this.cbxMesInicio.Size = new System.Drawing.Size(139, 21);
            this.cbxMesInicio.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(95, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Mês  Refêrência Inicial";
            // 
            // cbxAnoMensalidade
            // 
            this.cbxAnoMensalidade.DisplayMember = "0";
            this.cbxAnoMensalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnoMensalidade.FormattingEnabled = true;
            this.cbxAnoMensalidade.Items.AddRange(new object[] {
            "2019",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxAnoMensalidade.Location = new System.Drawing.Point(9, 50);
            this.cbxAnoMensalidade.Name = "cbxAnoMensalidade";
            this.cbxAnoMensalidade.Size = new System.Drawing.Size(61, 21);
            this.cbxAnoMensalidade.TabIndex = 1;
            this.cbxAnoMensalidade.Tag = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Ano";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(127, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(149, 13);
            this.label27.TabIndex = 50;
            this.label27.Text = "Responsável pelo Pagamento";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 128);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(68, 13);
            this.label37.TabIndex = 45;
            this.label37.Text = "Valor Mensal";
            // 
            // txbValorMensalidade
            // 
            this.txbValorMensalidade.DecimalPlaces = 2;
            this.txbValorMensalidade.Location = new System.Drawing.Point(9, 144);
            this.txbValorMensalidade.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txbValorMensalidade.Name = "txbValorMensalidade";
            this.txbValorMensalidade.Size = new System.Drawing.Size(104, 20);
            this.txbValorMensalidade.TabIndex = 6;
            this.txbValorMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValorMensalidade.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Referência";
            // 
            // btnGerarMensal
            // 
            this.btnGerarMensal.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarMensal.Image")));
            this.btnGerarMensal.Location = new System.Drawing.Point(393, 223);
            this.btnGerarMensal.Name = "btnGerarMensal";
            this.btnGerarMensal.Size = new System.Drawing.Size(46, 43);
            this.btnGerarMensal.TabIndex = 8;
            this.btnGerarMensal.UseVisualStyleBackColor = true;
            this.btnGerarMensal.Click += new System.EventHandler(this.btnGerarMensal_Click);
            // 
            // cbxReferencia
            // 
            this.cbxReferencia.FormattingEnabled = true;
            this.cbxReferencia.Location = new System.Drawing.Point(98, 99);
            this.cbxReferencia.MaxLength = 4;
            this.cbxReferencia.Name = "cbxReferencia";
            this.cbxReferencia.Size = new System.Drawing.Size(314, 21);
            this.cbxReferencia.TabIndex = 59;
            // 
            // MensalidadesPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.btnGerarMensal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensalidadesPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Mensalidades Pro Período";
            this.Load += new System.EventHandler(this.MensalidadesPeriodo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDiaVenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorMensalidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txbValorMensalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarMensal;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbxMesFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txbDiaVenc;
        private System.Windows.Forms.ComboBox cbxMesInicio;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbxAnoMensalidade;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbxRespPagamneto;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private System.Windows.Forms.ComboBox cbxReferencia;
    }
}