using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace EscolaSis.Model
{
    class DB
    {
        public static OleDbDataAdapter DBAdapter(OleDbCommand Cmd)
        {
            OleDbDataAdapter adp;
            string strConnectionString = ConfigurationManager.ConnectionStrings["DBEscolaSis"].ToString();
            OleDbConnection cn = new OleDbConnection(strConnectionString);
            cn.Open();
            Cmd.Connection = cn;
            try
            {
                adp = new OleDbDataAdapter(Cmd);
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return adp;
        }

        public static void ExecCommand(OleDbCommand Cmd)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["DBEscolaSis"].ToString();
            OleDbConnection cn = new OleDbConnection(strConnectionString);
            cn.Open();
            Cmd.Connection = cn;
            try
            {
                int vsl = Cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }

}
