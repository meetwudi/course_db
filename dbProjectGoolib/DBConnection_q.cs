using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    public static class DBConnection
    {
        static public bool Connected
        {
            get { return oracleConnection.State != ConnectionState.Closed; }
        }

        static public OracleConnection oracleConnection;

        static DBConnection()
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["dbProjectGoolib.Properties.Settings.ConnectionString"].ToString();
            // "Data Source=10.60.42.214/Library;User Id=SCOTT;Password=googlecamp;";
            oracleConnection = new OracleConnection(constr);
            try
            {
                oracleConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("failed to connect the database");
                Console.WriteLine(e.Message);
            }
        }
    }
}
