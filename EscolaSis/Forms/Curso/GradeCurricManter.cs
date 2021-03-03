using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscolaSis.Forms.Curso
{
    public partial class GradeCurricManter : Form
    {
        private int _GradeCurricularID { get; set; }
        private int _CursoID { get; set; }
        public GradeCurricManter(string CursoNome, int GradeCurricID, int CursoID)
        {
            _GradeCurricularID = GradeCurricID;
            _CursoID = CursoID;
            InitializeComponent();
            lblCursoNome.Text = CursoNome;
            cbxAreaConhec.DataSource = Model.AreaConhecimento.ListarAreas();
            if (_GradeCurricularID != 0)
            {
                gbxPrincipal.Text = "ALTERAÇÃO";
                Model.CursoGradeCurric grade = new Model.CursoGradeCurric();
                grade.DadosGradeCurric(_GradeCurricularID);
                txbCodigoDiscipl.Text = grade.CodigoDisciplina;
                txbNomeDiscipl.Text = grade.NomeDisciplina;
                txbHoraAula.Text = grade.HoraAula.ToString();
                txbCargaHr.Text = grade.CargaHrTotal.ToString();
                cbxAreaConhec.SelectedIndex = 0;
                txbObservacao.Text = grade.Observacao.ToString();
                cbxAreaConhec.SelectedValue = grade.AreaConecimentoID;
            } else gbxPrincipal.Text = "INCLUISÃO"; ;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxbHoraAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxbCargaHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (txbCodigoDiscipl.Text == "" || txbNomeDiscipl.Text == "")
            {
                MessageBox.Show("Os campos Código e Nome da Disciplina são obrigatórios.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCodigoDiscipl.Focus();
                return;
            }

            Model.CursoGradeCurric GradeCurric = new Model.CursoGradeCurric();
            GradeCurric.GradeCurricularID = _GradeCurricularID;
            GradeCurric.CursoID = _CursoID;
            GradeCurric.AreaConecimentoID = Convert.ToInt32(cbxAreaConhec.SelectedValue.ToString());
            GradeCurric.CodigoDisciplina = txbCodigoDiscipl.Text;
            GradeCurric.NomeDisciplina = txbNomeDiscipl.Text;
            GradeCurric.HoraAula = Convert.ToInt32(txbHoraAula.Text);
            GradeCurric.CargaHrTotal = Convert.ToInt32(txbCargaHr.Text);
            GradeCurric.Observacao = txbObservacao.Text;

            try
            {
                GradeCurric.SalvarGradeCurric(_GradeCurricularID == 0 ? "I" : "U");
                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
