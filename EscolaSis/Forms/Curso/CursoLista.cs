using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaSis.Forms.Curso
{
    public partial class CursoLista : Form
    {
        public CursoLista()
        {
            InitializeComponent();
        }

        private void CursoLista_Load(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            CarregarListaCurso();
        }

        private void CarregarListaCurso()
        {
            this.Cursor = Cursors.WaitCursor;
            List<Model.Curso> lst = Model.Curso.ListaCursos();
            dgvCursos.DataSource = lst;
            this.Cursor = Cursors.Default;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void DgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.Columns[e.ColumnIndex].Name == "ExcluirCurso" && e.RowIndex >= 0)
            {
                DialogResult dlr = MessageBox.Show("Confirma a exclusão deste Curso", "EscolaSis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Model.Curso.DeletarCurso(Convert.ToInt32(dgvCursos.Rows[e.RowIndex].Cells[0].Value));
                        CarregarListaCurso();
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (dgvCursos.Columns[e.ColumnIndex].Name == "AlterarCurso" && e.RowIndex >= 0)
            {
                Form childForm = new ManterCurso("ALTERAR CURSO", Convert.ToInt32(dgvCursos.Rows[e.RowIndex].Cells[0].Value));
                childForm.ShowDialog();
                CarregarListaCurso();
            }
            if (dgvCursos.Columns[e.ColumnIndex].Name == "GradeCurso" && e.RowIndex >= 0)
            {
                Form childForm = new GradeCurrCurso(Convert.ToInt32(dgvCursos.Rows[e.RowIndex].Cells[0].Value), dgvCursos.Rows[e.RowIndex].Cells["Titulo"].Value.ToString(), dgvCursos.Rows[e.RowIndex].Cells["CargaHoraria"].Value.ToString());
                childForm.ShowDialog();
                CarregarListaCurso();
            }
        }

        private void DgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form childForm = new ManterCurso("NOVO CURSO", 0);
            childForm.ShowDialog();
            CarregarListaCurso();
        }
    }
}
