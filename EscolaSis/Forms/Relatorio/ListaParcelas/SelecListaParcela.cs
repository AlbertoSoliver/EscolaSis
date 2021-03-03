using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.ListaParcelas
{
    public partial class SelecListaParcela : Form
    {
        public SelecListaParcela()
        {
            InitializeComponent();
        }

        private void SelecListaParcela_Load(object sender, System.EventArgs e)
        {
            this.cbxAno.DataSource = Model.Tools.ListaAnoMensaliade();
            this.cbxSituacMensaliade.Text = "Qualquer Situação";
            this.cbxAluno.DataSource = Model.Aluno.ListarAlunosPesquisa("%", true);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            Form childForm = new ListaParcelas(
                cbxAno.SelectedItem.ToString(),
                cbxSituacMensaliade.SelectedItem.ToString(),
                cbxAluno.SelectedValue.ToString());
            childForm.ShowDialog();
            Close();
        }
    }
}
