using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace EscolaSis.Forms.Aluno
{
    public partial class AlunoCadastro : Form
    {
        public AlunoCadastro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
        }
        private void txbValorMens_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            Form childForm = new AlunoNovo();
            childForm.ShowDialog();
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
            Form childForm = new MensalidadeManter();
            childForm.ShowDialog();
        }

        private void btnNovoResp_Click(object sender, EventArgs e)
        {
            Form childForm = new ResponsavelNovo();
            childForm.ShowDialog();
        }

        private void btnNovaMatric_Click_1(object sender, EventArgs e)
        {
            Form childForm = new MatricNova();
            childForm.ShowDialog();
        }

        private void itmParcelamento_Click(object sender, EventArgs e)
        {
            Form childForm = new MensalidadesPeriodo();
            childForm.ShowDialog();
        }

        private void txbBuscarAluno_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void lbxListaAlunosBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txbDataNascimAluno_ValueChanged(object sender, EventArgs e)
        {
            txbDataNascimAluno.CustomFormat = "dd/MM/yyyy";
        }

        private void txbDataNascimAluno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNascimAluno.CustomFormat = " ";
                txbIdadeAluno.Text = "";
            }
        }

        private void mnuMudarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists("Fotos"))
                {
                    Directory.CreateDirectory("Fotos");
                }

                pbxFoto.ImageLocation = file.FileName;
                pbxFoto.Load();
                if (File.Exists(@"Fotos\Aluno" + txbAlunoID.Text + ".jpg"))
                    File.Delete(@"Fotos\Aluno" + txbAlunoID.Text + ".jpg");
                pbxFoto.Image.Save(@"Fotos\Aluno" + txbAlunoID.Text + ".jpg");

            }
        }

        private void mnuLimparFoto_Click(object sender, EventArgs e)
        {
            pbxFoto.Image = null;
        }

        private void pbxFoto_Click_1(object sender, EventArgs e)
        {
            mnuFoto.Show(Cursor.Position);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaAlunoBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaAlunoBuscar_SelectionChanged(object sender, EventArgs e)
        {
            Model.Aluno aluno = new Model.Aluno();

            int alunoID;
            if (dgvListaAlunoBuscar.SelectedRows.Count>0) alunoID = (int)dgvListaAlunoBuscar.SelectedRows[0].Cells[0].Value;
            else alunoID = 0;

            aluno.DadosAluno(alunoID);
            List<Model.Responsavel> listaResponsaveis = Model.Aluno.ListarResponsaveisAluno(alunoID);
            List<Model.Matricula> listaMatriculas = Model.Aluno.ListarMatriculasAluno(alunoID);
            List<Model.Mensalidade> listaMensalidades = Model.Aluno.ListarMensalidadesAluno(alunoID);

            // dados do aluno
            txbAlunoID.Text = aluno.AlunoID.ToString();
            txbNumMatricAluno.Text = aluno.NumMatricula;
            txbAlunoID.Text = aluno.AlunoID.ToString();
            txbNomeAluno.Text = aluno.Nome;
            txbIdadeAluno.Text = "";
            if (aluno.DataNascim > txbDataNascimAluno.MinDate)
            {
                txbDataNascimAluno.CustomFormat = "dd/MM/yyyy";
                txbDataNascimAluno.Value = aluno.DataNascim;
                txbIdadeAluno.Text = aluno.Idade.ToString();
            }
            txbNumRGAluno.Text = aluno.RG;
            txbCPFAluno.Text = aluno.CPF;
            rbtMasc.Checked = (aluno.Sexo == "M");
            txbEnderecoAluno.Text = aluno.Endereco;
            txbBairroAluno.Text = aluno.Bairro;
            txbCidadeAluno.Text = aluno.Cidade;
            txbCEPAluno.Text = aluno.Telefone;
            if (File.Exists(@"Fotos\Aluno" + aluno.AlunoID.ToString() + ".jpg"))
            {
                pbxFoto.ImageLocation = @"Fotos\Aluno" + aluno.AlunoID.ToString() + ".jpg";
                pbxFoto.Load();
            }

            //dados dos responsaveis
            txbNumMatricResp.Text = aluno.NumMatricula;
            txbNomeAlunoResp.Text = aluno.Nome;
            dgvAlunoResponsaveis.DataSource = listaResponsaveis;

            //dados das matrículas
            txbNumMatricMatric.Text = aluno.NumMatricula;
            txbNomeAlunoMatric.Text = aluno.Nome;
            dgvAlunoDisciplinas.DataSource = listaMatriculas;

            //dados das mensalidades
            txbNumMatricMensal.Text = aluno.NumMatricula;
            txbNomeAlunoMensal.Text = aluno.Nome;
            dgvAlunoMensalidades.DataSource = listaMensalidades;
        }

        private void dgvAlunoResponsaveis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlunoResponsaveis.SelectedRows.Count > 0)
            {
                Model.Responsavel responsavel = new Model.Responsavel();
                responsavel.DadosResponsavel((int)dgvAlunoResponsaveis.SelectedRows[0].Cells[0].Value);
                txbTutorAlunoID.Text = responsavel.TutorAlunoID.ToString();
                cbxResponsNome.Text = responsavel.Nome;
                txbTeefoneRespons.Text = responsavel.Telefone;
                cbxRelacAluno.Text = responsavel.RelacaoAluno;
                ckbPagador.Checked = (responsavel.Pagador == "S");
                ckbPodePegar.Checked = (responsavel.PodePegarEscola == "S");
            }

        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            List<Model.Aluno> lst = Model.Aluno.ListarAlunosPesquisa(txbBuscarAluno.Text);
            dgvListaAlunoBuscar.DataSource = lst;
        }
    }
}

