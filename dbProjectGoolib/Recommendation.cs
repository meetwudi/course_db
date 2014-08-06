using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    class Recommendation
    {
        private string bookName;
        private string author;
        private string remark;

        public bool setReco(string b, string a, string r)
        {
            if (null == b || 0 == b.Length) return false;
            this.bookName = b;
            this.author = a;
            this.remark = r;
            return true;
        }

        public bool insertReco()
        {
            //check for database connection
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                return false;
            }

            OracleCommand sql = new OracleCommand("INSERT INTO RECOMMENDATIONS (USER_ID, BOOK_NAME, AUTHOR, REMARK, RECOMMEND_DATE) VALUES (:userId, :bookName, :author, :remark, sysdate)", conn);
            sql.Parameters.Add(new OracleParameter("userId", OracleType.Int32));
            sql.Parameters.Add(new OracleParameter("bookName", OracleType.VarChar));
            sql.Parameters.Add(new OracleParameter("author", OracleType.VarChar));
            sql.Parameters.Add(new OracleParameter("remark", OracleType.VarChar));

            sql.Parameters["userId"].Value = User.UserId;
            //sql.Parameters["userId"].Value = 1;
            sql.Parameters["bookName"].Value = this.bookName;
            sql.Parameters["author"].Value = this.author;
            sql.Parameters["remark"].Value = this.remark;

            try
            {
                sql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool handleReco(int recoId)
        {
            //check for database connection 
            OracleConnection conn = DBConnection.oracleConnection;                  
            if (conn == null || !DBConnection.Connected)
            {
                return false;
            }

            OracleCommand sql = new OracleCommand("UPDATE RECOMMENDATIONS SET STATE='Y' WHERE ID= :recoId", conn);
            sql.Parameters.Add(new OracleParameter("recoId", OracleType.Int32));
            sql.Parameters["recoId"].Value = recoId;

            try
            {
                sql.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }


    }
}
