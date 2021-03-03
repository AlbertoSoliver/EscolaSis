using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Mensalidade
    {
        public int AlunoID { get; set; }
        public int MensalidadeID { get; set; }
        public int TutorAlunoID { get; set; }
        public string NomeAluno { get; set; }
        public string RespPagto { get; set; }
        public string RespPagtoTelef { get; set; }
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
        public int MesReferIndex
        {
            get
            {
                int idxMes = 0;
                if (MesAnoRefer != null && MesAnoRefer.Length > 0)
                {
                    try
                    {
                        idxMes = Convert.ToInt16(MesAnoRefer.Trim().Substring(0, 2)) - 1;
                    }
                    catch (Exception)
                    {
                        idxMes = 0;
                    }

                }
                return idxMes;
            }
        }
        public int AnoReferIndex
        {
            get
            {
                int idxAno = 0;
                if (MesAnoRefer != null && MesAnoRefer.Length > 3)
                {
                    try
                    {
                        idxAno = Convert.ToInt16(MesAnoRefer.Trim().Substring(3, 4));
                    }
                    catch (Exception)
                    {
                        idxAno = DateTime.Now.Year;
                    }

                }
                return idxAno;
            }
        }
        public Mensalidade() { }

        public static List<Mensalidade> ListaParcelas(string alunoID, string anoRef, string SituacMensalidade)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstListaParcelas";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);
            cmd.Parameters.AddWithValue("@SitPagto", SituacMensalidade);
            cmd.Parameters.AddWithValue("@AnoRef", anoRef);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Mensalidade> lstParcelas = new List<Mensalidade>();

            foreach (DataRow item in dt.Rows)
            {
                Mensalidade mensalidade = new Mensalidade();
                mensalidade.AlunoID = Convert.ToInt16(item["AlunoID"].ToString());
                mensalidade.MensalidadeID = Convert.ToInt16(item["MensalidadeID"].ToString());
                mensalidade.TutorAlunoID = Convert.ToInt16(item["TutorAlunoID"].ToString());
                mensalidade.NomeAluno = item["NomeAluno"].ToString();
                mensalidade.RespPagto = item["RespPagto"].ToString();
                mensalidade.RespPagtoTelef = item["RespPagtoTelef"].ToString();
                mensalidade.Descricao = item["Descricao"].ToString();
                mensalidade.MesAnoRefer = item["MesAnoRefer"].ToString();
                if (item["DataEmissao"].ToString() != "") mensalidade.DataEmissao = Convert.ToDateTime(item["DataEmissao"].ToString());
                mensalidade.Vencimento = Convert.ToDateTime(item["Vencimento"].ToString());
                mensalidade.ValorMensalidade = Convert.ToDecimal(item["ValorMensalidade"].ToString());
                if (item["DataPagto"].ToString() != "") mensalidade.DataPagto = Convert.ToDateTime(item["DataPagto"].ToString());
                mensalidade.Desconto = Convert.ToDecimal(item["Desconto"].ToString());
                mensalidade.JurosMulta = Convert.ToDecimal(item["JurosMulta"].ToString());
                mensalidade.ValorPago = Convert.ToDecimal(item["ValorPago"].ToString());
                mensalidade.FormaPagto = item["FormaPagto"].ToString();
                mensalidade.SituacaoPagto = item["SitPagto"].ToString();

                lstParcelas.Add(mensalidade);
            }

            return lstParcelas;
        }

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
                if (dt.Rows[0]["DataEmissao"].ToString() != "") DataEmissao = Convert.ToDateTime(dt.Rows[0]["DataEmissao"].ToString());
                Vencimento = Convert.ToDateTime(dt.Rows[0]["Vencimento"].ToString());
                ValorMensalidade = Convert.ToDecimal(dt.Rows[0]["ValorMensalidade"].ToString());
                if (dt.Rows[0]["DataPagto"].ToString() != "") DataPagto = Convert.ToDateTime(dt.Rows[0]["DataPagto"].ToString());
                Desconto = Convert.ToDecimal(dt.Rows[0]["Desconto"].ToString());
                JurosMulta = Convert.ToDecimal(dt.Rows[0]["JurosMulta"].ToString());
                ValorPago = Convert.ToDecimal(dt.Rows[0]["ValorPago"].ToString());
                FormaPagto = dt.Rows[0]["FormaPagto"].ToString();
                SituacaoPagto = dt.Rows[0]["SitPagto"].ToString();
            }
        }
        public void SalvarMensalidadeAluno(string tipo)
        {
            string commandText = "";
            if (tipo == "U")
            {
                commandText = "UPDATE Mensalidades ";
                commandText += "SET ";
                commandText += "TutorAlunoID = @TutorAlunoID, ";
                commandText += "Descricao = @Descricao, ";
                commandText += "MesAnoRefer = @MesAnoRefer, ";
                commandText += "DataEmissao = @DataEmissao, ";
                commandText += "Vencimento = @Vencimento, ";
                commandText += "ValorMensalidade = @ValorMensalidade, ";
                commandText += "DataPagto = @DataPagto, ";
                commandText += "Desconto = @Desconto, ";
                commandText += "JurosMulta = @JurosMulta, ";
                commandText += "ValorPago = @ValorPago, ";
                commandText += "FormaPagto = @FormaPagto ";
                commandText += "WHERE MensalidadeID = @MensalidadeID ";

            }
            else
            {
                commandText = "INSERT INTO Mensalidades ";
                commandText += "(TutorAlunoID, Descricao, MesAnoRefer, DataEmissao, Vencimento, ValorMensalidade, DataPagto, Desconto, JurosMulta, ValorPago, FormaPagto) ";
                commandText += "VALUES ";
                commandText += "(@TutorAlunoID, @Descricao, @MesAnoRefer, @DataEmissao, @Vencimento, @ValorMensalidade, @DataPagto, @Desconto, @JurosMulta, @ValorPago, @FormaPagto) ";
            }

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorAlunoID", TutorAlunoID.ToString());
            cmd.Parameters.AddWithValue("@Descricao", Descricao.ToString());
            cmd.Parameters.AddWithValue("@MesAnoRefer", MesAnoRefer);
            cmd.Parameters.AddWithValue("@DataEmissao", DataEmissao);
            cmd.Parameters.AddWithValue("@Vencimento", Vencimento);
            cmd.Parameters.AddWithValue("@ValorMensalidade", ValorMensalidade.ToString());
            if (DataPagto.Year < 1900) cmd.Parameters.AddWithValue("@DataPagto", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataPagto", DataPagto);
            cmd.Parameters.AddWithValue("@Desconto", Desconto.ToString());
            cmd.Parameters.AddWithValue("@JurosMulta", JurosMulta.ToString());
            cmd.Parameters.AddWithValue("@ValorPago", ValorPago.ToString());
            cmd.Parameters.AddWithValue("@FormaPagto", FormaPagto.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@MensalidadeID", MensalidadeID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarMensalidadeAluno()
        {
            string commandText = "";
            commandText = "DELETE FROM Mensalidades ";
            commandText += "WHERE MensalidadeID = @MensalidadeID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@MensalidadeID", MensalidadeID.ToString());

            DB.ExecCommand(cmd);

        }
        public class Carne
        {
            public string NomeAluno { get; set; }
            public string EscolaNome { get; set; }
            public string EscolaCNPJ { get; set; }
            public string EscolaRSocial { get; set; }
            public string EscolaEndereco { get; set; }
            public string EscolaCidade { get; set; }
            public string EscolaTelefone { get; set; }
            public string SacadoNome { get; set; }
            public string SacadoEndereco { get; set; }
            public string SacadoCPF { get; set; }
            public string DiaPagto { get; set; }
            public string MesPagto { get; set; }
            public string AnoPagto { get; set; }
            public string NumDocumento { get; set; }
            public DateTime DataVencimento { get; set; }
            public string PeriodoRef { get; set; }
            public decimal ValorMensal { get; set; }
            public decimal ValorAcrescimo { get; set; }
            public decimal ValorPago { get; set; }
            public decimal ValorDesconto { get; set; }
            public string InstrDesconto { get; set; }
            public string InstrJurosMulta { get; set; }

            public static List<Carne> ListaCarnes(string alunoID, string mensalidadeID, string anoRef, bool ConsDeconto, bool CobrarJurosMulta, string Observ)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "cstCarne";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AlunoID", alunoID);
                cmd.Parameters.AddWithValue("@MensalidadeID", mensalidadeID);
                cmd.Parameters.AddWithValue("@AnoRef", anoRef);

                OleDbDataAdapter adp = DB.DBAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                EscolaDados escola = new EscolaDados();
                List<Carne> lstCane = new List<Carne>();

                foreach (DataRow item in dt.Rows)
                {
                    Carne carne = new Carne();
                    carne.NomeAluno = item["AlunoNome"].ToString();
                    carne.EscolaNome = escola.NomeEscola;
                    carne.EscolaCNPJ = escola.CNPJ;
                    carne.EscolaRSocial = escola.RazaoSocial;
                    carne.EscolaEndereco = escola.Endereco;
                    carne.EscolaCidade = escola.Cidade;
                    carne.EscolaTelefone = "";
                    carne.SacadoNome = item["SacadoNome"].ToString();
                    carne.SacadoEndereco = item["SacadoEndereco"].ToString();
                    carne.SacadoCPF = item["SacadoCPF"].ToString();
                    carne.DiaPagto = item["DataPagto"].ToString() != "" ? Convert.ToDateTime(item["DataPagto"].ToString()).Day.ToString().PadLeft(2, '0') : "";
                    carne.MesPagto = item["DataPagto"].ToString() != "" ? Convert.ToDateTime(item["DataPagto"].ToString()).Month.ToString().PadLeft(2, '0') : "";
                    carne.AnoPagto = item["DataPagto"].ToString() != "" ? Convert.ToDateTime(item["DataPagto"].ToString()).Year.ToString() : "";
                    carne.NumDocumento = item["NumeroDoc"].ToString();
                    if (item["Vencimento"].ToString() != "") carne.DataVencimento = Convert.ToDateTime(item["Vencimento"].ToString());
                    carne.PeriodoRef = item["MesAnoRefer"].ToString();
                    carne.ValorMensal = Convert.ToDecimal(item["ValorMensalidade"].ToString());
                    carne.ValorAcrescimo = Convert.ToDecimal(item["JurosMulta"].ToString());
                    carne.ValorPago = Convert.ToDecimal(item["ValorPago"].ToString());
                    carne.ValorDesconto = Convert.ToDecimal(item["Desconto"].ToString());
                    carne.InstrDesconto = item["InstrDesconto"].ToString();
                    carne.InstrJurosMulta = item["InstrJurosMulta"].ToString();

                    lstCane.Add(carne);
                }

                return lstCane;
            }
        }
    }
}
