using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaSis
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Aluno.AlunoCadastro();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Responsavel.ResponsavelCadastro();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Orientador.OrientadorCadastro();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void SobretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Sobre.AboutBox();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void escolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Escola.Escola();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void cadernetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Relatorio.Caderneta.SelecCaderneta();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listaDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Relatorio.ListaAlunos.SelecListaAluno();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listaDeParcelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Relatorio.ListaParcelas.SelecListaParcela();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Curso.CursoLista();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Forms.Turma.TurmaLista();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
