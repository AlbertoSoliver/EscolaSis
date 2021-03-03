namespace EscolaSis.Forms.Relatorio.ListaAlunos
{
    partial class SelecListaAluno
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAnoListaAluno = new System.Windows.Forms.ComboBox();
            this.cbxTurmaListaAluno = new System.Windows.Forms.ComboBox();
            this.cbxOrientadorListaAluno = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(206, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(314, 216);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAnoListaAluno);
            this.groupBox1.Controls.Add(this.cbxTurmaListaAluno);
            this.groupBox1.Controls.Add(this.cbxOrientadorListaAluno);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 163);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // cbxAnoListaAluno
            // 
            this.cbxAnoListaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnoListaAluno.FormattingEnabled = true;
            this.cbxAnoListaAluno.Location = new System.Drawing.Point(15, 39);
            this.cbxAnoListaAluno.Name = "cbxAnoListaAluno";
            this.cbxAnoListaAluno.Size = new System.Drawing.Size(122, 21);
            this.cbxAnoListaAluno.TabIndex = 36;
            // 
            // cbxTurmaListaAluno
            // 
            this.cbxTurmaListaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmaListaAluno.FormattingEnabled = true;
            this.cbxTurmaListaAluno.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxTurmaListaAluno.Location = new System.Drawing.Point(164, 39);
            this.cbxTurmaListaAluno.Name = "cbxTurmaListaAluno";
            this.cbxTurmaListaAluno.Size = new System.Drawing.Size(153, 21);
            this.cbxTurmaListaAluno.TabIndex = 38;
            // 
            // cbxOrientadorListaAluno
            // 
            this.cbxOrientadorListaAluno.DisplayMember = "Nome";
            this.cbxOrientadorListaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientadorListaAluno.FormattingEnabled = true;
            this.cbxOrientadorListaAluno.Location = new System.Drawing.Point(15, 103);
            this.cbxOrientadorListaAluno.Name = "cbxOrientadorListaAluno";
            this.cbxOrientadorListaAluno.Size = new System.Drawing.Size(302, 21);
            this.cbxOrientadorListaAluno.TabIndex = 37;
            this.cbxOrientadorListaAluno.ValueMember = "OrientadorID";
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
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Tuma";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Orientador";
            // 
            // SelecListaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 282);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecListaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Alunos";
            this.Load += new System.EventHandler(this.SelecListaAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAnoListaAluno;
        private System.Windows.Forms.ComboBox cbxTurmaListaAluno;
        private System.Windows.Forms.ComboBox cbxOrientadorListaAluno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
    }
}