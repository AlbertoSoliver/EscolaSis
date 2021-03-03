using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class MensalidadeManter : Form
    {
        private int _MensalidadeID;
        private int _AlunoID;

        public MensalidadeManter(string mensalidadeID, int alunoID)
        {
            InitializeComponent();

            _MensalidadeID = Convert.ToInt16("0" + mensalidadeID);
            _AlunoID = Convert.ToInt16("0" + alunoID);
        }

        private void txbDataPagto_ValueChanged(object sender, EventArgs e)
        {
            txbDataPagto.Format = DateTimePickerFormat.Short;
        }

        private void txbDataPagto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txbDataPagto.Format = DateTimePickerFormat.Custom;
            }
        }

        private void MensalidadeManter_Load(object sender, EventArgs e)
        {
            this.cbxRespPagto.DataSource = Model.Responsavel.ListaResponsAluno(_AlunoID, (_MensalidadeID == 0));
            if (this.cbxRespPagto.Items.Count > 0)
            {
                this.cbxReferencia.DataSource = Model.Tools.ListaReferMensalidade();
                this.cbxAnoRefer.DataSource = Model.Tools.ListaAnoMensaliade();
                this.cbxMesRefer.DataSource = Model.Tools.ListaMesesAno();
                this.cbxFormPagto.DataSource = Model.Tools.ListaFormPagto();

                Model.Mensalidade mensalidade = new Model.Mensalidade();
                mensalidade.DadosMensalidade(Convert.ToInt16("0" + _MensalidadeID));

                cbxReferencia.Text = mensalidade.Descricao;
                cbxMesRefer.SelectedIndex = mensalidade.MesReferIndex;
                cbxAnoRefer.Text = _MensalidadeID == 0 ? DateTime.Today.Year.ToString() : mensalidade.AnoReferIndex.ToString();
                if (mensalidade.DataEmissao.Year > 2000) txbDataEmissão.Value = mensalidade.DataEmissao;
                if (mensalidade.Vencimento.Year > 2000) txbDataVencim.Value = mensalidade.Vencimento;
                txbValor.Value = mensalidade.ValorMensalidade;

                if (_MensalidadeID == 0) cbxRespPagto.SelectedIndex = 0;
                else cbxRespPagto.SelectedValue = mensalidade.TutorAlunoID;

                if (mensalidade.FormaPagto != "" && mensalidade.FormaPagto != null)
                {
                    cbxFormPagto.SelectedText = mensalidade.FormaPagto;
                    if (mensalidade.DataPagto.Year > 2000) txbDataPagto.Value = mensalidade.DataPagto;
                    txbValorDesc.Value = mensalidade.Desconto;
                    txbJuros.Value = mensalidade.JurosMulta;
                    txbValorPagtoMens.Value = mensalidade.ValorPago;
                    chkRealizPagto.Checked = true;
                    grpFormPagto.Enabled = true;
                }
                else
                {
                    txbDataPagto.Format = DateTimePickerFormat.Custom;
                    txbValorDesc.Value = 0;
                    txbJuros.Value = 0;
                    txbValorPagtoMens.Value = 0;
                    grpFormPagto.Enabled = false;
                    chkRealizPagto.Checked = false;
                }

            }
            else
            {
                MessageBox.Show("A aluno não possui responsável pelos pagamentos. Indique um na Aba Resposáveis e repita a operação.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
        }

        private void btnGravarLancamento_Click(object sender, EventArgs e)
        {
            if (cbxReferencia.Text == "" || txbValor.Value <=0)
            {
                MessageBox.Show("Os campos Referêcia e Valor Mensalidade são obrigatórios.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxReferencia.Focus();
                return;
            }
            Model.Mensalidade mensalidade = new Model.Mensalidade();
            mensalidade.TutorAlunoID = Convert.ToInt16(cbxRespPagto.SelectedValue);
            mensalidade.Descricao = cbxReferencia.Text;
            mensalidade.DataEmissao = txbDataEmissão.Value;
            mensalidade.MesAnoRefer = (cbxMesRefer.SelectedIndex + 1).ToString().PadLeft(2, '0') + "/" + cbxAnoRefer.Text.ToString();
            mensalidade.Vencimento = txbDataVencim.Value;
            mensalidade.ValorMensalidade = txbValor.Value;

            if (chkRealizPagto.Checked)
            {
                if (txbDataPagto.Format == DateTimePickerFormat.Custom || txbDataPagto.Value.Year < 2000)
                {
                    MessageBox.Show("Data de pagamento inválida!!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDataPagto.Focus();
                    return;
                }
                mensalidade.DataPagto = txbDataPagto.Value;
                mensalidade.Desconto = txbValorDesc.Value;
                mensalidade.JurosMulta = txbJuros.Value;
                mensalidade.ValorPago = txbValorPagtoMens.Value;
                mensalidade.FormaPagto = Convert.ToString(cbxFormPagto.SelectedValue);
            }
            else
            {
                mensalidade.DataPagto = Convert.ToDateTime("0001-01-01");
                mensalidade.Desconto = 0;
                mensalidade.JurosMulta = 0;
                mensalidade.ValorPago = 0;
                mensalidade.FormaPagto = "";
            }

            mensalidade.MensalidadeID = _MensalidadeID;

            try
            {
                mensalidade.SalvarMensalidadeAluno(_MensalidadeID == 0 ? "I" : "U");
                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxAnoRefer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkRealizPagto_Click(object sender, EventArgs e)
        {
            if (chkRealizPagto.Checked)
            {
                txbDataPagto.Format = DateTimePickerFormat.Short;
                txbDataPagto.Value = DateTime.Today;
                txbValorDesc.Value = 0;
                txbJuros.Value = 0;
                txbValorPagtoMens.Value = txbValor.Value + txbJuros.Value - txbValorDesc.Value;
                grpFormPagto.Enabled = true;
            }
            else
            {
                txbDataPagto.Format = DateTimePickerFormat.Custom;
                txbValorDesc.Value = 0;
                txbJuros.Value = 0;
                txbValorPagtoMens.Value = 0;
                grpFormPagto.Enabled = false;
            }
        }

        private void txbValorDesc_ValueChanged(object sender, EventArgs e)
        {
            txbValorPagtoMens.Value = txbValor.Value + txbJuros.Value - txbValorDesc.Value;
        }

        private void txbJuros_ValueChanged(object sender, EventArgs e)
        {
            txbValorPagtoMens.Value = txbValor.Value + txbJuros.Value - txbValorDesc.Value;
        }

        private void txbValor_ValueChanged(object sender, EventArgs e)
        {
            if (chkRealizPagto.Checked)
            {
                txbValorPagtoMens.Value = txbValor.Value + txbJuros.Value - txbValorDesc.Value;
            }
            else txbValorPagtoMens.Value = 0;
        }
    }
}
