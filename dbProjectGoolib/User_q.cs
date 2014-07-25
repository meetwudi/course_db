using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    public class User
    {
        private string userName;
        
        public User()
        {
            this.userName = "";
        }

        public string Login(string iptUserName,string iptPassword)
        {
            if (DBConnection.Connected == false)
            {
                return "Not Connected";
            }
            string logInSQL = "select name,passwords from USERS where NAME='" + iptUserName + "'";
            DBConnection.oracleConnection.Open();
            OracleCommand logInCmd = new OracleCommand(logInSQL,DBConnection.oracleConnection);
            OracleDataReader reader = logInCmd.ExecuteReader();
            
            
            if (reader.Read())
            {
                if (reader.GetString(1) == iptPassword)
                {
                    DBConnection.oracleConnection.Close();
                    this.userName = iptUserName;
                    return "Succeed";
                }
                else 
                {
                    DBConnection.oracleConnection.Close();
                    return "Password Error";
                }
          
            }
            else
            {
                DBConnection.oracleConnection.Close();
                return "Username Error";
            }
            
        }   
    }
}
