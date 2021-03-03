using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Orientador

    {
        public int OrientadorID { get; set; }
        public string Nome { get; set; }
        public string Pseudonimo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Formacao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Funcao { get; set; }
        public DateTime DataAfastam { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }

        public void DadosOrientador(Int32 OrientadorIDPesquisar)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstOrientadorDados";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@OrientadorID", OrientadorIDPesquisar.ToString());

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                OrientadorID = Convert.ToInt32(dt.Rows[0]["OrientadorID"].ToString());
                Nome = dt.Rows[0]["Nome"].ToString();
                Pseudonimo = dt.Rows[0]["Pseudonimo"].ToString();
                if (dt.Rows[0]["DataNascimento"].ToString() != "") DataNascimento = Convert.ToDateTime(dt.Rows[0]["DataNascimento"].ToString());
                Formacao = dt.Rows[0]["Formacao"].ToString();
                if (dt.Rows[0]["DataAdmissao"].ToString() != "") DataAdmissao = Convert.ToDateTime(dt.Rows[0]["DataAdmissao"].ToString());
                Funcao = dt.Rows[0]["Funcao"].ToString();
                if (dt.Rows[0]["DataAfastam"].ToString() != "") DataAfastam = Convert.ToDateTime(dt.Rows[0]["DataAfastam"].ToString());
                RG = dt.Rows[0]["RG"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                Sexo = dt.Rows[0]["Sexo"].ToString();
                Endereco = dt.Rows[0]["Endereco"].ToString();
                Bairro = dt.Rows[0]["Bairro"].ToString();
                Cidade = dt.Rows[0]["Cidade"].ToString();
                CEP = dt.Rows[0]["CEP"].ToString();
                Telefone = dt.Rows[0]["Telefone"].ToString();
            }

        }
        public static List<Orientador> ListaOrientadores(string filtro = "%", bool IncluirTodos = false)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstOrientadorLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", "%" + filtro + "%");

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Orientador> lstOrientador = new List<Orientador>();

            if (IncluirTodos) lstOrientador.Add(new Orientador {OrientadorID = 0, Nome="Todos" });

            foreach (DataRow item in dt.Rows)
            {
                Orientador orientador = new Orientador();
                orientador.OrientadorID = Convert.ToInt32(item["OrientadorID"].ToString());
                orientador.Nome = item["Nome"].ToString();
                if (item["DataNascimento"].ToString() !="") orientador.DataNascimento = Convert.ToDateTime(item["DataNascimento"].ToString());
                orientador.Formacao = item["Formacao"].ToString();
                if (item["DataAdmissao"].ToString() != "") orientador.DataAdmissao = Convert.ToDateTime(item["DataAdmissao"].ToString());
                orientador.Funcao = item["Funcao"].ToString();
                if (item["DataAfastam"].ToString() != "") orientador.DataAfastam = Convert.ToDateTime(item["DataAfastam"].ToString());
                orientador.RG = item["RG"].ToString();
                orientador.CPF = item["CPF"].ToString();
                orientador.Sexo = item["Sexo"].ToString();
                orientador.Endereco = item["Endereco"].ToString();
                orientador.Bairro = item["Bairro"].ToString();
                orientador.Cidade = item["Cidade"].ToString();
                orientador.CEP = item["CEP"].ToString();
                orientador.Telefone = item["Telefone"].ToString();

                lstOrientador.Add(orientador);
            }

            return lstOrientador;
        }
        public void SalvarOrientador(string tipo)
        {
            string commandText = "";

            if (tipo == "U")
            {
                commandText = "UPDATE Orientadores ";
                commandText += "SET ";
                commandText += "Nome = @Nome, ";
                commandText += "Pseudonimo = @Pseudonimo, ";
                commandText += "DataNascimento = @DataNascimento, ";
                commandText += "Formacao = @Formacao, ";
                commandText += "DataAdmissao = @DataAdmissao, ";
                commandText += "Funcao = @Funcao, ";
                commandText += "DataAfastam = @DataAfastam, ";
                commandText += "RG = @RG, ";
                commandText += "CPF = @CPF, ";
                commandText += "Sexo = @Sexo, ";
                commandText += "Endereco = @Endereco, ";
                commandText += "Bairro = @Bairro, ";
                commandText += "Cidade = @Cidade, ";
                commandText += "CEP = @CEP, ";
                commandText += "Telefone = @Telefone ";
                commandText += "WHERE OrientadorID = @OrientadorID ";
            }
            else
            {
                commandText = "INSERT INTO Orientadores ";
                commandText += "(Nome, Pseudonimo, DataNascimento, Formacao, DataAdmissao, Funcao, DataAfastam, RG, CPF, Sexo, Endereco, Bairro, Cidade, CEP, Telefone) ";
                commandText += " VALUES ";
                commandText += "(@Nome, @Pseudonimo, @DataNascimento, @Formacao, @DataAdmissao, @Funcao, @DataAfastam, @RG, @CPF, @Sexo, @Endereco, @Bairro, @Cidade, @CEP, @Telefone)";
            }


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", Nome.ToString());
            cmd.Parameters.AddWithValue("@Pseudonimo", Pseudonimo.ToString());
            if (DataNascimento.Year < 1900) cmd.Parameters.AddWithValue("@DataNascimento", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
            cmd.Parameters.AddWithValue("@Formacao", Formacao.ToString());
            if (DataAdmissao.Year < 1900) cmd.Parameters.AddWithValue("@DataAdmissao", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataAdmissao", DataAdmissao);
            cmd.Parameters.AddWithValue("@Funcao", Funcao.ToString());
            if (DataAfastam.Year < 1900) cmd.Parameters.AddWithValue("@DataAfastam", DBNull.Value);
            else cmd.Parameters.AddWithValue("@DataAfastam", DataAfastam);
            cmd.Parameters.AddWithValue("@RG", RG.ToString());
            cmd.Parameters.AddWithValue("@CPF", CPF.ToString());
            cmd.Parameters.AddWithValue("@Sexo", Sexo.ToString());
            cmd.Parameters.AddWithValue("@Endereco", Endereco.ToString());
            cmd.Parameters.AddWithValue("@Bairro", Bairro.ToString());
            cmd.Parameters.AddWithValue("@Cidade", Cidade.ToString());
            cmd.Parameters.AddWithValue("@CEP", CEP.ToString());
            cmd.Parameters.AddWithValue("@Telefone", Telefone.ToString());
            if (tipo == "U") cmd.Parameters.AddWithValue("@OrientadorID", OrientadorID.ToString());

            DB.ExecCommand(cmd);

        }
        public void DeletarOrientador()
        {
            string commandText = "";

            commandText = "DELETE FROM Orientadores ";
            commandText += "WHERE OrientadorID = @OrientadorID ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@OrientadorID", OrientadorID.ToString());

            DB.ExecCommand(cmd);
        }
    }
}
