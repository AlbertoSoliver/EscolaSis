using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class AreaConhecimento
    {
        public int AreaConhecimentoID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string DescrCompleta { get; set; }

        public AreaConhecimento() { }
        public static List<AreaConhecimento> ListarAreas()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAreaConhecLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@GrupoEscolar", "%");

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<AreaConhecimento> lstCurso = new List<AreaConhecimento>();

            foreach (DataRow item in dt.Rows)
            {
                AreaConhecimento areaConhecimento = new AreaConhecimento();
                areaConhecimento.AreaConhecimentoID = Convert.ToInt32(item["AreaConhecimentoID"].ToString());
                areaConhecimento.Titulo = item["Titulo"].ToString();
                areaConhecimento.Descricao = item["Descricao"].ToString();
                areaConhecimento.Tipo = item["Tipo"].ToString();
                areaConhecimento.DescrCompleta = item["DescrCompleta"].ToString();

                lstCurso.Add(areaConhecimento);
            }

            return lstCurso;
        }
    }
}
