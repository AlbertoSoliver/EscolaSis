using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EscolaSis.Model
{
    class Mensalidade
    {
        public int AlunoID { get; set; }
        public int MensalidadeID { get; set; }
        public int TutorAlunoID { get; set; }
        public string RespPagto { get; set; }
        public string Descricao { get; set; }
        public string MesAnoRefer { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal ValorMensalidade { get; set; }
        public DateTime DataPagto { get; set; }
        public decimal Desconto { get; set; }
        public decimal JurosMulta { get; set; }
        public decimal ValorPago { get; set; }
        public string FormaPagto { get; set; }
        public string SituacaoPagto { get; set; }

        public Mensalidade() { }

        public void DadosMensalidade(Int32 MensalidadeIDPesq)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstMensalidadeDados";
            cmd.Parameters.AddWithValue("@MensalidadeID", MensalidadeIDPesq.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AlunoID = Convert.ToInt32(dt.Rows[0]["AlunoID"].ToString());
                MensalidadeID = Convert.ToInt32(dt.Rows[0]["MensalidadeID"].ToString());
                TutorAlunoID = Convert.ToInt32(dt.Rows[0]["TutorAlunoID"].ToString());
                RespPagto = dt.Rows[0]["RespPagto"].ToString();
                Descricao = dt.Rows[0]["Descricao"].ToString();
                MesAnoRefer = dt.Rows[0]["MesAnoRefer"].ToString();
                DataEmissao  = Convert.ToDateTime(dt.Rows[0]["DataEmissao"].ToString());
                Vencimento = Convert.ToDateTime(dt.Rows[0]["Vencimento"].ToString());
                ValorMensalidade = Convert.ToDecimal(dt.Rows[0]["ValorMensalidade"].ToString());
                DataPagto = Convert.ToDateTime(dt.Rows[0]["DataPagto"].ToString());
                Desconto = Convert.ToDecimal(dt.Rows[0]["Desconto"].ToString());
                JurosMulta = Convert.ToDecimal(dt.Rows[0]["JurosMulta"].ToString());
                ValorPago = Convert.ToDecimal(dt.Rows[0]["ValorPago"].ToString());
                FormaPagto = dt.Rows[0]["FormaPagto"].ToString();
                SituacaoPagto = dt.Rows[0]["SitPagto"].ToString();
            }
        }

    }
}
