using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Responsavel
    {
        public int AlunoID { get; set; }
        public int TutorID { get; set; }
        public int TutorAlunoID { get; set; }
        public string RelacaoAluno { get; set; }
        public string RelacaoAlunoDescr { get { return Tools.Parenteso.GetDescricao(RelacaoAluno); } }
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

        private static List<Responsavel> _Responsaveis(int pAlunoID, string pNome, bool pApenasPagador = false)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstTutorRespLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", pNome);
            cmd.Parameters.AddWithValue("@AlunoID", pAlunoID);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Responsavel> lstResp = new List<Responsavel>();

            foreach (DataRow item in dt.Rows)
            {
                if (!pApenasPagador || (pApenasPagador && item["Pagador"].ToString() == "S"))
                {
                    Responsavel responsavel = new Responsavel();
                    responsavel.TutorID = Convert.ToInt32(item["TutorID"].ToString());
                    responsavel.TutorAlunoID = Convert.ToInt32("0" + item["TutorAlunoID"].ToString());
                    responsavel.Nome = item["Nome"].ToString();
                    if (item["DataNascimento"].ToString() != "") responsavel.DataNascimento = Convert.ToDateTime(item["DataNascimento"].ToString());
                    responsavel.RG = item["RG"].ToString();
                    responsavel.CPF = item["CPF"].ToString();
                    responsavel.Endereco = item["Endereco"].ToString();
                    responsavel.Bairro = item["Bairro"].ToString();
                    responsavel.Cidade = item["Cidade"].ToString();
                    responsavel.CEP = item["CEP"].ToString();
                    responsavel.Telefone = item["Telefone"].ToString();
                    responsavel.Sexo = item["Sexo"].ToString();
                    responsavel.Pagador = item["Pagador"].ToString();

                    lstResp.Add(responsavel);
                }
            }

            return lstResp;
        }
        public static List<Responsavel> ListaAlunosDoTutor(int pTutorID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunosDoTutor";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorID", pTutorID);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Responsavel> lstAlunosResp = new List<Responsavel>();

            foreach (DataRow item in dt.Rows)
            {

                Responsavel anulo = new Responsavel();
                anulo.TutorID = Convert.ToInt32(item["TutorID"].ToString());
                anulo.TutorAlunoID = Convert.ToInt32(item["TutorAlunoID"].ToString());
                anulo.Nome = item["NomeAluno"].ToString();
                anulo.RelacaoAluno = item["RelacaoAluno"].ToString();

                lstAlunosResp.Add(anulo);
            }

            return lstAlunosResp;
        }
        public void DadosRespAluno(Int32 TutorAlunoIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstRespAlunoDados";
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
        public void DadosResponsavel(Int32 TutorIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstResponsavelDados";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorID", TutorIDPesquisar.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TutorID = Convert.ToInt32(dt.Rows[0]["TutorID"].ToString());
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
        public static List<Responsavel> ListaResponsaveis(string filtro = "%")
        {
            return _Responsaveis(0, "%" + filtro + "%");
        }
        public static List<Responsavel> ListaResponsAluno(int pAlunoID, bool pApenasPagadoores)
        {
            return _Responsaveis(pAlunoID, "", pApenasPagadoores);
        }
        public static List<Responsavel> ListaRespPesquisa(string pNomeResp)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstTutorLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", "%" + pNomeResp + "%");

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Responsavel> lstResp = new List<Responsavel>();

            foreach (DataRow item in dt.Rows)
            {
                Responsavel responsavel = new Responsavel();
                responsavel.TutorID = Convert.ToInt32(item["TutorID"].ToString());
                responsavel.Nome = item["Nome"].ToString();
                if (item["DataNascimento"].ToString() != "") responsavel.DataNascimento = Convert.ToDateTime(item["DataNascimento"].ToString());
                responsavel.RG = item["RG"].ToString();
                responsavel.CPF = item["CPF"].ToString();
                responsavel.Endereco = item["Endereco"].ToString();
                responsavel.Bairro = item["Bairro"].ToString();
                responsavel.Cidade = item["Cidade"].ToString();
                responsavel.CEP = item["CEP"].ToString();
                responsavel.Telefone = item["Telefone"].ToString();
                responsavel.Sexo = item["Sexo"].ToString();

                lstResp.Add(responsavel);
            }

            return lstResp;
        }
        public void SalvarResponsavel(string tipo)
        {
            string commandText = "";
            if (tipo == "U")
            {
                commandText = "UPDATE Tutores ";
                commandText += "SET ";
                commandText += "Nome = @Nome, ";
                commandText += "DataNascimento = @DataNascimento, ";
                commandText += "RG = @RG, ";
                commandText += "CPF = @CPF, ";
                commandText += "Endereco = @Endereco, ";
                commandText += "Bairro = @Bairro, ";
                commandText += "Cidade = @Cidade, ";
                commandText += "CEP = @CEP, ";
                commandText += "Telefone = @Telefone, ";
                commandText += "Sexo = @Sexo ";
                commandText += "WHERE TutorID = @TutorID ";

            }
            else
            {
                commandText = "INSERT INTO Tutores ";
                commandText += "(Nome, DataNascimento, RG, CPF, Endereco, Bairro, Cidade, CEP, Telefone, Sexo) ";
                commandText += "VALUES ";
                commandText += "(@Nome, @DataNascimento, @RG, @CPF, @Endereco, @Bairro, @Cidade, @CEP, @Telefone, @Sexo)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", Nome.ToString());
            if (DataNascimento.Year < 1900) cmd.Parameters.AddWithValue("@DataNascimento", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
            cmd.Parameters.AddWithValue("@RG", RG.ToString());
            cmd.Parameters.AddWithValue("@CPF", CPF.ToString());
            cmd.Parameters.AddWithValue("@Endereco", Endereco.ToString());
            cmd.Parameters.AddWithValue("@Bairro", Bairro.ToString());
            cmd.Parameters.AddWithValue("@Cidade", Cidade.ToString());
            cmd.Parameters.AddWithValue("@CEP", CEP.ToString());
            cmd.Parameters.AddWithValue("@Telefone", Telefone.ToString());
            cmd.Parameters.AddWithValue("@Sexo", Sexo.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@TutorID", TutorID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarResponsavel()
        {
            string commandText = "";
            commandText = "DELETE FROM Tutores ";
            commandText += "WHERE TutorID = @TutorID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorID", TutorID.ToString());

            DB.ExecCommand(cmd);
        }
        public void SalvarResponsavelAluno(string tipo)
        {
            string commandText = "";
            if (tipo == "U")
            {
                commandText = "UPDATE TutoresAlunos ";
                commandText += "SET ";
                commandText += "RelacaoAluno = @RelacaoAluno, ";
                commandText += "Pagador = @Pagador, ";
                commandText += "PodePegarEscola = @PodePegarEscola ";
                commandText += "WHERE TutorAlunoID = @TutorAlunoID ";

            }
            else
            {
                commandText = "INSERT INTO TutoresAlunos ";
                commandText += "(RelacaoAluno, Pagador, PodePegarEscola, AlunoID, TutorID) ";
                commandText += "VALUES ";
                commandText += "(@RelacaoAluno, @Pagador, @PodePegarEscola, @AlunoID, @TutorID)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@RelacaoAluno", Tools.Parenteso.GetCodigo(RelacaoAluno.ToString()));
            cmd.Parameters.AddWithValue("@Pagador", Pagador.ToString());
            cmd.Parameters.AddWithValue("@PodePegarEscola", PodePegarEscola.ToString());
            if (tipo == "I")
            {
                cmd.Parameters.AddWithValue("@AlunoID", AlunoID.ToString());
                cmd.Parameters.AddWithValue("@TutorID", TutorID.ToString());
            }
            else cmd.Parameters.AddWithValue("@TutorAlunoID", TutorAlunoID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarResponsavelAluno()
        {
            string commandText = "";
            commandText = "DELETE FROM TutoresAlunos ";
            commandText += "WHERE TutorAlunoID = @TutorAlunoID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TutorAlunoID", TutorAlunoID.ToString());

            DB.ExecCommand(cmd);
        }
    }
}
