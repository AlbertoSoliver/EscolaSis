using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Responsavel
{
    public partial class ResponsavelNovo : Form
    {
        public ResponsavelNovo()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Model.Responsavel resposavel = new Model.Responsavel();
            resposavel.Nome = txbNomeTutor.Text;
            if (txbDataNascim.CustomFormat.Trim() != "") resposavel.DataNascimento = txbDataNascim.Value;
            resposavel.RG = txbNumRG.Text;
            resposavel.CPF = txbCPF.Text;
            resposavel.Sexo = rbtMasc.Checked ? "M" : "F";
            resposavel.Endereco = txbEndereco.Text;
            resposavel.Bairro = txbBairro.Text;
            resposavel.Cidade = txbCidade.Text;
            resposavel.CEP = txbCEP.Text;
            resposavel.Telefone = txbTelefone.Text;

            try
            {
                resposavel.SalvarResponsavel("I");

                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbDataNascim_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNascim.CustomFormat = " ";
            }
        }

        private void txbDataNascim_ValueChanged(object sender, EventArgs e)
        {
            txbDataNascim.CustomFormat = "dd/MM/yyyy";
        }
    }
}
