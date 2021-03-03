namespace EscolaSis.Forms.Curso
{
    partial class GradeCurricManter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeCurricManter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCursoNome = new System.Windows.Forms.Label();
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.txbHoraAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeDiscipl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigoDiscipl = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txbCargaHr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxAreaConhec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCursoNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 56);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " CURSO ";
            // 
            // lblCursoNome
            // 
            this.lblCursoNome.AutoSize = true;
            this.lblCursoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoNome.Location = new System.Drawing.Point(6, 16);
            this.lblCursoNome.Name = "lblCursoNome";
            this.lblCursoNome.Size = new System.Drawing.Size(165, 26);
            this.lblCursoNome.TabIndex = 4;
            this.lblCursoNome.Text = "Nome do Curso";
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.Controls.Add(this.cbxAreaConhec);
            this.gbxPrincipal.Controls.Add(this.label5);
            this.gbxPrincipal.Controls.Add(this.txbCargaHr);
            this.gbxPrincipal.Controls.Add(this.label4);
            this.gbxPrincipal.Controls.Add(this.txbHoraAula);
            this.gbxPrincipal.Controls.Add(this.label3);
            this.gbxPrincipal.Controls.Add(this.txbObservacao);
            this.gbxPrincipal.Controls.Add(this.label2);
            this.gbxPrincipal.Controls.Add(this.txbNomeDiscipl);
            this.gbxPrincipal.Controls.Add(this.label1);
            this.gbxPrincipal.Controls.Add(this.btnGravar);
            this.gbxPrincipal.Controls.Add(this.txbCodigoDiscipl);
            this.gbxPrincipal.Controls.Add(this.label27);
            this.gbxPrincipal.Location = new System.Drawing.Point(12, 74);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Size = new System.Drawing.Size(454, 299);
            this.gbxPrincipal.TabIndex = 45;
            this.gbxPrincipal.TabStop = false;
            this.gbxPrincipal.Text = "NOVO CURSO / ALTERAR";
            // 
            // txbHoraAula
            // 
            this.txbHoraAula.Location = new System.Drawing.Point(21, 121);
            this.txbHoraAula.Name = "txbHoraAula";
            this.txbHoraAula.Size = new System.Drawing.Size(75, 20);
            this.txbHoraAula.TabIndex = 3;
            this.txbHoraAula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbHoraAula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hora Aula (min)";
            // 
            // txbObservacao
            // 
            this.txbObservacao.Location = new System.Drawing.Point(21, 187);
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(402, 20);
            this.txbObservacao.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Observação";
            // 
            // txbNomeDiscipl
            // 
            this.txbNomeDiscipl.Location = new System.Drawing.Point(120, 58);
            this.txbNomeDiscipl.Name = "txbNomeDiscipl";
            this.txbNomeDiscipl.Size = new System.Drawing.Size(303, 20);
            this.txbNomeDiscipl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome da Disciplina";
            // 
            // txbCodigoDiscipl
            // 
            this.txbCodigoDiscipl.Location = new System.Drawing.Point(21, 58);
            this.txbCodigoDiscipl.Name = "txbCodigoDiscipl";
            this.txbCodigoDiscipl.Size = new System.Drawing.Size(82, 20);
            this.txbCodigoDiscipl.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Código Disciplina";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(377, 240);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(46, 43);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // txbCargaHr
            // 
            this.txbCargaHr.Location = new System.Drawing.Point(120, 121);
            this.txbCargaHr.Name = "txbCargaHr";
            this.txbCargaHr.Size = new System.Drawing.Size(81, 20);
            this.txbCargaHr.TabIndex = 4;
            this.txbCargaHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCargaHr_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Caga Hr. ( h.a. )";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cbxAreaConhec
            // 
            this.cbxAreaConhec.DisplayMember = "DescrCompleta";
            this.cbxAreaConhec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAreaConhec.FormattingEnabled = true;
            this.cbxAreaConhec.Location = new System.Drawing.Point(220, 121);
            this.cbxAreaConhec.Name = "cbxAreaConhec";
            this.cbxAreaConhec.Size = new System.Drawing.Size(203, 21);
            this.cbxAreaConhec.TabIndex = 5;
            this.cbxAreaConhec.ValueMember = "AreaConhecimentoID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Area de Conhecimento";
            // 
            // GradeCurricManter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 386);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeCurricManter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplinas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCursoNome;
        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.TextBox txbHoraAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeDiscipl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txbCodigoDiscipl;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txbCargaHr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAreaConhec;
        private System.Windows.Forms.Label label5;
    }
}