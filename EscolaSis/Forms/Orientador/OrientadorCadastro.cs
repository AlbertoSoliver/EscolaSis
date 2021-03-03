using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaSis.Forms.Orientador
{
    public partial class OrientadorCadastro : Form
    {
        public OrientadorCadastro()
        {
            InitializeComponent();
        }

        private void OrientadorCadastro_Load(object sender, EventArgs e)
        {
            cbxAnoLetivo.DataSource = Model.Tools.ListaAnoLetivo();
            cbxTurma.Items.Add("--Todas--");
            foreach (string item in Model.Tools.ListaTurma())
            {
                cbxTurma.Items.Add(item);
            }
            cbxTurma.SelectedIndex = 0;
        }

        private void btnNovoAluno_Click_1(object sender, EventArgs e)
        {
            Form childForm = new OrientadorNovo(txbCodCadastro.Text);
            childForm.ShowDialog();
            lbxListaOrient.DataSource = Model.Orientador.ListaOrientadores(txbPesquisarOrientador.Text);
        }

        private void txbDataNasc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataAdmis.CustomFormat = " ";
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

        private void txbPesquisarOrientador_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Model.Orientador> lst = Model.Orientador.ListaOrientadores(txbPesquisarOrientador.Text);
            lbxListaOrient.DataSource = lst;
            this.Cursor = Cursors.Default;
        }

        private void listarAlunosTurma()
        {
            string turma = cbxTurma.SelectedIndex == 0 ? "%" : Convert.ToString(cbxTurma.SelectedItem);
            dgvAlunosTurma.DataSource = Model.Matricula.ListaAlunosPorTurma(Convert.ToString(lbxListaOrient.SelectedValue), Convert.ToString(cbxAnoLetivo.SelectedValue), turma);
        }

        private void lbxListaOrient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Orientador orientador = new Model.Orientador();

            orientador.DadosOrientador(Convert.ToInt16("0" + Convert.ToString(lbxListaOrient.SelectedValue)));
            txbCodCadastro.Text = orientador.OrientadorID.ToString();
            txbNomeOrientador.Text = orientador.Nome;
            txbApelido.Text = orientador.Pseudonimo;
            if (orientador.DataNascimento.Year > 1900)
            {
                txbDataNasc.CustomFormat = "dd/MM/yyyy";
                txbDataNasc.Value = orientador.DataNascimento;
            }
            else
            {
                txbDataNasc.CustomFormat = " ";
            }
            txbFomracaoOrient.Text = orientador.Formacao;
            if (orientador.DataAdmissao.Year > 1900)
            {
                txbDataAdmis.CustomFormat = "dd/MM/yyyy";
                txbDataAdmis.Value = orientador.DataAdmissao;
            }
            else
            {
                txbDataAdmis.CustomFormat = " ";
            }
            txbCargo.Text = orientador.Funcao;
            if (orientador.DataAfastam.Year > 1900)
            {
                txbDataAfast.CustomFormat = "dd/MM/yyyy";
                txbDataAfast.Value = orientador.DataAfastam;
            }
            else
            {
                txbDataAfast.CustomFormat = " ";
            }
            txbNumRG.Text = orientador.RG;
            txbCPF.Text = orientador.CPF;
            rbtMasc.Checked = (orientador.Sexo == "M");
            rbtFemin.Checked = !rbtMasc.Checked;
            txbEndereco.Text = orientador.Endereco;
            txbBairro.Text = orientador.Bairro;
            txbCidade.Text = orientador.Cidade;
            txbCEP.Text = orientador.CEP;
            txbTelefone.Text = orientador.Telefone;
            txbNomeOrientTurma.Text = orientador.Nome;
            txbCargoOrient.Text = orientador.Funcao;

            listarAlunosTurma();

        }

        private void cbxAnoLetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarAlunosTurma();
        }

        private void cbxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarAlunosTurma();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txbCodCadastro.Text != "")
            {

                Model.Orientador orientador = new Model.Orientador();
                orientador.OrientadorID = Convert.ToInt16(txbCodCadastro.Text);
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
                    orientador.SalvarOrientador("U");

                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Orientador para gravar os dados.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluirOrientador_Click(object sender, EventArgs e)
        {
            if (txbCodCadastro.Text != "")
            {
                DialogResult dlr = MessageBox.Show("Confirma a exclusão deste Orientador", "EscolaSis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    Model.Orientador orientador = new Model.Orientador();
                    orientador.OrientadorID = Convert.ToInt16(txbCodCadastro.Text);

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        orientador.DeletarOrientador();
                        lbxListaOrient.DataSource = Model.Orientador.ListaOrientadores(txbPesquisarOrientador.Text);
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Orientador excluído com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Selecione um Orientador para excluir.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txbFomracaoOrient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
