using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio
{
    public partial class Carteirinha : Form
    {

        public Carteirinha(ReportParameter[] reportparam)
        {
            InitializeComponent();
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.SetParameters(reportparam);
            reportViewer1.RefreshReport();
        }

        private void Carteirinha_Load(object sender, System.EventArgs e)
        {

        }
    }

}
