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
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadernetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeParcelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.tutoresToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.matrículasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(855, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.alunoToolStripMenuItem.Text = "&Alunos";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("professoresToolStripMenuItem.Image")));
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.professoresToolStripMenuItem.Text = "&Orientadores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // tutoresToolStripMenuItem
            // 
            this.tutoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tutoresToolStripMenuItem.Image")));
            this.tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            this.tutoresToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.tutoresToolStripMenuItem.Text = "&Responsáveis";
            this.tutoresToolStripMenuItem.Click += new System.EventHandler(this.tutoresToolStripMenuItem_Click);
            // 
            // matrículasToolStripMenuItem
            // 
            this.matrículasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadernetaToolStripMenuItem,
            this.listaDeAlunosToolStripMenuItem,
            this.listaDeParcelasToolStripMenuItem});
            this.matrículasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("matrículasToolStripMenuItem.Image")));
            this.matrículasToolStripMenuItem.Name = "matrículasToolStripMenuItem";
            this.matrículasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.matrículasToolStripMenuItem.Text = "&Rela&tórios";
            // 
            // cadernetaToolStripMenuItem
            // 
            this.cadernetaToolStripMenuItem.Name = "cadernetaToolStripMenuItem";
            this.cadernetaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cadernetaToolStripMenuItem.Text = "Caderneta";
            // 
            // listaDeAlunosToolStripMenuItem
            // 
            this.listaDeAlunosToolStripMenuItem.Name = "listaDeAlunosToolStripMenuItem";
            this.listaDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listaDeAlunosToolStripMenuItem.Text = "Lista de Alunos";
            // 
            // listaDeParcelasToolStripMenuItem
            // 
            this.listaDeParcelasToolStripMenuItem.Name = "listaDeParcelasToolStripMenuItem";
            this.listaDeParcelasToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listaDeParcelasToolStripMenuItem.Text = "Lista de Parcelas";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 454);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}



