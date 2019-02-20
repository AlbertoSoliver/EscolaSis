using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaSis.Forms.Orientador
{
    public partial class OrientadorCadastro : Form
    {
        public OrientadorCadastro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
        }    private void txbValorMens_KeyPress(object sender, KeyPressEventArgs e)
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
            Form childForm = new OrientadorNovo();
            childForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbDataNascim_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
