namespace EscolaSis
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadernetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeParcelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobretoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.tutoresToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.secretariaToolStripMenuItem,
            this.escolaToolStripMenuItem,
            this.matrículasToolStripMenuItem,
            this.SobretoolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(855, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.alunoToolStripMenuItem.Text = "&Alunos";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // tutoresToolStripMenuItem
            // 
            this.tutoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tutoresToolStripMenuItem.Image")));
            this.tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            this.tutoresToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.tutoresToolStripMenuItem.Text = "&Responsáveis";
            this.tutoresToolStripMenuItem.Click += new System.EventHandler(this.tutoresToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("professoresToolStripMenuItem.Image")));
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.professoresToolStripMenuItem.Text = "&Orientadores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.secretariaToolStripMenuItem.Image = global::EscolaSis.Properties.Resources.Secretaria24x24;
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.secretariaToolStripMenuItem.Text = "&Secretaria";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // escolaToolStripMenuItem
            // 
            this.escolaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("escolaToolStripMenuItem.Image")));
            this.escolaToolStripMenuItem.Name = "escolaToolStripMenuItem";
            this.escolaToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.escolaToolStripMenuItem.Text = "&Escola";
            this.escolaToolStripMenuItem.Click += new System.EventHandler(this.escolaToolStripMenuItem_Click);
            // 
            // matrículasToolStripMenuItem
            // 
            this.matrículasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadernetaToolStripMenuItem,
            this.listaDeAlunosToolStripMenuItem,
            this.listaDeParcelasToolStripMenuItem});
            this.matrículasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("matrículasToolStripMenuItem.Image")));
            this.matrículasToolStripMenuItem.Name = "matrículasToolStripMenuItem";
            this.matrículasToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.matrículasToolStripMenuItem.Text = "&Rela&tórios";
            // 
            // cadernetaToolStripMenuItem
            // 
            this.cadernetaToolStripMenuItem.Name = "cadernetaToolStripMenuItem";
            this.cadernetaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cadernetaToolStripMenuItem.Text = "Caderneta";
            this.cadernetaToolStripMenuItem.Click += new System.EventHandler(this.cadernetaToolStripMenuItem_Click);
            // 
            // listaDeAlunosToolStripMenuItem
            // 
            this.listaDeAlunosToolStripMenuItem.Name = "listaDeAlunosToolStripMenuItem";
            this.listaDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.listaDeAlunosToolStripMenuItem.Text = "Lista de Alunos";
            this.listaDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.listaDeAlunosToolStripMenuItem_Click);
            // 
            // listaDeParcelasToolStripMenuItem
            // 
            this.listaDeParcelasToolStripMenuItem.Name = "listaDeParcelasToolStripMenuItem";
            this.listaDeParcelasToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.listaDeParcelasToolStripMenuItem.Text = "Lista de Parcelas";
            this.listaDeParcelasToolStripMenuItem.Click += new System.EventHandler(this.listaDeParcelasToolStripMenuItem_Click);
            // 
            // SobretoolStripMenuItem
            // 
            this.SobretoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SobretoolStripMenuItem.Image")));
            this.SobretoolStripMenuItem.Name = "SobretoolStripMenuItem";
            this.SobretoolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.SobretoolStripMenuItem.Text = "So&bre";
            this.SobretoolStripMenuItem.Click += new System.EventHandler(this.SobretoolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EscolaSis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadernetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeParcelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobretoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
    }
}



