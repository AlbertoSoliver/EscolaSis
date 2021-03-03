using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class MensalidadesPeriodo : Form
    {
        private int _AlunoID;
        public MensalidadesPeriodo(string alunoID)
        {
            InitializeComponent();
            _AlunoID = Convert.ToInt16("0" + alunoID);
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

        private void MensalidadesPeriodo_Load(object sender, EventArgs e)
        {
            this.cbxRespPagamneto.DataSource = Model.Responsavel.ListaResponsAluno(_AlunoID, true);
            if (this.cbxRespPagamneto.Items.Count > 0)
            {
                this.cbxReferencia.DataSource = Model.Tools.ListaReferMensalidade();
                this.cbxAnoMensalidade.DataSource = Model.Tools.ListaAnoMensaliade();
                //if (!cbxAnoMensalidade.Items.Contains(DateTime.Today.Year)) cbxAnoMensalidade.Items.Add(DateTime.Today.Year);
                //if (!cbxAnoMensalidade.Items.Contains(DateTime.Today.Year + 1)) cbxAnoMensalidade.Items.Add(DateTime.Today.Year + 1);

                cbxMesInicio.DataSource = Model.Tools.ListaMesesAno();
                cbxMesFinal.DataSource = Model.Tools.ListaMesesAno();
            }
            else
            {
                MessageBox.Show("A aluno não possui responsável pelos pagamentos. Indique um na Aba Resposáveis e repita a operação.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
            }
        }

        private void btnGerarMensal_Click(object sender, EventArgs e)
        {
            if (cbxReferencia.Text == "" || txbValorMensalidade.Value <= 0)
            {
                MessageBox.Show("Os campos Referêcia e Valor Mensalidade são obrigatórios.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxReferencia.Focus();
                return;
            }

            if (cbxMesFinal.SelectedIndex < cbxMesInicio.SelectedIndex)
            {
                MessageBox.Show("Selecione meses compativeis.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxMesInicio.Focus();
                return;
            }
            DateTime dataVenc = DataVencMaisUmMes((int)txbDiaVenc.Value, cbxMesInicio.SelectedIndex + 1, Convert.ToInt16(cbxAnoMensalidade.SelectedValue));

            string msg = String.Format("Esta operação irá gerar as Mensalidades pro período de {0} à {1} de {2}, com " +
                "vencinento da primeira mensalidade para o dia {3}.",
                Convert.ToString(cbxMesInicio.SelectedValue), Convert.ToString(cbxMesFinal.SelectedValue), Convert.ToString(cbxAnoMensalidade.SelectedValue), dataVenc.ToString("dd/MM/yyyy"));
            DialogResult dlr = MessageBox.Show(msg, "EscolaSis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dlr == DialogResult.OK)
            {
                for (int i = 0; i <= cbxMesFinal.SelectedIndex - cbxMesInicio.SelectedIndex; i++)
                {
                    Model.Mensalidade mensalidade = new Model.Mensalidade();
                    mensalidade.TutorAlunoID = Convert.ToInt16(cbxRespPagamneto.SelectedValue);
                    mensalidade.Descricao = cbxReferencia.Text;
                    mensalidade.DataEmissao = DateTime.Today;
                    mensalidade.MesAnoRefer = dataVenc.AddMonths(-1).ToString("MM/yyyy");
                    mensalidade.Vencimento = dataVenc;
                    mensalidade.FormaPagto = "";
                    mensalidade.ValorMensalidade = txbValorMensalidade.Value;

                    try
                    {
                        mensalidade.SalvarMensalidadeAluno("I");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dataVenc = DataVencMaisUmMes((int)txbDiaVenc.Value, dataVenc.Month, dataVenc.Year);
                }

                MessageBox.Show("Mensalidades geradas com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }

        private DateTime DataVencMaisUmMes(int dia, int mes, int ano)
        {
            mes += 1;
            if (mes > 12)
            {
                mes = 1;
                ano += 1;
            }
            string ProximoVencStr = dia.ToString().PadLeft(2, '0') + "/" + mes.ToString().PadLeft(2, '0') + '/' + ano.ToString();
            DateTime ProximoVenc;
            while (!DateTime.TryParse(ProximoVencStr, out ProximoVenc))
            {
                dia -= 1;
                ProximoVencStr = dia.ToString().PadLeft(2, '0') + "/" + (mes).ToString().PadLeft(2, '0') + '/' + ano.ToString();
            }
            return ProximoVenc;
        }
    }
}
