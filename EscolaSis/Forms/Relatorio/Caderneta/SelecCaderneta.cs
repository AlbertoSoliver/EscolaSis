using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.Caderneta
{
    public partial class SelecCaderneta : Form
    {
        public SelecCaderneta()
        {
            InitializeComponent();
        }

        private void SelecCaderneta_Load(object sender, EventArgs e)
        {
            this.cbxAnoCaderneta.DataSource = Model.Tools.ListaAnoLetivo();
            this.cbxMesCaderneta.DataSource = Model.Tools.ListaMesesAno();
            this.cbxTurmaCaderneta.DataSource = Model.Tools.ListaTurma();
            this.cbxOrientadorCaderneta.DataSource = Model.Orientador.ListaOrientadores();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Form childForm = new Caderneta(
                cbxAnoCaderneta.SelectedItem.ToString(), cbxTurmaCaderneta.SelectedItem.ToString(), cbxOrientadorCaderneta.SelectedValue.ToString(), 
                cbxMesCaderneta.SelectedItem.ToString() + "/"+cbxAnoCaderneta.SelectedItem.ToString());
            childForm.ShowDialog();
            Close();
        }
    }
}
