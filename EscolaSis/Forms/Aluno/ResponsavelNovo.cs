using System;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno

{
    public partial class ResponsavelNovo : Form
    {
        private string _AlunoID { get; set; }
        public ResponsavelNovo(string AlunoID)
        {
            _AlunoID = AlunoID;
            InitializeComponent();
        }

        private void ResponsavelNovo_Load(object sender, EventArgs e)
        {
            cbxResponsavel.DataSource = Model.Responsavel.ListaResponsaveis();
            cbxRelacAluno.DataSource = Model.Tools.Parenteso.ListaParentesco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.Responsavel responsavelInsert = new Model.Responsavel();
            responsavelInsert.AlunoID = Convert.ToInt16(_AlunoID);
            responsavelInsert.TutorID = Convert.ToInt16(cbxResponsavel.SelectedValue); 
            responsavelInsert.RelacaoAluno = cbxRelacAluno.Text;
            responsavelInsert.Pagador = ckbPagador.Checked ? "S" : "N";
            responsavelInsert.PodePegarEscola = ckbPodePegar.Checked ? "S" : "N";

            try
            {
                responsavelInsert.SalvarResponsavelAluno("I");
                MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
