using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Curso
    {
        public int CursoID { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }

        public Curso() { }
        public static List<Curso> ListaCursos(string filtro = "%")
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstCursoLista";
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@Nome", "%" + filtro + "%");

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Curso> lstCurso = new List<Curso>();

            foreach (DataRow item in dt.Rows)
            {
                Curso curso = new Curso();
                curso.CursoID = Convert.ToInt32(item["CursoID"].ToString());
                curso.Codigo = item["Codigo"].ToString();
                curso.Titulo = item["Titulo"].ToString();
                curso.Descricao = item["Descricao"].ToString();
                curso.CargaHoraria = Convert.ToInt32(item["CargaHoraria"].ToString());

                lstCurso.Add(curso);
            }

            return lstCurso;
        }
        public void DadosCurso(int cursoID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstCursoDados";
            cmd.Parameters.AddWithValue("@CursoID", cursoID.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                CursoID = Convert.ToInt32(dt.Rows[0]["CursoID"].ToString());
                Codigo = dt.Rows[0]["Codigo"].ToString();
                Titulo = dt.Rows[0]["Titulo"].ToString();
                Descricao = dt.Rows[0]["Descricao"].ToString();
                CargaHoraria = Convert.ToInt32(dt.Rows[0]["CargaHoraria"].ToString());
            }
        }
        public void SalvarCurso(string tipo)
        {
            string commandText = "";

            if (tipo == "U")
            {
                commandText = "UPDATE Curso ";
                commandText += "SET ";
                commandText += "Codigo = @Codigo, ";
                commandText += "Titulo = @Titulo, ";
                commandText += "Descricao = @Descricao, ";
                commandText += "CargaHoraria = @CargaHoraria ";
                commandText += "WHERE CursoID = @CursoID ";
            }
            else
            {
                commandText = "INSERT INTO Curso ";
                commandText += "(Codigo, Titulo, Descricao, CargaHoraria) ";
                commandText += " VALUES ";
                commandText += "(@Codigo, @Titulo, @Descricao, @CargaHoraria)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Codigo", Codigo.ToString());
            cmd.Parameters.AddWithValue("@Titulo", Titulo.ToString());
            cmd.Parameters.AddWithValue("@Descricao", Descricao.ToString());
            cmd.Parameters.AddWithValue("@CargaHoraria", CargaHoraria.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@CursoID", CursoID.ToString());

            DB.ExecCommand(cmd);

        }
        public static void DeletarCurso(int CursoID)
        {
            string commandText = "";

            commandText = "DELETE FROM Curso ";
            commandText += "WHERE CursoID = @CursoID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@CursoID", CursoID.ToString());

            DB.ExecCommand(cmd);
        }

    }
}
