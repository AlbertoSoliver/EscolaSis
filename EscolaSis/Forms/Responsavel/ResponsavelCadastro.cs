using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaSis.Forms.Responsavel
{
    public partial class ResponsavelCadastro : Form
    {
        public ResponsavelCadastro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
        }
        private void txbValorMens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
        }

        private void btnNovoResp_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNovaMatric_Click(object sender, EventArgs e)
        {

        }

        private void FormAlunosCadastro_Load(object sender, EventArgs e)
        {

        }

        private void itmParcela_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoResp_Click(object sender, EventArgs e)
        {
        }

        private void btnNovaMatric_Click_1(object sender, EventArgs e)
        {
        }

        private void btnNovoAluno_Click_1(object sender, EventArgs e)
        {
            Form childForm = new ResponsavelNovo();
            childForm.ShowDialog();
            lbxListaResponsavel.DataSource = Model.Responsavel.ListaRespPesquisa(txbPesquisarTutor.Text);
        }

        private void txbPesquisarTutor_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lbxListaResponsavel.DataSource = Model.Responsavel.ListaRespPesquisa(txbPesquisarTutor.Text);
            this.Cursor = Cursors.Default;
        }

        private void lbxListaResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Responsavel responsavel = new Model.Responsavel();

            responsavel.DadosResponsavel(Convert.ToInt16("0" + Convert.ToString(lbxListaResponsavel.SelectedValue)));
            txbCodigoCadastro.Text = responsavel.TutorID.ToString();
            txbNomeTutor.Text = responsavel.Nome;
            if (responsavel.DataNascimento.Year > 1900)
            {
                txbDataNascim.CustomFormat = "dd/MM/yyyy";
                txbDataNascim.Value = responsavel.DataNascimento;
            }
            else
            {
                txbDataNascim.CustomFormat = " ";
            }
            txbNumRG.Text = responsavel.RG;
            txbCPF.Text = responsavel.CPF;
            rbtMasc.Checked = (responsavel.Sexo == "M");
            rbtFemin.Checked = !rbtMasc.Checked;
            txbEndereco.Text = responsavel.Endereco;
            txbBairro.Text = responsavel.Bairro;
            txbCidade.Text = responsavel.Cidade;
            txbCEP.Text = responsavel.CEP;
            txbTelefone.Text = responsavel.Telefone;
            txbNomeRespAluno.Text = responsavel.Nome;

            dgvAlunosDoTutor.DataSource = Model.Responsavel.ListaAlunosDoTutor(responsavel.TutorID);
        }

        private void txbDataNascim_ValueChanged(object sender, EventArgs e)
        {
            txbDataNascim.CustomFormat = "dd/MM/yyyy";
        }

        private void txbDataNascim_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNascim.CustomFormat = " ";
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txbCodigoCadastro.Text != "")
            {

                Model.Responsavel responsavel = new Model.Responsavel();
                responsavel.TutorID = Convert.ToInt16(txbCodigoCadastro.Text);
                responsavel.Nome = txbNomeTutor.Text;
                if (txbDataNascim.CustomFormat.Trim() != "") responsavel.DataNascimento = txbDataNascim.Value;
                responsavel.RG = txbNumRG.Text;
                responsavel.CPF = txbCPF.Text;
                responsavel.Sexo = rbtMasc.Checked ? "M" : "F";
                responsavel.Endereco = txbEndereco.Text;
                responsavel.Bairro = txbBairro.Text;
                responsavel.Cidade = txbCidade.Text;
                responsavel.CEP = txbCEP.Text;
                responsavel.Telefone = txbTelefone.Text;

                try
                {
                    responsavel.SalvarResponsavel("U");

                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Resposável para gravar os dados.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluirResposavel_Click(object sender, EventArgs e)
        {
            if (txbCodigoCadastro.Text != "")
            {
                DialogResult dlr = MessageBox.Show("Confirma a exclusão deste Resposável", "EscolaSis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    Model.Responsavel resposavel = new Model.Responsavel();
                    resposavel.TutorID = Convert.ToInt16(txbCodigoCadastro.Text);

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        resposavel.DeletarResponsavel();
                        lbxListaResponsavel.DataSource = Model.Responsavel.ListaRespPesquisa(txbPesquisarTutor.Text);
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Resposável excluído com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um Responsável para excluir.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
