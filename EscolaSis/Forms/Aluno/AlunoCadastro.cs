using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.IO;

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

            List<Model.Aluno> lst = Model.Aluno.ListarAlunosPesquisa(txbBuscarAluno.Text);

            lbxListaAlunosBuscar.Items.Clear();

            foreach (Model.Aluno item in lst)
            {
                lbxListaAlunosBuscar.Items.Add(item.AlunoID.ToString().PadRight(5, ' ') + " " + item.Nome);
            }
        }

        private void lbxListaAlunosBuscar_Click(object sender, EventArgs e)
        {
            Model.Aluno aluno = new Model.Aluno();
            aluno.DadosAluno(Convert.ToInt32(lbxListaAlunosBuscar.Text.Substring(0, 5).Trim()));

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
        }

        private void pbxFoto_Click(object sender, EventArgs e)
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
    }
}
