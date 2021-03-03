using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.ControleAcesso
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ckbMudarSenha.Checked)
            {
                if (txbSenha.Text == "AdminSistem")
                {
                    MessageBox.Show("Informe a nova senha de acesso ao sistema.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ckbMudarSenha.Checked = true;
                    txbNovaSenha.Focus();
                }
                else
                {
                    Model.ControleAcesso ca = new Model.ControleAcesso(txbUsuario.Text, txbSenha.Text);
                    if (ca.SenhaAutentica)
                    {
                        this.Hide();
                        Form childForm = new MDIPrincipal();
                        childForm.Show();
                    }
                    else
                    {
                        MessageBox.Show(ca.MensagemRetorno, "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                Model.ControleAcesso ca = new Model.ControleAcesso(txbUsuario.Text, txbSenha.Text);
                if (ca.SenhaAutentica || (txbSenha.Text == "AdminSistem" && txbUsuario.Text == "Admin"))
                {
                    // verifica se a senha não está em branco
                    // checa se a nova senha é igual a senha de confirmação
                    if (txbNovaSenha.Text != txbConfNovaSenha.Text || txbNovaSenha.Text == "")
                    {
                        MessageBox.Show("Senha Nova e Confirme Nova Senha devem ser iguais e diferente de vazio.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // atualiza senha no banco de dados
                    try
                    {
                        ca.MudarSenha(txbUsuario.Text, txbNovaSenha.Text);
                        MessageBox.Show("Senha alterada com sucesso!.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbSenha.Text = "";
                        txbNovaSenha.Text = "";
                        txbConfNovaSenha.Text = "";
                        ckbMudarSenha.Checked = false;
                        txbSenha.Focus();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Informe usuário e senha cadastrados ou Usuário e Senha Padrão.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void ckbMudarSenha_CheckedChanged(object sender, EventArgs e)
        {
            pnlMudarSenha.Enabled = ckbMudarSenha.Checked;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
