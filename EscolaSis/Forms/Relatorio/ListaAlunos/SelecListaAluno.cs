using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscolaSis.Forms.Relatorio.ListaAlunos
{
    public partial class SelecListaAluno : Form
    {
        public SelecListaAluno()
        {
            InitializeComponent();
        }

        private void SelecListaAluno_Load(object sender, EventArgs e)
        {
            this.cbxAnoListaAluno.DataSource = Model.Tools.ListaAnoLetivo();
            this.cbxTurmaListaAluno.DataSource = Model.Tools.ListaTurma(true);
            this.cbxOrientadorListaAluno.DataSource = Model.Orientador.ListaOrientadores("%", true);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form childForm = new ListaAluno(
                cbxAnoListaAluno.SelectedItem.ToString(), 
                cbxTurmaListaAluno.SelectedItem.ToString(), 
                cbxOrientadorListaAluno.SelectedValue.ToString());
            childForm.ShowDialog();
            Close();
        }
    }
}
