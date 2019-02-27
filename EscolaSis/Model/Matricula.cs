using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EscolaSis.Model
{
    class Matricula
    {
        public int AlunoID { get; set; }
        public int MatriculaID { get; set; }
        public int OrientadorID { get; set; }
        public string NomeOrientador { get; set; }
        public string AnoLetivo { get; set; }
        public string CodigoPeriodo { get; set; }
        public string NomePeriodo { get { return Tools.PeriodoLetivo.GetDescricao(CodigoPeriodo); } }
        public string Turma { get; set; }
        public string Disciplina { get; set; }
        public string RelatorioAtividade { get; set; }
        public string ResultadoFinal { get; set; }
        public string ResultadoFinalDescr
        {
            get
            {
                switch (ResultadoFinal)
                {
                    case "A": return "Aprovado";
                    case "R": return "Reporovado";
                    default: return "Sem Avaliação";
                }
            }
        }

        public Matricula() { }

        public void DadosMatricula(Int32 MatriculaIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstMatriculaDados";
            cmd.Parameters.AddWithValue("@MatriculaID", MatriculaIDPesquisar.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AlunoID = Convert.ToInt32(dt.Rows[0]["AlunoID"].ToString());
                MatriculaID = Convert.ToInt32(dt.Rows[0]["MatriculaID"].ToString());
                OrientadorID = Convert.ToInt32(dt.Rows[0]["OrientadorID"].ToString());
                NomeOrientador = dt.Rows[0]["NomeOrientador"].ToString();
                AnoLetivo = dt.Rows[0]["AnoLetivo"].ToString();
                //DataNascim = Convert.ToDateTime(dt.Rows[0]["DataNascim"].ToString());
                CodigoPeriodo = dt.Rows[0]["CodigoPeriodoMatr"].ToString();
                Turma = dt.Rows[0]["Turma"].ToString();
                Disciplina = dt.Rows[0]["Disciplina"].ToString();
                RelatorioAtividade = dt.Rows[0]["RelatorioAtividade"].ToString();
                ResultadoFinal = dt.Rows[0]["ResultadoFinal"].ToString();
            }

        }
    }
}
