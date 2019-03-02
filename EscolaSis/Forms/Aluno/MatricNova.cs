using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class MatricNova : Form
    {
        private string _AlunoID { get; set; }
        public MatricNova(string AlunoID)
        {
            _AlunoID = AlunoID;
            InitializeComponent();
        }

        private void MatricNova_Load(object sender, System.EventArgs e)
        {
            cbxAnoLetivo.DataSource = Model.Tools.ListaAnoLetivo();
            cbxPeriodoLetivo.DataSource = Model.Tools.PeriodoLetivo.ListaPeriodoLetivo(true);
            cbxOrientador.DataSource = (new Model.Orientador()).ListaOrientadores();
            cbxResultado.DataSource = Model.Tools.ResultadoFinal.ListaResultadoFinal();
            cbxTurma.DataSource = Model.Tools.ListaTurma();

            cbxPeriodoLetivo.SelectedValue = Model.Tools.DadosEscola().PeriodoLetivoPadrao;
            cbxResultado.SelectedValue = "N";
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            if (_AlunoID != "")
            {
                if ((Convert.ToInt16("0" + cbxAnoLetivo.Text)) <= 1980 && (Convert.ToInt16("0" + cbxAnoLetivo.Text) > DateTime.Now.Year + 1))
                {
                    MessageBox.Show("Ano letivo inválido.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxAnoLetivo.Focus();
                    return;
                };

                Model.Matricula matriculaInsert = new Model.Matricula();
                matriculaInsert.AlunoID = Convert.ToUInt16(_AlunoID);
                matriculaInsert.OrientadorID = Convert.ToInt16(cbxOrientador.SelectedValue.ToString());
                matriculaInsert.AnoLetivo = cbxAnoLetivo.Text;
                matriculaInsert.Disciplina = txbDisciplianAtividade.Text;
                matriculaInsert.CodigoPeriodo = cbxPeriodoLetivo.SelectedValue.ToString();
                matriculaInsert.Turma = cbxTurma.Text;
                matriculaInsert.ResultadoFinal = cbxResultado.SelectedValue.ToString();
                matriculaInsert.RelatorioAtividade = txbRelatorio.Text;

                try
                {
                    matriculaInsert.SalvarMatriculaAluno("I");
                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Aluno para cadastrar matricula.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
