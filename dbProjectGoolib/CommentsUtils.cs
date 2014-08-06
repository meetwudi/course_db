using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    static class CommentsUtils
    {
        /*
         * needed catch exception
         * 
         * @para userId from local class User
         * @para bookID from constructor
         * 
         * @return  判断条件
         *          接收受影响行数，也就是说result大于0的话表示添加成功
         *          通过判断是否大于0，判断是否成功
         */
        public static int addComments(int bookID, string contents)
        {

            OracleConnection conn = DBConnection.oracleConnection;
            string sql = "insert into comments values(:user_id, :book_id, :detail, sysdate)";
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter paru = new OracleParameter(":user_id", User.UserId);
            cmd.Parameters.Add(paru);

            OracleParameter parb = new OracleParameter(":book_id", bookID);
            cmd.Parameters.Add(parb);

            OracleParameter pard = new OracleParameter(":detail", contents);
            cmd.Parameters.Add(pard);

            int result = cmd.ExecuteNonQuery();//result接收受影响行数，也就是说result大于0的话表示添加成功
            cmd.Dispose();

            return result;

        }

        public static bool deleteComment(string row_id)
        {
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                return false;
            }

            OracleCommand sql = new OracleCommand("DELETE FROM COMMENTS WHERE COMMENTS.ROWID= :row_Id", conn);
            sql.Parameters.Add(new OracleParameter("row_Id", OracleType.VarChar));
            sql.Parameters["row_Id"].Value = row_id;

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
    }
}
