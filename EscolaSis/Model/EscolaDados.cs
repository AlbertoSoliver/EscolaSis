using System;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class EscolaDados
    {
        private string _RazaoSocial;
        public string RazaoSocial
        {
            get { return _RazaoSocial; }
            set { _RazaoSocial = value; }
        }
        private string _NomeEscola;
        public string NomeEscola
        {
            get { return _NomeEscola; }
            set { _NomeEscola = value; }
        }

        private string _CNPJ;
        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        private string _Endereco;
        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        private string _Bairro;
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }

        private string _Cidade;
        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }

        private string _CEP;
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }
        private string _PeriodoLetivoPadrao;

        public string PeriodoLetivoPadrao
        {
            get { return _PeriodoLetivoPadrao; }
            set { _PeriodoLetivoPadrao = value; }
        }
        private decimal _TaxaDesconto;

        public decimal TaxaDesconto
        {
            get { return _TaxaDesconto; }
            set { _TaxaDesconto = value; }
        }
        private decimal _TaxaJuros;

        public decimal TaxaJuros
        {
            get { return _TaxaJuros; }
            set { _TaxaJuros = value; }
        }
        private decimal _TaxaMulta;

        public decimal TaxaMulta
        {
            get { return _TaxaMulta; }
            set { _TaxaMulta = value; }
        }

        public EscolaDados()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstEscola";
            cmd.Parameters.Clear();

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                _RazaoSocial = "Joelma Ferreira Sena-ME";
                _NomeEscola = "Escola Rabiscando";
                _CNPJ = "12.366.573/0001-12";
                _Endereco = "R. Marechal Deodoro da Fonseca n.293";
                _Bairro = "Folga";
                _Cidade = "Ruy Barbosa - BA";
                _CEP = "46.800-000";
                _PeriodoLetivoPadrao = "A0";
                _TaxaDesconto = Convert.ToDecimal(dt.Rows[0]["Desconto"].ToString());
                _TaxaMulta = Convert.ToDecimal(dt.Rows[0]["Multa"].ToString());
                _TaxaJuros = Convert.ToDecimal(dt.Rows[0]["Juros"].ToString());
            }

        }
        public void SalvarEscola()
        {
            string commandText = "";


                commandText = "UPDATE Escola ";
                commandText += "SET ";
                commandText += "Desconto = @Desconto, ";
                commandText += "Multa = @Multa, ";
                commandText += "Juros = @Juros ";

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = commandText;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Desconto", TaxaDesconto);
            cmd.Parameters.AddWithValue("@Multa", TaxaMulta);
            cmd.Parameters.AddWithValue("@Juros", TaxaJuros);

            DB.ExecCommand(cmd);

        }

    }
}
