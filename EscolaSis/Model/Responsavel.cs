using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EscolaSis.Model
{
    class Responsavel
    {
        public int AlunoID { get; set; }
        public int TutorID { get; set; }
        public int TutorAlunoID { get; set; }
        public string RelacaoAluno { get; set; }
        public string RelacaoAlunoDescr
        {
            get
            {
                string relAluno = "";

                switch (RelacaoAluno)
                {
                    //P-Pai, M-Mãe, I-Irmão(ã), A-Avô(ó), T-Tio(a), R-Primo(a), G-Amigo(a)
                    case "P":
                        relAluno = "Pai";
                        break;
                    case "M":
                        relAluno = "Mãe";
                        break;
                    case "I":
                        relAluno = "I-Irmão(ã)";
                        break;
                    case "A":
                        relAluno = "Avô(ó)";
                        break;
                    case "T":
                        relAluno = "Tio(a)";
                        break;
                    case "R":
                        relAluno = "Primo(a)";
                        break;
                    case "G":
                        relAluno = "Amigo(a)";
                        break;
                    default:
                        break;
                }

                return relAluno;
            }
        }
        public string Pagador { get; set; }
        public string PodePegarEscola { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }

        public void DadosResponsavel(Int32 TutorAlunoIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstResponsavelDados";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorAlunoID", TutorAlunoIDPesquisar.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TutorAlunoID = Convert.ToInt32(dt.Rows[0]["TutorAlunoID"].ToString());
                AlunoID = Convert.ToInt32(dt.Rows[0]["AlunoID"].ToString());
                TutorID = Convert.ToInt32(dt.Rows[0]["TutorID"].ToString());
                RelacaoAluno = dt.Rows[0]["RelacaoAluno"].ToString();
                Pagador = dt.Rows[0]["Pagador"].ToString();
                PodePegarEscola = dt.Rows[0]["PodePegarEscola"].ToString();
                Nome = dt.Rows[0]["Nome"].ToString();
                if (dt.Rows[0]["DataNascimento"].ToString() != "") DataNascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"].ToString());
                RG = dt.Rows[0]["RG"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                Endereco = dt.Rows[0]["Endereco"].ToString();
                Bairro = dt.Rows[0]["Bairro"].ToString();
                Cidade = dt.Rows[0]["Cidade"].ToString();
                CEP = dt.Rows[0]["CEP"].ToString();
                Telefone = dt.Rows[0]["Telefone"].ToString();
                Sexo = dt.Rows[0]["Sexo"].ToString();

            }

        }
    }
}
