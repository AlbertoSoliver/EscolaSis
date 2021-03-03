using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class CursoGradeCurric
    {
        public int GradeCurricularID { get; set; }
        public int AreaConecimentoID { get; set; }
        public int CursoID { get; set; }
        public string TituloCurso { get; set; }
        public int CargaHrCurso { get; set; }
        public string AreaConhecim { get; set; }
        public string CodigoDisciplina { get; set; }
        public string NomeDisciplina { get; set; }
        public int HoraAula { get; set; }
        public int CargaHrTotal { get; set; }
        public string Observacao { get; set; }

        public CursoGradeCurric() { }

        public static List<CursoGradeCurric> ListaGrade(int CursoID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstCursoGradeLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@CursoID", CursoID.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<CursoGradeCurric> lstGrade = new List<CursoGradeCurric>();

            foreach (DataRow item in dt.Rows)
            {
                CursoGradeCurric cursoGradeCurric = new CursoGradeCurric();
                cursoGradeCurric.GradeCurricularID = Convert.ToInt32(item["GradeCurricularID"].ToString());
                cursoGradeCurric.AreaConecimentoID = Convert.ToInt32(item["AreaConecimentoID"].ToString());
                cursoGradeCurric.CursoID = Convert.ToInt32(item["CursoID"].ToString());
                cursoGradeCurric.CodigoDisciplina = item["CodigoDisciplina"].ToString();
                cursoGradeCurric.TituloCurso = item["TituloCurso"].ToString();
                cursoGradeCurric.CargaHrCurso = Convert.ToInt32(item["CargaHoraria"].ToString());
                cursoGradeCurric.AreaConhecim = item["AreaConhecim"].ToString();
                cursoGradeCurric.NomeDisciplina = item["NomeDisciplina"].ToString();
                cursoGradeCurric.HoraAula = Convert.ToInt32(item["HoraAula"].ToString());
                cursoGradeCurric.CargaHrTotal = Convert.ToInt32(item["CargaHrTotal"].ToString());
                cursoGradeCurric.Observacao = item["Observacao"].ToString();

                lstGrade.Add(cursoGradeCurric);

            }

            return lstGrade;
        }
        public static int TotalCHLancada(int CursoID)
        {
            int totalLancado = 0;
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstCursoGradeCHLancada";
            cmd.Parameters.AddWithValue("@CursoID", CursoID.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0) totalLancado = Convert.ToInt32(dt.Rows[0]["TotalLanc"].ToString());

            return totalLancado;

        }
        public void DadosGradeCurric(int GradeCurricularID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstCursoGradeDados";
            cmd.Parameters.AddWithValue("@GradeCurricularID", GradeCurricularID.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.GradeCurricularID = Convert.ToInt32(dt.Rows[0]["GradeCurricularID"].ToString());
                this.AreaConecimentoID = Convert.ToInt32(dt.Rows[0]["AreaConecimentoID"].ToString());
                this.CursoID = Convert.ToInt32(dt.Rows[0]["CursoID"].ToString());
                this.CodigoDisciplina = dt.Rows[0]["CodigoDisciplina"].ToString();
                this.NomeDisciplina = dt.Rows[0]["NomeDisciplina"].ToString();
                this.HoraAula = Convert.ToInt32(dt.Rows[0]["HoraAula"].ToString());
                this.CargaHrTotal = Convert.ToInt32(dt.Rows[0]["CargaHrTotal"].ToString());
                this.Observacao = dt.Rows[0]["Observacao"].ToString();
            }
        }
        public void SalvarGradeCurric(string tipo)
        {
            string commandText = "";

            if (tipo == "U")
            {
                commandText = "UPDATE GradeCurricular ";
                commandText += "SET ";
                commandText += "AreaConecimentoID = @AreaConecimentoID, ";
                commandText += "CursoID = @CursoID, ";
                commandText += "CodigoDisciplina = @CodigoDisciplina, ";
                commandText += "NomeDisciplina = @NomeDisciplina, ";
                commandText += "HoraAula = @HoraAula, ";
                commandText += "CargaHrTotal = @CargaHrTotal, ";
                commandText += "Observacao = @Observacao ";
                commandText += "WHERE GradeCurricularID = @GradeCurricularID ";
            }
            else
            {
                commandText = "INSERT INTO GradeCurricular ";
                commandText += "(AreaConecimentoID, CursoID, CodigoDisciplina, NomeDisciplina, HoraAula, CargaHrTotal, Observacao) ";
                commandText += " VALUES ";
                commandText += "(@AreaConecimentoID, @CursoID, @CodigoDisciplina, @NomeDisciplina, @HoraAula, @CargaHrTotal, @Observacao)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AreaConecimentoID", Convert.ToInt32(AreaConecimentoID.ToString()));
            cmd.Parameters.AddWithValue("@CursoID", Convert.ToInt32(CursoID.ToString()));
            cmd.Parameters.AddWithValue("@CodigoDisciplina", CodigoDisciplina.ToString());
            cmd.Parameters.AddWithValue("@NomeDisciplina", NomeDisciplina.ToString());
            cmd.Parameters.AddWithValue("@HoraAula", Convert.ToInt32(HoraAula.ToString()));
            cmd.Parameters.AddWithValue("@CargaHrTotal", Convert.ToInt32(CargaHrTotal.ToString()));
            cmd.Parameters.AddWithValue("@Observacao", Observacao.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@GradeCurricularID", GradeCurricularID.ToString());

            DB.ExecCommand(cmd);

        }
        public static void DeletarGradeCurric(int GradeCurricularID)
        {
            string commandText = "";

            commandText = "DELETE FROM GradeCurricular ";
            commandText += "WHERE GradeCurricularID = @GradeCurricularID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@GradeCurricularID", GradeCurricularID.ToString());

            DB.ExecCommand(cmd);
        }
    }
}
