using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.CarneMensalidades
{
    public partial class SelecaoDados : Form
    {
        private string AlunoIDSelec { get; set; }
        private string MensalidadeIDSelec { get; set; }
        private string AnoSelec { get; set; }

        public SelecaoDados(string AlunoID, string AlunoNome, string AnoSelecionado, string MensalidadeID, string NomeMensalidade)
        {
            InitializeComponent();
            Model.EscolaDados escola = new Model.EscolaDados();
            ckbConsederDesconto.Enabled = (escola.TaxaDesconto > 0);
            ckbCobrarJurosMulta.Enabled = (escola.TaxaMulta + escola.TaxaJuros > 0);
            ckbConsederDesconto.Checked = (escola.TaxaDesconto > 0);
            ckbCobrarJurosMulta.Checked = (escola.TaxaMulta + escola.TaxaJuros > 0);
            txbNomeAlunoMensal.Text = AlunoNome;
            txbMensalSelec.Text = NomeMensalidade;
            txbAnoSelec.Text = AnoSelecionado;

            AlunoIDSelec = AlunoID;
            MensalidadeIDSelec = MensalidadeID;
            AnoSelec = AnoSelecionado;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Form childForm = new CarneMensal
                ( AlunoIDSelec, MensalidadeIDSelec, AnoSelec, this.ckbConsederDesconto.Checked,
                this.ckbCobrarJurosMulta.Checked, this.txbObserv.Text);
            childForm.ShowDialog();
            Close();
        }
    }
}
