using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Turma
    {
        public int TurmaID { get; set; }
        public int OrientadorID { get; set; }
        public int OrientadorAuxID { get; set; }
        public string CodigoTurma { get; set; }
        public string TituloTurma { get; set; }
        public int Ano { get; set; }
        public string NomeProfessor { get; set; }
        public int[] TurmaID_Desc { get; set; }

        public Turma() { }
        public static List<Turma> ListaTurma(string Curso, string Ano)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstTurmaLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Ano", Ano); // like
            cmd.Parameters.AddWithValue("@Curso", Curso); // like
            
            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Turma> lstTurma = new List<Turma>();

            foreach (DataRow item in dt.Rows)
            {
                Turma turma = new Turma();
                turma.TurmaID = Convert.ToInt32(item["TurmaID"].ToString());
                turma.CodigoTurma = item["CodigoTurma"].ToString();
                turma.TituloTurma = item["TituloTurma"].ToString();
                turma.NomeProfessor = item["NomeProfessor"].ToString();
                turma.Ano = Convert.ToInt32(item["Ano"].ToString());

                lstTurma.Add(turma);
            }

            return lstTurma;
        }
    }
}
