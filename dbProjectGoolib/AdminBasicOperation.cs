using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public static class AdminBasicOperation
    {

        private static string name;
        private static string real_name;
        private static string passwords;

        public static string deleteUser(int userID,int adminID,bool ifDelete)
        {
            string deleteSQL = "update users set is_deleted='Y' where id=:userID";
            OracleCommand deleteCmd = new OracleCommand(deleteSQL,DBConnection.oracleConnection);
            deleteCmd.Parameters.Add("userID",OracleType.Char);
            deleteCmd.Parameters["userID"].Value = userID;
            writeDeleteLog(userID, adminID,ifDelete);

            return deleteCmd.ExecuteNonQuery().ToString() + " rows changed.";
        }

        public static string resetPassword(int userID,int adminID)
        {
            string newPassword = ToMD5("123456");
            string resetSQL = "update users set passwords=:password where id=:userID";
            OracleCommand resetCmd = new OracleCommand(resetSQL, DBConnection.oracleConnection);
            resetCmd.Parameters.Add("password", OracleType.Char);
            resetCmd.Parameters.Add("userID", OracleType.VarChar);
            resetCmd.Parameters["password"].Value = newPassword;
            resetCmd.Parameters["userID"].Value = userID;
            writeResetLog(userID, adminID);
            return resetCmd.ExecuteNonQuery().ToString ()+" got influenced.";
            
        }

        private static string ToMD5(string str)//密码加密
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str + "DM", "md5").ToLower();
        }

        public static void setAdmin(int userID,int adminID)
        {
            string getInfoSQL = "select name,real_name,passwords from users where id=:userID";
            OracleCommand getInfoCmd = new OracleCommand(getInfoSQL,DBConnection.oracleConnection);
            getInfoCmd.Parameters.Add("userID", OracleType.VarChar);
            getInfoCmd.Parameters["userID"].Value = userID;
            OracleDataReader reader = getInfoCmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader.GetString(0);
                real_name = reader.GetString(1);
                passwords = reader.GetString(2);

            }

            string insertAdminSQL = "insert into administrators(name,real_name,passwords) values(:name,:real_name,:passwords)";
            OracleCommand insertAdminCmd = new OracleCommand(insertAdminSQL, DBConnection.oracleConnection);
            insertAdminCmd.Parameters.Add("name", OracleType.VarChar);
            insertAdminCmd.Parameters["name"].Value = name;
            insertAdminCmd.Parameters.Add("real_name", OracleType.VarChar);
            insertAdminCmd.Parameters["real_name"].Value = real_name;
            insertAdminCmd.Parameters.Add("passwords", OracleType.Char);
            insertAdminCmd.Parameters["passwords"].Value = passwords;
            insertAdminCmd.ExecuteNonQuery();

            deleteUser(userID,adminID,false);

        }

        public static string AdminChangePassword(string password,string adminname)
        {
            string newPassword = ToMD5(password);
            string resetSQL = "update administrators set passwords=:password where name=:adminname";
            OracleCommand resetCmd = new OracleCommand(resetSQL, DBConnection.oracleConnection);
            resetCmd.Parameters.Add("password", OracleType.Char);
            resetCmd.Parameters.Add("adminname", OracleType.VarChar);
            resetCmd.Parameters["password"].Value = newPassword;
            resetCmd.Parameters["adminname"].Value = adminname;
            return resetCmd.ExecuteNonQuery().ToString() + " got influenced.";
        }

        public static string AdminChangePassword(string password, int adminID)
        {
            string newPassword = ToMD5(password);
            string resetSQL = "update administrators set passwords=:password where id=:adminID";
            OracleCommand resetCmd = new OracleCommand(resetSQL, DBConnection.oracleConnection);
            resetCmd.Parameters.Add("password", OracleType.Char);
            resetCmd.Parameters.Add("adminid", OracleType.VarChar);
            resetCmd.Parameters["password"].Value = newPassword;
            resetCmd.Parameters["adminid"].Value = adminID;
            return resetCmd.ExecuteNonQuery().ToString() + " got influenced.";
        }

        public static string writeDeleteLog(int userID, int adminID,bool ifDelete)
        {
            if (ifDelete == false)
            {
                return "No Log";
            }
            string insertLogSQL = "insert into deletelogs(user_id,admin_id,delete_date) values(:userID,:adminID,sysdate)";
            OracleCommand insertLogCmd = new OracleCommand(insertLogSQL, DBConnection.oracleConnection);
            insertLogCmd.Parameters.Add("userID", OracleType.Int32);
            insertLogCmd.Parameters["userID"].Value = userID;
            insertLogCmd.Parameters.Add("adminID", OracleType.Int32);
            insertLogCmd.Parameters["adminID"].Value = adminID;

            return insertLogCmd.ExecuteNonQuery().ToString() + " is inserted!";
        }

        public static string writeResetLog(int userID, int adminID)
        {
            string insertLogSQL = "insert into resetlogs(user_id,admin_id,reset_date) values(:userID,:adminID,sysdate)";
            OracleCommand insertLogCmd = new OracleCommand(insertLogSQL, DBConnection.oracleConnection);
            insertLogCmd.Parameters.Add("userID", OracleType.Int32);
            insertLogCmd.Parameters["userID"].Value = userID;
            insertLogCmd.Parameters.Add("adminID", OracleType.Int32);
            insertLogCmd.Parameters["adminID"].Value = adminID;

            return insertLogCmd.ExecuteNonQuery().ToString() + " is resetd!";
        }

    }
}
