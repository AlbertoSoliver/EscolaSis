namespace EscolaSis.Forms.Curso
{
    partial class GradeCurrCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeCurrCurso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCargaHrCurso = new System.Windows.Forms.Label();
            this.lblCursoNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCHLanc = new System.Windows.Forms.Label();
            this.dgvGradeCurric = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.GradeCurricularID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargaHrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlterarDiscipl = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExcluirDiscipl = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeCurric)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCargaHrCurso);
            this.groupBox1.Controls.Add(this.lblCursoNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 58);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " CURSO ";
            // 
            // lblCargaHrCurso
            // 
            this.lblCargaHrCurso.AutoSize = true;
            this.lblCargaHrCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaHrCurso.Location = new System.Drawing.Point(551, 20);
            this.lblCargaHrCurso.Name = "lblCargaHrCurso";
            this.lblCargaHrCurso.Size = new System.Drawing.Size(108, 20);
            this.lblCargaHrCurso.TabIndex = 6;
            this.lblCargaHrCurso.Text = "Carga Horária";
            this.lblCargaHrCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCHLanc);
            this.groupBox2.Controls.Add(this.dgvGradeCurric);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(9, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 418);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // lblCHLanc
            // 
            this.lblCHLanc.AutoSize = true;
            this.lblCHLanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHLanc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCHLanc.Location = new System.Drawing.Point(440, 395);
            this.lblCHLanc.Name = "lblCHLanc";
            this.lblCHLanc.Size = new System.Drawing.Size(108, 20);
            this.lblCHLanc.TabIndex = 48;
            this.lblCHLanc.Text = "CH Lançada";
            this.lblCHLanc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvGradeCurric
            // 
            this.dgvGradeCurric.AllowUserToAddRows = false;
            this.dgvGradeCurric.AllowUserToDeleteRows = false;
            this.dgvGradeCurric.AllowUserToResizeRows = false;
            this.dgvGradeCurric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGradeCurric.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGradeCurric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeCurric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeCurricularID,
            this.CodigoDisciplina,
            this.NomeDisciplina,
            this.HoraAula,
            this.CargaHrTotal,
            this.AlterarDiscipl,
            this.ExcluirDiscipl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGradeCurric.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGradeCurric.Location = new System.Drawing.Point(6, 58);
            this.dgvGradeCurric.MultiSelect = false;
            this.dgvGradeCurric.Name = "dgvGradeCurric";
            this.dgvGradeCurric.ReadOnly = true;
            this.dgvGradeCurric.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvGradeCurric.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGradeCurric.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradeCurric.Size = new System.Drawing.Size(650, 334);
            this.dgvGradeCurric.TabIndex = 47;
            this.dgvGradeCurric.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradeCurric_CellClick_1);
            this.dgvGradeCurric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradeCurric_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(656, 39);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Incluir Disciplina";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Alterar";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Excluir";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // GradeCurricularID
            // 
            this.GradeCurricularID.DataPropertyName = "GradeCurricularID";
            this.GradeCurricularID.HeaderText = "GradeCurricularID";
            this.GradeCurricularID.Name = "GradeCurricularID";
            this.GradeCurricularID.ReadOnly = true;
            this.GradeCurricularID.Visible = false;
            // 
            // CodigoDisciplina
            // 
            this.CodigoDisciplina.DataPropertyName = "CodigoDisciplina";
            this.CodigoDisciplina.HeaderText = "Código";
            this.CodigoDisciplina.Name = "CodigoDisciplina";
            this.CodigoDisciplina.ReadOnly = true;
            this.CodigoDisciplina.Width = 60;
            // 
            // NomeDisciplina
            // 
            this.NomeDisciplina.DataPropertyName = "NomeDisciplina";
            this.NomeDisciplina.HeaderText = "Disciplina";
            this.NomeDisciplina.Name = "NomeDisciplina";
            this.NomeDisciplina.ReadOnly = true;
            this.NomeDisciplina.Width = 260;
            // 
            // HoraAula
            // 
            this.HoraAula.DataPropertyName = "HoraAula";
            this.HoraAula.HeaderText = "Duração";
            this.HoraAula.Name = "HoraAula";
            this.HoraAula.ReadOnly = true;
            this.HoraAula.ToolTipText = "Duração de cada hora aula em minutos";
            // 
            // CargaHrTotal
            // 
            this.CargaHrTotal.DataPropertyName = "CargaHrTotal";
            this.CargaHrTotal.HeaderText = "Carga Horária";
            this.CargaHrTotal.Name = "CargaHrTotal";
            this.CargaHrTotal.ReadOnly = true;
            this.CargaHrTotal.ToolTipText = "Total de horas a serem cumpridas para provação";
            this.CargaHrTotal.Width = 150;
            // 
            // AlterarDiscipl
            // 
            this.AlterarDiscipl.HeaderText = "";
            this.AlterarDiscipl.Image = ((System.Drawing.Image)(resources.GetObject("AlterarDiscipl.Image")));
            this.AlterarDiscipl.Name = "AlterarDiscipl";
            this.AlterarDiscipl.ReadOnly = true;
            this.AlterarDiscipl.ToolTipText = "Alterar";
            this.AlterarDiscipl.Width = 30;
            // 
            // ExcluirDiscipl
            // 
            this.ExcluirDiscipl.HeaderText = "";
            this.ExcluirDiscipl.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirDiscipl.Image")));
            this.ExcluirDiscipl.Name = "ExcluirDiscipl";
            this.ExcluirDiscipl.ReadOnly = true;
            this.ExcluirDiscipl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcluirDiscipl.ToolTipText = "Excluir";
            this.ExcluirDiscipl.Width = 30;
            // 
            // GradeCurrCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeCurrCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Curricular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeCurric)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCursoNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGradeCurric;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblCargaHrCurso;
        private System.Windows.Forms.Label lblCHLanc;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeCurricularID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargaHrTotal;
        private System.Windows.Forms.DataGridViewImageColumn AlterarDiscipl;
        private System.Windows.Forms.DataGridViewImageColumn ExcluirDiscipl;
    }
}