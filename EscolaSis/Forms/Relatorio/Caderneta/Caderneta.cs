using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.Caderneta
{
    public partial class Caderneta : Form
    {
        public Caderneta(string anoRef, string turmaRef, string orientadorID, string mesEanoRef)
        {
            InitializeComponent();
            var dadosCaderneta = Model.Matricula.ListaAlunosPorTurma(orientadorID, anoRef, turmaRef);
            ReportDataSource vsl = new ReportDataSource("DataSet1", dadosCaderneta);
            ReportParameter[] prm = new ReportParameter[1];
            prm[0] = new ReportParameter("PeriodoRef", mesEanoRef, true);

            reportViewer1.LocalReport.SetParameters(prm);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(vsl);
            this.reportViewer1.RefreshReport();
        }

        private void Caderneta_Load(object sender, EventArgs e)
        {


        }
    }
}
