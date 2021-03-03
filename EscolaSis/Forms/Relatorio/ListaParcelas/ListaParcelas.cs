using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.ListaParcelas
{
    public partial class ListaParcelas : Form
    {
        public ListaParcelas(string AnoRef, string SituacRef, string AlunoRef)
        {
            InitializeComponent();

            var CodSituacao = "%";
            if (SituacRef == "Apenas Pagas") CodSituacao = "Pago";
            if (SituacRef == "Apenas Em Aberto") CodSituacao = "Em Aberto";

            var escola = new Model.EscolaDados();
            var aluno = (new Model.Aluno());
            aluno.DadosAluno(System.Convert.ToInt16(AlunoRef));
            var dadosListaParcelas = Model.Mensalidade.ListaParcelas(
                AlunoRef == "0" ? "%" : AlunoRef,
                AnoRef,
                CodSituacao);
            ReportDataSource vsl = new ReportDataSource("DataSet1", dadosListaParcelas);

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("AlunoSelec", AlunoRef == "0" ? "Todos" : aluno.Nome, true);
            prm[1] = new ReportParameter("SituacMensal", SituacRef, true);
            prm[2] = new ReportParameter("NomeEscola", escola.NomeEscola, true);

            reportViewer1.LocalReport.SetParameters(prm);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(vsl);
            this.reportViewer1.RefreshReport();
        }

        private void ListaParcelas_Load(object sender, EventArgs e)
        {

        }
    }
}
