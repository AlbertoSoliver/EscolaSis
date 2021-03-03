namespace EscolaSis.Forms.Curso
{
    partial class ManterCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterCurso));
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.txbCargaHoraria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescrCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txbCodigoCurso = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.gbxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.Controls.Add(this.txbCargaHoraria);
            this.gbxPrincipal.Controls.Add(this.label3);
            this.gbxPrincipal.Controls.Add(this.txbDescrCurso);
            this.gbxPrincipal.Controls.Add(this.label2);
            this.gbxPrincipal.Controls.Add(this.txbNomeCurso);
            this.gbxPrincipal.Controls.Add(this.label1);
            this.gbxPrincipal.Controls.Add(this.btnGravar);
            this.gbxPrincipal.Controls.Add(this.txbCodigoCurso);
            this.gbxPrincipal.Controls.Add(this.label27);
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(366, 292);
            this.gbxPrincipal.TabIndex = 6;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "NOVO CURSO / ALTERAR";
            // 
            // txbCargaHoraria
            // 
            this.txbCargaHoraria.Location = new System.Drawing.Point(21, 212);
            this.txbCargaHoraria.Name = "txbCargaHoraria";
            this.txbCargaHoraria.Size = new System.Drawing.Size(82, 20);
            this.txbCargaHoraria.TabIndex = 49;
            this.txbCargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCargaHoraria_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Carga Horário";
            // 
            // txbDescrCurso
            // 
            this.txbDescrCurso.Location = new System.Drawing.Point(21, 154);
            this.txbDescrCurso.Name = "txbDescrCurso";
            this.txbDescrCurso.Size = new System.Drawing.Size(317, 20);
            this.txbDescrCurso.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Descrição do Curso";
            // 
            // txbNomeCurso
            // 
            this.txbNomeCurso.Location = new System.Drawing.Point(21, 100);
            this.txbNomeCurso.Name = "txbNomeCurso";
            this.txbNomeCurso.Size = new System.Drawing.Size(317, 20);
            this.txbNomeCurso.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Título do Curso";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(292, 232);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(46, 43);
            this.btnGravar.TabIndex = 42;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // txbCodigoCurso
            // 
            this.txbCodigoCurso.Location = new System.Drawing.Point(21, 47);
            this.txbCodigoCurso.Name = "txbCodigoCurso";
            this.txbCodigoCurso.Size = new System.Drawing.Size(82, 20);
            this.txbCodigoCurso.TabIndex = 37;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Código do Curso";
            // 
            // ManterCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 319);
            this.Controls.Add(this.gbxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManterCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Curso";
            this.Load += new System.EventHandler(this.ManterCurso_Load);
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txbCodigoCurso;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txbNomeCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescrCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCargaHoraria;
        private System.Windows.Forms.Label label3;
    }
}