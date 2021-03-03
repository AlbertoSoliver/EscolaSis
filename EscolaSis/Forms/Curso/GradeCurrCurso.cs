using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Curso
{
    public partial class GradeCurrCurso : Form
    {
        private int _CURSOID { get; set; }
        public string _CURSONOME { get; set; }
        public string _CURSOCH { get; set; }
        public GradeCurrCurso(int CursoID, string NomeCurso, string CHCurso)
        {
            InitializeComponent();
            _CURSOID = CursoID; _CURSONOME = NomeCurso; _CURSOCH = CHCurso+" h.a.";
            dgvGradeCurric.AutoGenerateColumns = false;
            CarregarGradeCurso();
        }
        private void CarregarGradeCurso()
        {
            this.Cursor = Cursors.WaitCursor;
            var gradeCurric = Model.CursoGradeCurric.ListaGrade(_CURSOID);
            lblCursoNome.Text = _CURSONOME; lblCargaHrCurso.Text = _CURSOCH;
            lblCargaHrCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblCHLanc.Text = Model.CursoGradeCurric.TotalCHLancada(_CURSOID).ToString() + " h.a.  Lançadas";
            lblCHLanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            dgvGradeCurric.DataSource = gradeCurric;
            this.Cursor = Cursors.Default;
        }

        private void ToolStripButton4_Click(object sender, System.EventArgs e)
        {

        }

        private void DgvGradeCurric_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form childForm = new GradeCurricManter(lblCursoNome.Text, 0, _CURSOID);
            childForm.ShowDialog();
            CarregarGradeCurso();
        }

        private void dgvGradeCurric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGradeCurric_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGradeCurric.Columns[e.ColumnIndex].Name == "ExcluirDiscipl" && e.RowIndex >= 0)
            {
                DialogResult dlr = MessageBox.Show("Confirma a exclusão deste Disciplina", "EscolaSis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Model.CursoGradeCurric.DeletarGradeCurric(Convert.ToInt32(dgvGradeCurric.Rows[e.RowIndex].Cells[0].Value));
                        CarregarGradeCurso();
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            if (dgvGradeCurric.Columns[e.ColumnIndex].Name == "AlterarDiscipl" && e.RowIndex >= 0)
            {
                Form childForm = new GradeCurricManter(lblCursoNome.Text, Convert.ToInt32(dgvGradeCurric.Rows[e.RowIndex].Cells[0].Value), _CURSOID);
                childForm.ShowDialog();
                CarregarGradeCurso();
            }
        }
    }
}
