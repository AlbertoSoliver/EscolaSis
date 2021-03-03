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
        public string NomeAluno { get; set; }
        public string NumMatricula { get; set; }
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
                return Model.Tools.ResultadoFinal.GetDescricao(ResultadoFinal);
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
                CodigoPeriodo = dt.Rows[0]["CodigoPeriodoMatr"].ToString();
                Turma = dt.Rows[0]["Turma"].ToString();
                Disciplina = dt.Rows[0]["Disciplina"].ToString();
                RelatorioAtividade = dt.Rows[0]["RelatorioAtividade"].ToString();
                ResultadoFinal = dt.Rows[0]["ResultadoFinal"].ToString();
            }

        }
        public void SalvarMatriculaAluno(string tipo)
        {
            string commandText = "";
            if (tipo == "U")
            {
                commandText = "UPDATE Matriculas ";
                commandText += "SET ";
                commandText += "OrientadorID = @OrientadorID, ";
                commandText += "CodigoPeriodoMatr = @CodigoPeriodoMatr, ";
                commandText += "AnoLetivo = @AnoLetivo, ";
                commandText += "Turma = @Turma, ";
                commandText += "Disciplina = @Disciplina, ";
                commandText += "RelatorioAtividade = @RelatorioAtividade, ";
                commandText += "ResultadoFinal = @ResultadoFinal ";
                commandText += "WHERE MatriculaID = @MatriculaID ";

            }
            else
            {
                commandText = "INSERT INTO Matriculas ";
                commandText += "(OrientadorID, CodigoPeriodoMatr, AnoLetivo, Turma, Disciplina, RelatorioAtividade, ResultadoFinal, AlunoID) ";
                commandText += "VALUES ";
                commandText += "(@OrientadorID, @CodigoPeriodoMatr, @AnoLetivo, @Turma, @Disciplina, @RelatorioAtividade, @ResultadoFinal, @AlunoID)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@OrientadorID", Convert.ToInt32(OrientadorID.ToString()));
            cmd.Parameters.AddWithValue("@CodigoPeriodoMatr", CodigoPeriodo.ToString());
            cmd.Parameters.AddWithValue("@AnoLetivo", AnoLetivo.ToString());
            cmd.Parameters.AddWithValue("@Turma", Turma.ToString());
            cmd.Parameters.AddWithValue("@Disciplina", Disciplina.ToString());
            cmd.Parameters.AddWithValue("@RelatorioAtividade", RelatorioAtividade.ToString());
            cmd.Parameters.AddWithValue("@ResultadoFinal", ResultadoFinal.ToString());
            if (tipo == "I") cmd.Parameters.AddWithValue("@AlunoID", AlunoID.ToString());
            else cmd.Parameters.AddWithValue("@MatriculaID", MatriculaID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarMatriculaAluno()
        {
            string commandText = "";
            commandText = "DELETE FROM Matriculas ";
            commandText += "WHERE MatriculaID = @MatriculaID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MatriculaID", MatriculaID.ToString());

            DB.ExecCommand(cmd);
        }
        public static List<Matricula> ListaAlunosPorTurma(string orientadorID, string anoLetivo, string turma)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunosTurma";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@OrientadorID", orientadorID);
            cmd.Parameters.AddWithValue("@AnoLetivo", anoLetivo);
            cmd.Parameters.AddWithValue("@Turma", turma);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Matricula> lstAlunosTurma = new List<Matricula>();

            foreach (DataRow item in dt.Rows)
            {
                Matricula matricula = new Matricula();
                matricula.NomeAluno = item["NomeAluno"].ToString();
                matricula.NumMatricula = item["NumMatricula"].ToString();
                matricula.Disciplina = item["Disciplina"].ToString();
                matricula.Turma = item["Turma"].ToString();
                matricula.AnoLetivo = item["AnoLetivo"].ToString();
                matricula.ResultadoFinal = item["ResultadoFinal"].ToString();
                matricula.NomeOrientador = item["NomeOrientador"].ToString();
                lstAlunosTurma.Add(matricula);
            }

            return lstAlunosTurma;
        }
    }
}
