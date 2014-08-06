using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;


namespace dbProjectGoolib
{
    public class SearchUtility
    {

        public enum ADD_RESULT
        {
            SUCCESS,
            E_DATABASE_UNAVAILABLE,
            E_DATABASE_ERROR,
            E_DATABASE_LOGIC_ERROR,
            E_INTERNAL_ERROR
        }

        public static ADD_RESULT addSearchHistory(int userId, string keyword)
        {
            // 获取数据库连接
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                return ADD_RESULT.E_DATABASE_UNAVAILABLE;
            }

            // 查看关键词是否存在
            OracleCommand sql = null;
            int kid = -1;
LookUpAgain:
            sql = new OracleCommand("SELECT ID FROM KEYWORDS WHERE DETAIL = :detail", conn);
            sql.Parameters.Add(new OracleParameter("detail", OracleType.VarChar));
            sql.Parameters["detail"].Value = keyword;
            try
            {
                OracleDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    // 该关键字已存在
                    kid = reader.GetInt32(0);
                }
                else
                {
                    if (kid == 0)
                    {
                        return ADD_RESULT.E_DATABASE_LOGIC_ERROR;
                    }
                    // 需要添加新的关键字
                    // 构造Insert
                    sql = new OracleCommand("INSERT INTO KEYWORDS (DETAIL, TIMES) VALUES (:detail, 0)", conn);
                    sql.Parameters.Add(new OracleParameter("detail", OracleType.VarChar));
                    sql.Parameters["detail"].Value = keyword;
                    // 执行
                    int ret = sql.ExecuteNonQuery();
                    if (ret != 1)
                    {
                        return ADD_RESULT.E_DATABASE_LOGIC_ERROR;
                    }
                    else
                    {
                        // 查询新加行的ID
                        kid = 0;
                        goto LookUpAgain;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return ADD_RESULT.E_DATABASE_ERROR;
            }
            // 添加到Search表
            sql = new OracleCommand("INSERT INTO SEARCH (USER_ID, KEYWORD_ID, SEARCH_DATE) VALUES (:userid, :kid, SYSDATE)", conn);
            sql.Parameters.Add(new OracleParameter("userid", OracleType.Int32));
            sql.Parameters.Add(new OracleParameter("kid", OracleType.Int32));
            sql.Parameters["userid"].Value = userId;
            sql.Parameters["kid"].Value = kid;
            try
            {
                if (sql.ExecuteNonQuery() != 1)
                {
                    return ADD_RESULT.E_DATABASE_LOGIC_ERROR;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return ADD_RESULT.E_DATABASE_ERROR;
            }
            // 增加关键词次数
            sql = new OracleCommand("UPDATE KEYWORDS SET TIMES = TIMES+1 WHERE ID = :kid", conn);
            sql.Parameters.Add(new OracleParameter("kid", OracleType.Int32));
            sql.Parameters["kid"].Value = kid;
            try
            {
                sql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ADD_RESULT.SUCCESS;
        }

        public static List<String> fetchSearchHistory(int userId)
        {
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected) return null;

            OracleCommand sql = new OracleCommand("SELECT DETAIL,TIMES FROM KEYWORDS,SEARCH WHERE KEYWORDS.ID=SEARCH.KEYWORD_ID AND SEARCH.USER_ID=:userid",conn);
            sql.Parameters.Add(new OracleParameter("userid",OracleType.Int32));
            sql.Parameters["userid"].Value=userId;

            List<String> result = new List<String>();

            try
            {
                OracleDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return result;
        }
    }
}