using System.Windows.Forms;

namespace EscolaSis.Forms.Escola
{
    public partial class Escola : Form
    {
        public Escola()
        {
            InitializeComponent();

            Model.EscolaDados escola = new Model.EscolaDados();

            this.lblNomeEscola.Text = escola.NomeEscola;
            this.lblRazaoSocial.Text = escola.RazaoSocial;
            this.lblCNPJ.Text = escola.CNPJ;
            this.lblEndereco.Text = escola.Endereco + ", " + escola.Bairro;
            this.lblCidade.Text = escola.Cidade;
            this.lblCEP.Text = escola.CEP;
            this.txbTxDesconto.Value = escola.TaxaDesconto;
            this.txbTxMulta.Value = escola.TaxaMulta;
            this.txbTxJuros.Value = escola.TaxaJuros;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            Model.EscolaDados escola = new Model.EscolaDados
            {
                TaxaDesconto = txbTxDesconto.Value,
                TaxaMulta = txbTxMulta.Value,
                TaxaJuros = txbTxJuros.Value
            };
            try
            {
                escola.SalvarEscola();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void label37_Click(object sender, System.EventArgs e)
        {

        }

        private void txbValor_ValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}
