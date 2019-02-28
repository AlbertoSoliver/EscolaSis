﻿using System;
using System.IO;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class AlunoNovo : Form
    {
        public AlunoNovo()
        {
            InitializeComponent();
        }

        private void pxbFoto_Click(object sender, EventArgs e)
        {
            mnuFoto.Show(Cursor.Position);
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

            }
        }

        private void mnuLimparFoto_Click(object sender, EventArgs e)
        {
            pbxFoto.Image = null;
        }

        private void txbDataNascim_ValueChanged(object sender, EventArgs e)
        {
            txbDataNascim.CustomFormat = "dd/MM/yyyy";
            txbIdade.Text = Model.Aluno.CalculaIdade(txbDataNascim.Value).ToString();
        }

        private void txbDataNascim_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNascim.CustomFormat = " ";
                txbIdade.Text = "";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.Aluno alunoNovo = new Model.Aluno();
            alunoNovo.Nome = txbNomeAluno.Text;
            if (txbDataNascim.CustomFormat.Trim() != "") alunoNovo.DataNascim = Convert.ToDateTime(txbDataNascim.Text);
            alunoNovo.RG = txbNumRG.Text;
            alunoNovo.CPF = txbCPF.Text;
            alunoNovo.Sexo = rbtMasc.Checked ? "M" : "F";
            alunoNovo.Endereco = txbEndereco.Text;
            alunoNovo.Bairro = txbBairro.Text;
            alunoNovo.Cidade = txbCidade.Text;
            alunoNovo.CEP = txbCEP.Text;
            alunoNovo.Telefone = txbTelefone.Text;

            try
            {
                alunoNovo.SalvarAluno("I");

                if (pbxFoto.Image != null)
                {
                    pbxFoto.Image.Save(@"Fotos\Aluno" + Model.Aluno.UltimoAlunoIDCriado() + ".jpg");
                }
                MessageBox.Show("Dados gravados com sucesso!", "EscolaSIs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSIs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
