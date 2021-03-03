namespace EscolaSis.Forms.Relatorio.Caderneta
{
    partial class SelecCaderneta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMesCaderneta = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxAnoCaderneta = new System.Windows.Forms.ComboBox();
            this.cbxTurmaCaderneta = new System.Windows.Forms.ComboBox();
            this.cbxOrientadorCaderneta = new System.Windows.Forms.ComboBox();
            this.orientadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMesCaderneta);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.cbxAnoCaderneta);
            this.groupBox1.Controls.Add(this.cbxTurmaCaderneta);
            this.groupBox1.Controls.Add(this.cbxOrientadorCaderneta);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbxMesCaderneta
            // 
            this.cbxMesCaderneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesCaderneta.FormattingEnabled = true;
            this.cbxMesCaderneta.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxMesCaderneta.Location = new System.Drawing.Point(138, 39);
            this.cbxMesCaderneta.Name = "cbxMesCaderneta";
            this.cbxMesCaderneta.Size = new System.Drawing.Size(181, 21);
            this.cbxMesCaderneta.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(135, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Mês  de Referência";
            // 
            // cbxAnoCaderneta
            // 
            this.cbxAnoCaderneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnoCaderneta.FormattingEnabled = true;
            this.cbxAnoCaderneta.Location = new System.Drawing.Point(15, 39);
            this.cbxAnoCaderneta.Name = "cbxAnoCaderneta";
            this.cbxAnoCaderneta.Size = new System.Drawing.Size(95, 21);
            this.cbxAnoCaderneta.TabIndex = 36;
            // 
            // cbxTurmaCaderneta
            // 
            this.cbxTurmaCaderneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmaCaderneta.FormattingEnabled = true;
            this.cbxTurmaCaderneta.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Irmão(ã)",
            "Avô(ó)",
            "Irmão(ã)",
            "Tio(a)",
            "Primo(a)",
            "Amigo(a)"});
            this.cbxTurmaCaderneta.Location = new System.Drawing.Point(349, 39);
            this.cbxTurmaCaderneta.Name = "cbxTurmaCaderneta";
            this.cbxTurmaCaderneta.Size = new System.Drawing.Size(126, 21);
            this.cbxTurmaCaderneta.TabIndex = 38;
            // 
            // cbxOrientadorCaderneta
            // 
            this.cbxOrientadorCaderneta.DataSource = this.orientadorBindingSource;
            this.cbxOrientadorCaderneta.DisplayMember = "Nome";
            this.cbxOrientadorCaderneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrientadorCaderneta.FormattingEnabled = true;
            this.cbxOrientadorCaderneta.Location = new System.Drawing.Point(15, 97);
            this.cbxOrientadorCaderneta.Name = "cbxOrientadorCaderneta";
            this.cbxOrientadorCaderneta.Size = new System.Drawing.Size(304, 21);
            this.cbxOrientadorCaderneta.TabIndex = 37;
            this.cbxOrientadorCaderneta.ValueMember = "OrientadorID";
            // 
            // orientadorBindingSource
            // 
            this.orientadorBindingSource.DataSource = typeof(EscolaSis.Model.Orientador);
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
            this.label26.Location = new System.Drawing.Point(346, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Tuma";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Orientador";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(338, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancelar";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(446, 231);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelecCaderneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecCaderneta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caderneta Escolar";
            this.Load += new System.EventHandler(this.SelecCaderneta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orientadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAnoCaderneta;
        private System.Windows.Forms.ComboBox cbxTurmaCaderneta;
        private System.Windows.Forms.ComboBox cbxOrientadorCaderneta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbxMesCaderneta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.BindingSource orientadorBindingSource;
    }
}