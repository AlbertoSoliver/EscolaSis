namespace EscolaSis.Forms.Aluno
{
    partial class MatricNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatricNova));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txbRelatorio = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cbxResultado = new System.Windows.Forms.ComboBox();
            this.resultadoFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.txbDisciplianAtividade = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbxOrientador = new System.Windows.Forms.ComboBox();
            this.orientadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.cbxPeriodoLetivo = new System.Windows.Forms.ComboBox();
            this.periodoLetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.cbxAnoLetivo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoLetivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbxTurma);
            this.groupBox11.Controls.Add(this.btnGravar);
            this.groupBox11.Controls.Add(this.txbRelatorio);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.cbxResultado);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.txbDisciplianAtividade);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.cbxOrientador);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.cbxPeriodoLetivo);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.cbxAnoLetivo);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Location = new System.Drawing.Point(12, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(306, 363);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Cadastro de Matrícula";
            // 
            // cbxTurma
            // 
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxTurma.Location = new System.Drawing.Point(21, 198);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(126, 21);
            this.cbxTurma.TabIndex = 43;
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(237, 313);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(46, 43);
            this.btnGravar.TabIndex = 42;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txbRelatorio
            // 
            this.txbRelatorio.Location = new System.Drawing.Point(21, 248);
            this.txbRelatorio.Multiline = true;
            this.txbRelatorio.Name = "txbRelatorio";
            this.txbRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbRelatorio.Size = new System.Drawing.Size(259, 60);
            this.txbRelatorio.TabIndex = 41;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 231);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 40;
            this.label29.Text = "Relatório Final";
            // 
            // cbxResultado
            // 
            this.cbxResultado.DataSource = this.resultadoFinalBindingSource;
            this.cbxResultado.DisplayMember = "Descricao";
            this.cbxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResultado.FormattingEnabled = true;
            this.cbxResultado.Location = new System.Drawing.Point(178, 198);
            this.cbxResultado.Name = "cbxResultado";
            this.cbxResultado.Size = new System.Drawing.Size(102, 21);
            this.cbxResultado.TabIndex = 39;
            this.cbxResultado.ValueMember = "Codigo";
            // 
            // resultadoFinalBindingSource
            // 
            this.resultadoFinalBindingSource.DataSource = typeof(EscolaSis.Model.Tools.ResultadoFinal);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(175, 182);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 13);
            this.label28.TabIndex = 38;
            this.label28.Text = "Resultado Final";
            // 
            // txbDisciplianAtividade
            // 
            this.txbDisciplianAtividade.Location = new System.Drawing.Point(21, 148);
            this.txbDisciplianAtividade.Name = "txbDisciplianAtividade";
            this.txbDisciplianAtividade.Size = new System.Drawing.Size(262, 20);
            this.txbDisciplianAtividade.TabIndex = 37;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 131);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Disciplina / Atividade";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 182);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Tuma";
            // 
            // cbxOrientador
            // 
            this.cbxOrientador.DataSource = this.orientadorBindingSource;
            this.cbxOrientador.DisplayMember = "Nome";
            this.cbxOrientador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientador.FormattingEnabled = true;
            this.cbxOrientador.Location = new System.Drawing.Point(21, 99);
            this.cbxOrientador.Name = "cbxOrientador";
            this.cbxOrientador.Size = new System.Drawing.Size(262, 21);
            this.cbxOrientador.TabIndex = 33;
            this.cbxOrientador.ValueMember = "OrientadorID";
            // 
            // orientadorBindingSource
            // 
            this.orientadorBindingSource.DataSource = typeof(EscolaSis.Model.Orientador);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Orientador";
            // 
            // cbxPeriodoLetivo
            // 
            this.cbxPeriodoLetivo.DataSource = this.periodoLetivoBindingSource;
            this.cbxPeriodoLetivo.DisplayMember = "Descricao";
            this.cbxPeriodoLetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodoLetivo.FormattingEnabled = true;
            this.cbxPeriodoLetivo.Location = new System.Drawing.Point(151, 51);
            this.cbxPeriodoLetivo.Name = "cbxPeriodoLetivo";
            this.cbxPeriodoLetivo.Size = new System.Drawing.Size(132, 21);
            this.cbxPeriodoLetivo.TabIndex = 28;
            this.cbxPeriodoLetivo.ValueMember = "Codigo";
            // 
            // periodoLetivoBindingSource
            // 
            this.periodoLetivoBindingSource.DataSource = typeof(EscolaSis.Model.Tools.PeriodoLetivo);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(148, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Período Letivo";
            // 
            // cbxAnoLetivo
            // 
            this.cbxAnoLetivo.FormattingEnabled = true;
            this.cbxAnoLetivo.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxAnoLetivo.Location = new System.Drawing.Point(21, 51);
            this.cbxAnoLetivo.Name = "cbxAnoLetivo";
            this.cbxAnoLetivo.Size = new System.Drawing.Size(109, 21);
            this.cbxAnoLetivo.TabIndex = 26;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Ano Letivo";
            // 
            // MatricNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 380);
            this.Controls.Add(this.groupBox11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatricNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Matrícula";
            this.Load += new System.EventHandler(this.MatricNova_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoLetivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cbxTurma;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txbRelatorio;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbxResultado;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txbDisciplianAtividade;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbxOrientador;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxPeriodoLetivo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbxAnoLetivo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.BindingSource periodoLetivoBindingSource;
        private System.Windows.Forms.BindingSource resultadoFinalBindingSource;
        private System.Windows.Forms.BindingSource orientadorBindingSource;
    }
}