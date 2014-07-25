using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string constr = "Data Source=10.60.42.214/Library;User Id=SCOTT;Password=googlecamp;";
            OracleConnection oraCon = new OracleConnection(constr);
            oraCon.Open();
            string sqlCon = "select name from users";
            OracleCommand oracmd = new OracleCommand(sqlCon, oraCon);
            OracleDataReader reader = oracmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }

             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new basic());
        }
    }
}
