namespace EscolaSis.Forms.Aluno
{
    partial class ResponsavelNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponsavelNovo));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ckbPodePegar = new System.Windows.Forms.CheckBox();
            this.ckbPagador = new System.Windows.Forms.CheckBox();
            this.cbxRelacAluno = new System.Windows.Forms.ComboBox();
            this.parentesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.cbxResponsavel = new System.Windows.Forms.ComboBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSalvar);
            this.groupBox8.Controls.Add(this.ckbPodePegar);
            this.groupBox8.Controls.Add(this.ckbPagador);
            this.groupBox8.Controls.Add(this.cbxRelacAluno);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.cbxResponsavel);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(538, 174);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(486, 125);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(46, 43);
            this.btnSalvar.TabIndex = 39;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ckbPodePegar
            // 
            this.ckbPodePegar.AutoSize = true;
            this.ckbPodePegar.Location = new System.Drawing.Point(395, 80);
            this.ckbPodePegar.Name = "ckbPodePegar";
            this.ckbPodePegar.Size = new System.Drawing.Size(121, 17);
            this.ckbPodePegar.TabIndex = 27;
            this.ckbPodePegar.Text = "Pode Pegar o Aluno";
            this.ckbPodePegar.UseVisualStyleBackColor = true;
            // 
            // ckbPagador
            // 
            this.ckbPagador.AutoSize = true;
            this.ckbPagador.Location = new System.Drawing.Point(222, 80);
            this.ckbPagador.Name = "ckbPagador";
            this.ckbPagador.Size = new System.Drawing.Size(145, 17);
            this.ckbPagador.TabIndex = 26;
            this.ckbPagador.Text = "Responsável Pagamento";
            this.ckbPagador.UseVisualStyleBackColor = true;
            // 
            // cbxRelacAluno
            // 
            this.cbxRelacAluno.DataSource = this.parentesoBindingSource;
            this.cbxRelacAluno.DisplayMember = "Descricao";
            this.cbxRelacAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRelacAluno.FormattingEnabled = true;
            this.cbxRelacAluno.Location = new System.Drawing.Point(9, 78);
            this.cbxRelacAluno.Name = "cbxRelacAluno";
            this.cbxRelacAluno.Size = new System.Drawing.Size(204, 21);
            this.cbxRelacAluno.TabIndex = 25;
            this.cbxRelacAluno.ValueMember = "Codigo";
            // 
            // parentesoBindingSource
            // 
            this.parentesoBindingSource.DataSource = typeof(EscolaSis.Model.Tools.Parenteso);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Relação com o Aluno";
            // 
            // cbxResponsavel
            // 
            this.cbxResponsavel.DataSource = this.responsavelBindingSource;
            this.cbxResponsavel.DisplayMember = "Nome";
            this.cbxResponsavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResponsavel.FormattingEnabled = true;
            this.cbxResponsavel.Location = new System.Drawing.Point(9, 32);
            this.cbxResponsavel.Name = "cbxResponsavel";
            this.cbxResponsavel.Size = new System.Drawing.Size(507, 21);
            this.cbxResponsavel.TabIndex = 2;
            this.cbxResponsavel.ValueMember = "TutorID";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataSource = typeof(EscolaSis.Model.Responsavel);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Nome";
            // 
            // ResponsavelNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 207);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponsavelNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Responsável";
            this.Load += new System.EventHandler(this.ResponsavelNovo_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbPodePegar;
        private System.Windows.Forms.CheckBox ckbPagador;
        private System.Windows.Forms.ComboBox cbxRelacAluno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxResponsavel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private System.Windows.Forms.BindingSource parentesoBindingSource;
    }
}