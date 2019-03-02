using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class Tools
    {
        public static Model.EscolaDados DadosEscola()
        {
            return new Model.EscolaDados();
        }
        public static List<string> ListaAnoLetivo()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstAnoLetivoLista";
            cmd.Parameters.Clear();

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<string> lstAnoLetivo = new List<string>();
            foreach (DataRow item in dt.Rows) lstAnoLetivo.Add(item["AnoLetivo"].ToString());

            return lstAnoLetivo;
        }
        public static List<string> ListaTurma()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "cstTurmaLista";
            cmd.Parameters.Clear();

            OleDbDataAdapter adp = DB.DBAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            List<string> lstaTurma = new List<string>();
            foreach (DataRow item in dt.Rows) lstaTurma.Add(item["Turma"].ToString());

            return lstaTurma;
        }

        public class Parenteso
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }

            public static string GetCodigo(string decricao)
            {
                string codigParentesco = "";

                switch (decricao)
                {
                    case "Pai":
                        codigParentesco = "P";
                        break;
                    case "Mãe":
                        codigParentesco = "M";
                        break;
                    case "Irmão(ã)":
                        codigParentesco = "I";
                        break;
                    case "Avô(ó)":
                        codigParentesco = "A";
                        break;
                    case "Tio(a)":
                        codigParentesco = "T";
                        break;
                    case "Primo(a)":
                        codigParentesco = "R";
                        break;
                    case "Amigo(a)":
                        codigParentesco = "G";
                        break;
                    default:
                        break;
                }

                return codigParentesco;

            }
            public static string GetDescricao(string codigo)
            {
                string descricaoParentesco = "";

                switch (codigo)
                {
                    case "P":
                        descricaoParentesco = "Pai";
                        break;
                    case "M":
                        descricaoParentesco = "Mãe";
                        break;
                    case "I":
                        descricaoParentesco = "Irmão(ã)";
                        break;
                    case "A":
                        descricaoParentesco = "Avô(ó)";
                        break;
                    case "T":
                        descricaoParentesco = "Tio(a)";
                        break;
                    case "R":
                        descricaoParentesco = "Primo(a)";
                        break;
                    case "G":
                        descricaoParentesco = "Amigo(a)";
                        break;
                    default:
                        break;
                }

                return descricaoParentesco;
            }
            public static List<Parenteso> ListaParentesco()
            {
                return new List<Parenteso>
                {
                    new Parenteso {
                        Codigo = "P",
                        Descricao = "Pai"
                    },
                    new Parenteso {
                        Codigo = "M",
                        Descricao = "Mãe"
                    },
                new Parenteso {
                        Codigo = "I",
                        Descricao = "Irmão(ã)"
                    },
                new Parenteso {
                        Codigo = "A",
                        Descricao = "Avô(ó)"
                    },
                new Parenteso {
                        Codigo = "T",
                        Descricao = "Tio(a)"
                    },
                new Parenteso {
                        Codigo = "R",
                        Descricao = "Primo(a)"
                    },
                new Parenteso {
                        Codigo = "G",
                        Descricao = "Amigo(a)"
                    }
                };
            }
        }
        public class PeriodoLetivo
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }

            public static string GetCodigo(string decricao)
            {
                string codigPeriodoLetivo = "";

                switch (decricao)
                {
                    case "1º Bimestre":
                        codigPeriodoLetivo = "B1";
                        break;
                    case "2º Bimestre":
                        codigPeriodoLetivo = "B2";
                        break;
                    case "3º Bimestre":
                        codigPeriodoLetivo = "B3";
                        break;
                    case "4º Bimestre":
                        codigPeriodoLetivo = "B4";
                        break;
                    case "5º Bimestre":
                        codigPeriodoLetivo = "B5";
                        break;
                    case "6º Bimestre":
                        codigPeriodoLetivo = "B6";
                        break;
                    case "1º Trimestre":
                        codigPeriodoLetivo = "T1";
                        break;
                    case "2º Trimestre":
                        codigPeriodoLetivo = "T2";
                        break;
                    case "3º Trimestre":
                        codigPeriodoLetivo = "T3";
                        break;
                    case "4º Trimestre":
                        codigPeriodoLetivo = "T4";
                        break;
                    case "1º Semestre":
                        codigPeriodoLetivo = "S1";
                        break;
                    case "2º Semestre":
                        codigPeriodoLetivo = "S2";
                        break;
                    case "Ano Escolar":
                        codigPeriodoLetivo = "A0";
                        break;
                    default:
                        break;
                }

                return codigPeriodoLetivo;

            }
            public static string GetDescricao(string codigo)
            {
                string descricaoPeriodoLetivo = "";

                switch (codigo)
                {
                    case "B1":
                        descricaoPeriodoLetivo = "1º Bimestre";
                        break;
                    case "B2":
                        descricaoPeriodoLetivo = "2º Bimestre";
                        break;
                    case "B3":
                        descricaoPeriodoLetivo = "3º Bimestre";
                        break;
                    case "B4":
                        descricaoPeriodoLetivo = "4º Bimestre";
                        break;
                    case "B5":
                        descricaoPeriodoLetivo = "5º Bimestre";
                        break;
                    case "B6":
                        descricaoPeriodoLetivo = "6º Bimestre";
                        break;
                    case "T1":
                        descricaoPeriodoLetivo = "1º Trimestre";
                        break;
                    case "T2":
                        descricaoPeriodoLetivo = "2º Trimestre";
                        break;
                    case "T3":
                        descricaoPeriodoLetivo = "3º Trimestre";
                        break;
                    case "T4":
                        descricaoPeriodoLetivo = "4º Trimestre";
                        break;
                    case "S1":
                        descricaoPeriodoLetivo = "1º Semestre";
                        break;
                    case "S2":
                        descricaoPeriodoLetivo = "2º Semestre";
                        break;
                    case "A0":
                        descricaoPeriodoLetivo = "Ano Escolar";
                        break;
                    default:
                        break;
                }

                return descricaoPeriodoLetivo;
            }
            public static List<PeriodoLetivo> ListaPeriodoLetivo(bool ParaCadastro = false)
            {
                List<PeriodoLetivo> lstPeriodos = new List<PeriodoLetivo>();

                if (!ParaCadastro) lstPeriodos.Add( new PeriodoLetivo { Codigo = "%", Descricao = "Todos" });

                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B1", Descricao = "1º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B2", Descricao = "2º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B3", Descricao = "3º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B4", Descricao = "4º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B5", Descricao = "5º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "B6", Descricao = "6º Bimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "T1", Descricao = "1º Trimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "T2", Descricao = "2º Trimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "T3", Descricao = "3º Trimestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "S1", Descricao = "1º Semestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "S2", Descricao = "2º Semestre" });
                lstPeriodos.Add( new PeriodoLetivo { Codigo = "A0", Descricao = "Ano Escolar" });

                return lstPeriodos;
            }
        }
        public class ResultadoFinal
        {
            public string Codigo { get; set; }
            public string Descricao { get; set; }

            public static string GetCodigo(string decricao)
            {
                string codigParentesco = "";

                switch (decricao)
                {
                    case "Aprovado":
                        codigParentesco = "A";
                        break;
                    case "Reprovado":
                        codigParentesco = "R";
                        break;
                    default:
                        codigParentesco = "N";
                        break;
                }

                return codigParentesco;

            }
            public static string GetDescricao(string codigo)
            {
                string descricaoParentesco = "";

                switch (codigo)
                {
                    case "A":
                        descricaoParentesco = "Aprovador";
                        break;
                    case "R":
                        descricaoParentesco = "Reprovador";
                        break;
                    default:
                        descricaoParentesco = "Não Avaliado";
                        break;
                }

                return descricaoParentesco;
            }
            public static List<ResultadoFinal> ListaResultadoFinal()
            {
                return new List<ResultadoFinal>
                {
                    new ResultadoFinal {
                        Codigo = "A",
                        Descricao = "Aprovador"
                    },
                    new ResultadoFinal {
                        Codigo = "R",
                        Descricao = "Reprovador"
                    },
                new ResultadoFinal {
                        Codigo = "N",
                        Descricao = "Não Avaliado"
                    }
                };
            }
        }

    }

}
