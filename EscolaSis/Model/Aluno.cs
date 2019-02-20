﻿using System;
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
        public string NumMatricula { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascim { get; set; }
        public int Idade
        {
            get
            {
                int idade = DateTime.Now.Year - DataNascim.Year;
                if (DateTime.Now.Month >= DataNascim.Month)
                {
                    idade += 1;
                }
                return idade;
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

        public static List<Aluno> ListarAlunosPesquisa(string ArgPesq)
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

        public static List<Matricula> ListarMatriculasAluno(int alunoID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoMatriculas";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);

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
                    PeriodoMatriculaID = Convert.ToInt32(item["PeriodoMatriculaID"].ToString()),
                    OrientadorID = Convert.ToInt32(dt.Rows[0]["OrientadorID"].ToString()),
                    NomeOrientador = item["NomeOrientador"].ToString(),
                    Turma = item["Turma"].ToString(),
                    RelatorioAtividade = item["RelatorioAtividade"].ToString(),
                    ResultadoFinal = item["ResultadoFinal"].ToString()
                });
            }

            return lstMatric;

        }

        public static List<Mensalidade> ListarMensalidadesAluno(int alunoID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAlunoMensalidades";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AlunoID", alunoID);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Mensalidade> lstMatric = new List<Mensalidade>();

            foreach (DataRow item in dt.Rows)
            {
                lstMatric.Add(new Mensalidade
                {
                    AlunoID = Convert.ToInt32(item["AlunoID"].ToString()),
                    MensalidadeID = Convert.ToInt32(item["MensalidadeID"].ToString()),
                    TutorAlunoID = Convert.ToInt32(item["TutorAlunoID"].ToString()),
                    RespPagto = item["RespPagto"].ToString(),
                    Descricao = item["Descricao"].ToString(),
                    MesAnoRefer = item["MesAnoRefer"].ToString(),
                    DataEmissao = Convert.ToDateTime(item["DataEmissao"].ToString()),
                    Vencimento = Convert.ToDateTime(item["Vencimento"].ToString()),
                    ValorMensalidade = Convert.ToDecimal(item["ValorMensalidade"].ToString()),
                    DataPagto = Convert.ToDateTime(item["DataPagto"].ToString()),
                    Desconto = Convert.ToDecimal(item["Desconto"].ToString()),
                    JurosMulta = Convert.ToDecimal(item["JurosMulta"].ToString()),
                    ValorPago = Convert.ToDecimal(item["ValorPago"].ToString()),
                    FormaPagto = item["FormaPagto"].ToString()
                });
            }

            return lstMatric;

        }

        public static OleDbDataAdapter CreateCustomerAdapter(
        OleDbConnection connection)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command;

            // Create the SelectCommand.
            command = new OleDbCommand("SELECT CustomerID FROM Customers " +
                "WHERE Country = ? AND City = ?", connection);

            command.Parameters.Add("Country", OleDbType.VarChar, 15);
            command.Parameters.Add("City", OleDbType.VarChar, 15);

            adapter.SelectCommand = command;

            // Create the InsertCommand.
            command = new OleDbCommand(
                "INSERT INTO Customers (CustomerID, CompanyName) " +
                "VALUES (?, ?)", connection);

            command.Parameters.Add(
                "CustomerID", OleDbType.Char, 5, "CustomerID");
            command.Parameters.Add(
                "CompanyName", OleDbType.VarChar, 40, "CompanyName");

            adapter.InsertCommand = command;
            return adapter;
        }
    }
}
