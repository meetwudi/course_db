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
        static bool connected;
        static public bool Connected
        {
            get { return connected; }
        }

        static public OracleConnection oracleConnection;

        static DBConnection()
        {
            connected = false;
            string constr = "Data Source=10.60.42.214/Library;User Id=SCOTT;Password=googlecamp;";
            oracleConnection = new OracleConnection(constr);
            try
            {
                oracleConnection.Open();
                connected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Database Connection Fail");
                Console.WriteLine(e.Message);
                connected = false;
            }
            finally
            {
                oracleConnection.Close();
            }
        }
    }
}
