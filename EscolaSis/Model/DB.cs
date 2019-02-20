using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class DB
    {

        public static OleDbDataAdapter DBAdapter(OleDbCommand Cmd)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["DBEscolaSis"].ToString();
            OleDbConnection cn;
            cn = new OleDbConnection(strConnectionString);
            cn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(Cmd);
            Cmd.Connection = cn;

            return adp;
        }


    }

}
