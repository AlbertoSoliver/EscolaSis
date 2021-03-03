using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.CarneMensalidades
{
    public partial class CarneMensal : Form
    {
        public CarneMensal(string alunoID, string mensalidadeID, string anoRef, bool ConsDeconto, bool CobrarJurosMulta, string Observ)
        {
            InitializeComponent();
            List<Model.Mensalidade.Carne> lsdDados =  Model.Mensalidade.Carne.ListaCarnes(alunoID, mensalidadeID, anoRef, ConsDeconto, CobrarJurosMulta, Observ);
            ReportDataSource vsl = new ReportDataSource("DataSet2", lsdDados);

            ReportParameter[] prm = new ReportParameter[8];
            Model.EscolaDados escola = new Model.EscolaDados();
            string instrPgto = "";
            if (ConsDeconto) instrPgto += "Conseder desconto de [desc] para pagamento até o vencimento";
            prm[0] = new ReportParameter("NomeEscola", lsdDados[0].EscolaNome, true);
            prm[1] = new ReportParameter("RazaoSocEscola", lsdDados[0].EscolaRSocial, true);
            prm[2] = new ReportParameter("CNPJEscola", lsdDados[0].EscolaCNPJ, true);
            prm[3] = new ReportParameter("EnderecoEscola", lsdDados[0].EscolaEndereco, true);
            prm[4] = new ReportParameter("AnoReferencia", anoRef, true);
            prm[5] = new ReportParameter("Observacao", Observ, true);
            prm[6] = new ReportParameter("ConsederDesconto", (ConsDeconto) ? "S" : "N", true); 
            prm[7] = new ReportParameter("AdicJurosMulta", (CobrarJurosMulta) ? "S" : "N", true); 

            reportViewer1.LocalReport.SetParameters(prm);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(vsl);

            reportViewer1.RefreshReport();
        }

        private void CarneMensal_Load(object sender, EventArgs e)
        {

        }
    }
}
