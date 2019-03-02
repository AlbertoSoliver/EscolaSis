namespace EscolaSis.Model
{
    class EscolaDados
    {
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


        public EscolaDados()
        {
            _NomeEscola = "";
            _CNPJ = "";
            _Endereco = "";
            _Bairro = "";
            _Cidade = "";
            _CEP = "";
            _PeriodoLetivoPadrao = "A0";
        }

    }
}
