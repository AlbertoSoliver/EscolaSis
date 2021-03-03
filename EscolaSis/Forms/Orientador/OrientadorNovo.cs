using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Orientador
{
    public partial class OrientadorNovo : Form
    {
        public OrientadorNovo(string OrientadorID)
        {
            InitializeComponent();
        }

        private void txbDataNasc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNasc.CustomFormat = " ";
            }
        }

        private void txbDataAdmis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataAdmis.CustomFormat = " ";
            }
        }

        private void txbDataAfast_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataAfast.CustomFormat = " ";
            }
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            Model.Orientador orientador = new Model.Orientador();
            orientador.Nome = txbNomeOrientador.Text;
            orientador.Pseudonimo = txbApelido.Text;
            if (txbDataNasc.CustomFormat.Trim() != "") orientador.DataNascimento = txbDataNasc.Value;
            orientador.Formacao = txbFomracaoOrient.Text;
            if (txbDataAdmis.CustomFormat.Trim() != "") orientador.DataAdmissao = txbDataAdmis.Value;
            orientador.Funcao = txbCargo.Text;
            if (txbDataAfast.CustomFormat.Trim() != "") orientador.DataAfastam = txbDataAfast.Value;
            orientador.RG = txbNumRG.Text;
            orientador.CPF = txbCPF.Text;
            orientador.Sexo = rbtMasc.Checked ? "M" : "F";
            orientador.Endereco = txbEndereco.Text;
            orientador.Bairro = txbBairro.Text;
            orientador.Cidade = txbCidade.Text;
            orientador.CEP = txbCEP.Text;
            orientador.Telefone = txbTelefone.Text;

            try
            {
                orientador.SalvarOrientador("I");

                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txbDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txbDataNasc.CustomFormat = "dd/MM/yyyy";
        }

        private void txbDataAdmis_ValueChanged(object sender, EventArgs e)
        {
            txbDataAdmis.CustomFormat = "dd/MM/yyyy";
        }

        private void txbDataAfast_ValueChanged(object sender, EventArgs e)
        {
            txbDataAfast.CustomFormat = "dd/MM/yyyy";
        }
    }
}
