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

        public List<Orientador> ListaOrientadores(string filtro = "%")
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstOrientadorLista";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", filtro);

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<Orientador> lstOrientador = new List<Orientador>();

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
    }
}
