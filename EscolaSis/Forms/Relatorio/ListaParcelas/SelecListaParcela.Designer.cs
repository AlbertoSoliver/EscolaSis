namespace EscolaSis.Forms.Relatorio.ListaParcelas
{
    partial class SelecListaParcela
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAno = new System.Windows.Forms.ComboBox();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSituacMensaliade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(202, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(310, 224);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 43;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSituacMensaliade);
            this.groupBox1.Controls.Add(this.cbxAno);
            this.groupBox1.Controls.Add(this.cbxAluno);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(20, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 163);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cbxAno
            // 
            this.cbxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAno.FormattingEnabled = true;
            this.cbxAno.Location = new System.Drawing.Point(15, 39);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(122, 21);
            this.cbxAno.TabIndex = 36;
            // 
            // cbxAluno
            // 
            this.cbxAluno.DataSource = this.alunoBindingSource;
            this.cbxAluno.DisplayMember = "Nome";
            this.cbxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(15, 103);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(321, 21);
            this.cbxAluno.TabIndex = 41;
            this.cbxAluno.ValueMember = "AlunoID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Ano de Referência";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(161, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Situacao";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Aluno";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(EscolaSis.Model.Aluno);
            // 
            // cbxSituacMensaliade
            // 
            this.cbxSituacMensaliade.AccessibleDescription = "";
            this.cbxSituacMensaliade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacMensaliade.FormattingEnabled = true;
            this.cbxSituacMensaliade.Items.AddRange(new object[] {
            "Qualquer Situação",
            "Apenas Pagas",
            "Apenas Em Aberto"});
            this.cbxSituacMensaliade.Location = new System.Drawing.Point(164, 39);
            this.cbxSituacMensaliade.Name = "cbxSituacMensaliade";
            this.cbxSituacMensaliade.Size = new System.Drawing.Size(172, 21);
            this.cbxSituacMensaliade.TabIndex = 37;
            this.cbxSituacMensaliade.Tag = "";
            // 
            // SelecListaParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 282);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecListaParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Parcelas";
            this.Load += new System.EventHandler(this.SelecListaParcela_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAno;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxSituacMensaliade;
    }
}