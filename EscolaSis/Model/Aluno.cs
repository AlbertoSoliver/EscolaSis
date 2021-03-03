using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EscolaSis.Model
{
    class Aluno
    {
        public int AlunoID { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NumMatricula { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascim { get; set; }
        public int Idade
        {
            get
            {
                return CalculaIdade(DataNascim);
            }
        }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }

        public Aluno() { }

        public static int UltimoAlunoIDCriado()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MAX(AlunoID) AS NovoID FROM Alunos";
            cmd.Parameters.Clear();

            int IDCriado = 0;

            OleDbDataAdapter adp = DB.DBAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                IDCriado = Convert.ToUInt16(dt.Rows[0][0].ToString());
            }
            return IDCriado;
        }
        public static int CalculaIdade(DateTime DtNascimento)
        {
            int idade = DateTime.Now.Year - DtNascimento.Year;
            if (DateTime.Now.Month < DtNascimento.Month)
            {
                idade -= 1;
            }
            return idade;
        }
        public static List<Aluno> ListarAlunosPesquisa(string ArgPesq, bool IncluirTodosOpc = false)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NomeAluno", "%" + ArgPesq + "%");

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            List<Aluno> lstAluno = new List<Aluno>();

            if (IncluirTodosOpc) lstAluno.Add(new Aluno { AlunoID = 0, NumMatricula = "", Nome = "Todos" });

            foreach (DataRow item in dt.Rows)
            {
                lstAluno.Add(new Aluno
                {
                    AlunoID = Convert.ToInt32(item["AlunoID"].ToString()),
                    NumMatricula = item["NumMatricula"].ToString(),
                    Nome = item["Nome"].ToString()
                });
            }

            return lstAluno;

        }
        public void DadosAluno(Int32 AlunoIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoDados";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", AlunoIDPesquisar.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                AlunoID = Convert.ToInt32(dt.Rows[0]["AlunoID"].ToString());
                NumMatricula = dt.Rows[0]["NumMatricula"].ToString();
                DataCadastro = Convert.ToDateTime(dt.Rows[0]["DataCadastro"].ToString());
                Nome = dt.Rows[0]["Nome"].ToString();
                if (dt.Rows[0]["DataNascim"].ToString() != "") DataNascim = Convert.ToDateTime(dt.Rows[0]["DataNascim"].ToString());
                RG = dt.Rows[0]["RG"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                Sexo = dt.Rows[0]["Sexo"].ToString();
                Endereco = dt.Rows[0]["Endereco"].ToString();
                Bairro = dt.Rows[0]["Bairro"].ToString();
                Cidade = dt.Rows[0]["Cidade"].ToString();
                CEP = dt.Rows[0]["CEP"].ToString();
                Telefone = dt.Rows[0]["Telefone"].ToString();
                Foto = dt.Rows[0]["Foto"].ToString();

            }

        }
        public void SalvarAluno(string tipo)
        {
            string commandText = "";
            string numMatric = "";

            if (tipo == "U")
            {
                if (NumMatricula.ToString() == "") numMatric = (DataCadastro.Year * 10000 + AlunoID).ToString();
                else numMatric = NumMatricula.ToString();
                commandText = "UPDATE Alunos ";
                commandText += "SET ";
                commandText += "Nome = @Nome, ";
                commandText += "NumeroMatricula = @NumeroMatricula, ";
                commandText += "DataNascim = @DataNascim, ";
                commandText += "RG = @RG, ";
                commandText += "CPF = @CPF, ";
                commandText += "Sexo = @Sexo, ";
                commandText += "Endereco = @Endereco, ";
                commandText += "Bairro = @Bairro, ";
                commandText += "Cidade = @Cidade, ";
                commandText += "CEP = @CEP, ";
                commandText += "Telefone = @Telefone ";
                commandText += "WHERE AlunoID = @AlunoID ";
            }
            else
            {
                if (NumMatricula.ToString() == "") numMatric = (DataCadastro.Year * 10000 + UltimoAlunoIDCriado() + 1).ToString();
                else numMatric = NumMatricula.ToString();
                commandText = "INSERT INTO Alunos ";
                commandText += "(Nome, NumeroMatricula, DataNascim, RG, CPF, Sexo, Endereco, Bairro, Cidade, CEP, Telefone) ";
                commandText += " VALUES ";
                commandText += "(@Nome, @NumeroMatricula, @DataNascim, @RG, @CPF, @Sexo, @Endereco, @Bairro, @Cidade, @CEP, @Telefone)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", Nome.ToString());
            cmd.Parameters.AddWithValue("@NumeroMatricula", numMatric);
            if (DataNascim.Year < 1900) cmd.Parameters.AddWithValue("@DataNascim", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataNascim", DataNascim);
            cmd.Parameters.AddWithValue("@RG", RG.ToString());
            cmd.Parameters.AddWithValue("@CPF", CPF.ToString());
            cmd.Parameters.AddWithValue("@Sexo", Sexo.ToString());
            cmd.Parameters.AddWithValue("@Endereco", Endereco.ToString());
            cmd.Parameters.AddWithValue("@Bairro", Bairro.ToString());
            cmd.Parameters.AddWithValue("@Cidade", Cidade.ToString());
            cmd.Parameters.AddWithValue("@CEP", CEP.ToString());
            cmd.Parameters.AddWithValue("@Telefone", Telefone.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@AlunoID", AlunoID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarAluno()
        {
            string commandText = "";

            commandText = "DELETE FROM Alunos ";
            commandText += "WHERE AlunoID = @AlunoID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", AlunoID.ToString());

            DB.ExecCommand(cmd);
        }
        public static List<Matricula> ListarMatriculasAluno(int alunoID, string anoLetivo = "%", string periodoLetivo = "%")
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoMatriculas";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);
            cmd.Parameters.AddWithValue("@AnoLetivoMatric", anoLetivo);
            cmd.Parameters.AddWithValue("@CodigoPeriodoMatr", periodoLetivo);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Matricula> lstMatric = new List<Matricula>();

            foreach (DataRow item in dt.Rows)
            {
                lstMatric.Add(new Matricula
                {
                    MatriculaID = Convert.ToInt32(item["MatriculaID"].ToString()),
                    Disciplina = item["Disciplina"].ToString(),
                    AnoLetivo = item["AnoLetivo"].ToString(),
                    CodigoPeriodo = item["CodigoPeriodoMatr"].ToString(),
                    OrientadorID = Convert.ToInt32(dt.Rows[0]["OrientadorID"].ToString()),
                    NomeOrientador = item["NomeOrientador"].ToString(),
                    Turma = item["Turma"].ToString(),
                    RelatorioAtividade = item["RelatorioAtividade"].ToString(),
                    ResultadoFinal = item["ResultadoFinal"].ToString()
                });
            }

            return lstMatric;

        }
        public static List<Mensalidade> ListarMensalidadesAluno(int alunoID, string anoRef, string sitPag = "%")
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoMensalidades";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);
            cmd.Parameters.AddWithValue("@SitPagto", sitPag);
            cmd.Parameters.AddWithValue("@AnoRef", anoRef == "" ? "&" : anoRef);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Mensalidade> lstMatric = new List<Mensalidade>();

            foreach (DataRow item in dt.Rows)
            {
                Mensalidade mensal = new Mensalidade();
                mensal.AlunoID = Convert.ToInt32(item["AlunoID"].ToString());
                mensal.MensalidadeID = Convert.ToInt32(item["MensalidadeID"].ToString());
                mensal.TutorAlunoID = Convert.ToInt32(item["TutorAlunoID"].ToString());
                mensal.RespPagto = item["RespPagto"].ToString();
                mensal.Descricao = item["Descricao"].ToString();
                mensal.MesAnoRefer = item["MesAnoRefer"].ToString();
                if (item["DataEmissao"].ToString() != "") mensal.DataEmissao = Convert.ToDateTime(item["DataEmissao"].ToString());
                if (item["Vencimento"].ToString() != "") mensal.Vencimento = Convert.ToDateTime(item["Vencimento"].ToString());
                mensal.ValorMensalidade = Convert.ToDecimal(item["ValorMensalidade"].ToString());
                if (item["DataPagto"].ToString() != "") mensal.DataPagto = Convert.ToDateTime(item["DataPagto"].ToString());
                mensal.Desconto = Convert.ToDecimal(item["Desconto"].ToString());
                mensal.JurosMulta = Convert.ToDecimal(item["JurosMulta"].ToString());
                mensal.ValorPago = Convert.ToDecimal(item["ValorPago"].ToString());
                mensal.FormaPagto = item["FormaPagto"].ToString();
                mensal.SituacaoPagto = item["SitPagto"].ToString();

                lstMatric.Add(mensal);
            }

            return lstMatric;

        }
        public static List<Responsavel> ListarResponsaveisAluno(int alunoID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoResponsaveis";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Responsavel> lstMatric = new List<Responsavel>();

            foreach (DataRow item in dt.Rows)
            {
                lstMatric.Add(new Responsavel
                {
                    AlunoID = Convert.ToInt32(item["AlunoID"].ToString()),
                    TutorID = Convert.ToInt32(item["TutorID"].ToString()),
                    TutorAlunoID = Convert.ToInt32(item["TutorAlunoID"].ToString()),
                    RelacaoAluno = item["RelacaoAluno"].ToString(),
                    Pagador = item["Pagador"].ToString(),
                    PodePegarEscola = item["PodePegarEscola"].ToString(),
                    Nome = item["Nome"].ToString(),
                    RG = item["RG"].ToString(),
                    CPF = item["CPF"].ToString(),
                    Endereco = item["Endereco"].ToString(),
                    Bairro = item["Bairro"].ToString(),
                    Cidade = item["Cidade"].ToString(),
                    CEP = item["CEP"].ToString(),
                    Telefone = item["Telefone"].ToString(),
                    Sexo = item["Sexo"].ToString()
                });
            }

            return lstMatric;

        }
    }

}
