using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Security.Cryptography;


namespace dbProjectGoolib
{
    static public partial class User
    {
        //变量
        static private string userName;
        static private bool isAdmin;
        static private int userId;


        //访问器
        public static string UserName
        {
            get { return User.userName; }
        }
        
        public static bool IsAdmin
        {
            get { return User.isAdmin; }
        }

        public static bool Logged
        {
            get { return User.userId==-1; }
        }

        public static int UserId
        {
            get { return User.userId; }
        }

        //构造函数
        static User()
        {
            UserClear();
        }

        public static string ToMD5(string str)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str+"DM", "md5").ToLower();
        }

        //普通函数
        static public void UserClear()
        {
            userName = "";
            userId = -1;
            isAdmin = false;
        }

        static public void Impersonate(Int32 uid, string name, bool admin)
        {
            userId = uid;
            userName = name;
            isAdmin = admin;
        }

        static public int getUserIdByName(string userName)
        {
            string selectSql = "select id from users where name=:nnnn";
            OracleCommand selectCmd = new OracleCommand(selectSql, DBConnection.oracleConnection);
            selectCmd.Parameters.Add("nnnn", OracleType.VarChar);
            selectCmd.Parameters["nnnn"].Value = userName;
            OracleDataReader reader = selectCmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            else
            {
                return -1;
            }
        }

        static public string Login(string iptUserName,string iptPassword,bool iptIsAdmin)
        {
            if (DBConnection.Connected == false)
            {
                return "Not Connected";
            }
            string tableName;
            if (iptIsAdmin)
            {
                tableName= "administrators";
            }else
            {
                tableName = "users";
            }
           /*
            *旧版语句 
            *string logInSQL = "select name,passwords from "+tableName+" where name='" + iptUserName + "'";
            *OracleCommand logInCmd = new OracleCommand(logInSQL,DBConnection.oracleConnection);
            */
            string logInSQL = "select id,name,passwords,is_deleted from "+tableName+" where name=:username";
            if (iptIsAdmin)
            {
                logInSQL = "select id,name,passwords from " + tableName + " where name=:username";
            }
            OracleCommand logInCmd = new OracleCommand(logInSQL,DBConnection.oracleConnection);
            logInCmd.Parameters.Add("username", OracleType.VarChar);
            logInCmd.Parameters["username"].Value = iptUserName;
            OracleDataReader reader = logInCmd.ExecuteReader();
            

            if (reader.Read())
            {
                if (!iptIsAdmin)
                {
                    //管理员不错在isDeleted
                    if (reader.GetString(3) == "Y")
                    {
                        return "Account Unavailable";
                    }
                }
                if (reader.GetString(2) == ToMD5(iptPassword))
                {
                    userName = iptUserName;
                    isAdmin = iptIsAdmin;
                    userId = reader.GetInt32(0);
                    return "Succeed";
                }
                else 
                {
                    return "Password Error";
                }
            }
            else
            {
                return "Username Error";
            }
            
        }

        static public string regist(string[] iptInformation)
        {
            if (DBConnection.Connected == false)
            {
                return "Not Connected";
            }

            if (Login(iptInformation[0],"",false) != "Username Error")
            {
                //借用Login非法版判断用户是否已经存在
                //如果已存在
                return "UserName Already Exist";
            }
            /*
            string insertSQL = "insert into users(name,passwords,real_name,phone_number,email) values (";
            for(int i=0;i<5;++i)
            {
                insertSQL = insertSQL + "'" + iptInformation[i] + "',";
            }
            insertSQL=insertSQL.Remove(insertSQL.Length-1);
            insertSQL += ")";
            */
            string insertSQL = "insert into users(name,passwords,real_name,phone_number,email) values (:name,:passwords,:real_name,:phone_num,:email)";
            OracleCommand insertCmd = new OracleCommand(insertSQL, DBConnection.oracleConnection);
            insertCmd.Parameters.Add("name", OracleType.VarChar);
            insertCmd.Parameters.Add("passwords", OracleType.Char);
            insertCmd.Parameters.Add("real_name", OracleType.VarChar);
            insertCmd.Parameters.Add("phone_num", OracleType.VarChar);
            insertCmd.Parameters.Add("email", OracleType.VarChar);

            insertCmd.Parameters["name"].Value = iptInformation[0];
            insertCmd.Parameters["passwords"].Value = ToMD5(iptInformation[1]);
            insertCmd.Parameters["real_name"].Value = iptInformation[2];
            insertCmd.Parameters["phone_num"].Value = iptInformation[3];
            insertCmd.Parameters["email"].Value = iptInformation[4];

            return insertCmd.ExecuteNonQuery().ToString()+" got influenced";
        }

        static public string UpdateUserInformation(int UserID, string NewPassWord, string NewRealName, string NewPhoneNumber, string NewEMail)
        {
            #region connection and id check
            if (DBConnection.Connected == false)
            {
                return "Not Connected";
            }
            if (UserID == -1)
            {
                return "ID Error-Not Logged";
            }
            #endregion 
            string result="";
            #region check if id exist
            OracleCommand idExistCheckCMD = new OracleCommand("select * from users where id=:userid", DBConnection.oracleConnection);
            idExistCheckCMD.Parameters.Add("userid", OracleType.Int32);
            idExistCheckCMD.Parameters["userid"].Value = UserID;
            OracleDataReader idExistCheckReader = idExistCheckCMD.ExecuteReader();
            if (idExistCheckReader.Read())
            {

            }
            else 
            {
                return "Id Not Exist";
            }
            #endregion
            if (NewPassWord != "" && NewPassWord != null)
            {
                updateIterm(UserID, "passwords", OracleType.Char, ToMD5( NewPassWord));
            }
            if (NewRealName != "" && NewRealName != null)
            {
                updateIterm(UserID, "real_name", OracleType.VarChar, NewRealName);
            }
            if (NewPhoneNumber != "" && NewPhoneNumber != null)
            {
                updateIterm(UserID, "phone_number", OracleType.VarChar, NewPhoneNumber);
            }
            if (NewEMail != ""&& NewEMail!=null)
            {
                updateIterm(UserID, "email", OracleType.VarChar, NewEMail);
            }
            return result;

        }

        static private void updateIterm(int userId,string iterm,OracleType oratype ,string value)
        {
            string updateSQL = "update users set " + iterm + "=:value where id=:userid";
            OracleCommand oraCmd = new OracleCommand(updateSQL, DBConnection.oracleConnection);
            oraCmd.Parameters.Add("value",oratype);
            oraCmd.Parameters.Add("userid",OracleType.Int32);
            oraCmd.Parameters["value"].Value = value;
            oraCmd.Parameters["userid"].Value = userId;
            oraCmd.ExecuteNonQuery();
        }
    }
}
