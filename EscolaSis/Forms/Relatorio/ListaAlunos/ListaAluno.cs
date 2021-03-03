using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.ListaAlunos
{
    public partial class ListaAluno : Form
    {
        public ListaAluno(string AnoRef, string TurmaRef, string OrientadorRef)
        {
            InitializeComponent();
            var escola = new Model.EscolaDados();
            var orientador = (new Model.Orientador());
            orientador.DadosOrientador(System.Convert.ToInt16(OrientadorRef));
            var dadosListaAlunos = Model.Matricula.ListaAlunosPorTurma(
                OrientadorRef == "0" ? "%" : OrientadorRef,
                AnoRef,
                TurmaRef == "Todas as Turmas" ? "%" : TurmaRef);
            ReportDataSource vsl = new ReportDataSource("DataSet1", dadosListaAlunos);

            ReportParameter[] prm = new ReportParameter[4];
            prm[0] = new ReportParameter("AnoSelec", AnoRef, true);
            prm[1] = new ReportParameter("TurmaSelec", TurmaRef, true);
            prm[2] = new ReportParameter("OrientadorSelec", OrientadorRef == "0" ? "Todos" : orientador.Nome, true);
            prm[3] = new ReportParameter("NomeEscola", escola.NomeEscola, true);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(vsl);
            reportViewer1.LocalReport.SetParameters(prm);


            this.reportViewer1.RefreshReport();
        }

        private void ListaAluno_Load(object sender, System.EventArgs e)
        {

        }
    }
}
