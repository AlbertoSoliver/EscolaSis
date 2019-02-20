using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class MensalidadesPeriodo : Form
    {
        public MensalidadesPeriodo()
        {
            InitializeComponent();
        }

        private void txbDataPagto_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txbDataPagto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
