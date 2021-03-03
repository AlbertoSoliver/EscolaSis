using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaSis.Forms.Turma
{
    public partial class TurmaLista : Form
    {
        public TurmaLista()
        {
            InitializeComponent();
        }

        private void TurmaLista_Load(object sender, System.EventArgs e)
        {
            this.txbAno.Text = DateTime.Today.Year.ToString();
            this.cbxCurso.DataSource = Model.Curso.ListaCursos();
            CarregarListaTurma();
        }

        private void CarregarListaTurma()
        {
            this.Cursor = Cursors.WaitCursor;
            List<Model.Turma> lst = new List<Model.Turma>();
            dgvTurmas.AutoGenerateColumns = false;
            if (cbxCurso.Items.Count > 0) lst = Model.Turma.ListaTurma(this.cbxCurso.SelectedValue.ToString(), (this.txbAno.Text.Length > 0) ? this.txbAno.Text : "%");
            dgvTurmas.DataSource = lst;
            this.Cursor = Cursors.Default;
        }


        private void cbxCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarListaTurma();
        }

        private void txbAno_TextChanged(object sender, EventArgs e)
        {
            CarregarListaTurma();
        }

        private void dgvTurmas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurmas.Columns[e.ColumnIndex].Name == "ExcluirTurm" && e.RowIndex >= 0)
            {
                DialogResult dlr = MessageBox.Show("Confirma a exclusão desta Turma", "EscolaSis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Model.Turma.DeletarCurso(Convert.ToInt32(dgvTurmas.Rows[e.RowIndex].Cells[0].Value));
                        CarregarListaTurma();
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (dgvTurmas.Columns[e.ColumnIndex].Name == "AlterarTurma" && e.RowIndex >= 0)
            {
                Form childForm = new ManterCurso("ALTERAR TURMA", Convert.ToInt32(dgvTurmas.Rows[e.RowIndex].Cells[0].Value));
                childForm.ShowDialog();
                CarregarListaTurma();
            }
            if (dgvTurmas.Columns[e.ColumnIndex].Name == "Disciplinas" && e.RowIndex >= 0)
            {
                Form childForm = new GradeCurrCurso(Convert.ToInt32(dgvTurmas.Rows[e.RowIndex].Cells[0].Value), dgvTurmas.Rows[e.RowIndex].Cells["Titulo"].Value.ToString(), dgvTurmas.Rows[e.RowIndex].Cells["CargaHoraria"].Value.ToString());
                childForm.ShowDialog();
                CarregarListaTurma();
            }
        }
    }
}
