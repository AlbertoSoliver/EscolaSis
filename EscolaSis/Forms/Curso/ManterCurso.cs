using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Curso
{
    public partial class ManterCurso : Form
    {
        private string _TipoOperacao { get; set; }
        private int _CursoID { get; set; }
        public ManterCurso(string TipoOpercao, int CursoID)
        {
            _TipoOperacao = TipoOpercao;
            _CursoID = CursoID;
            InitializeComponent();
            if (_CursoID != 0)
            {
                Model.Curso curso = new Model.Curso();
                curso.DadosCurso(_CursoID);
                txbCodigoCurso.Text = curso.Codigo;
                txbNomeCurso.Text = curso.Titulo;
                txbDescrCurso.Text = curso.Descricao;
                txbCargaHoraria.Text = curso.CargaHoraria.ToString();
            }            
        }

        private void ManterCurso_Load(object sender, EventArgs e)
        {
            gbxPrincipal.Text = _TipoOperacao;
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (txbCodigoCurso.Text == "" || txbNomeCurso.Text == "")
            {
                MessageBox.Show("Os campos Código e Título do Curso são obrigatórios.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCodigoCurso.Focus();
                return;
            }

            Model.Curso curso = new Model.Curso();
            curso.CursoID = _CursoID;
            curso.Codigo = txbCodigoCurso.Text;
            curso.Titulo = txbNomeCurso.Text;
            curso.Descricao = txbDescrCurso.Text;
            curso.CargaHoraria = Convert.ToInt32(txbCargaHoraria.Text);

            try
            {
                curso.SalvarCurso(_CursoID == 0 ? "I" : "U");
                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbCargaHoraria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
