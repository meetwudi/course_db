using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoubanAPI;
using System.Data.OracleClient;

namespace dbProjectGoolib
{
    class BookUtility
    {
        public enum ADDBOOK_ERRORCODE
        {
            E_QUERY_ERROR,
            E_DATABASE_UNAVAILABLE,
            E_DATABASE_ERROR,
            E_DATABASE_LOGIC_ERROR,
            E_INTERNAL_ERROR
        };

        private ADDBOOK_ERRORCODE mLastError;
        private BookQuery.BOOKQUERY_RESULT mQueryResult;
        private BookQuery mInfo;

        public ADDBOOK_ERRORCODE LastError { get {return mLastError;} }
        public BookQuery.BOOKQUERY_RESULT QueryResult { get { return mQueryResult; } }
        public BookQuery BookInfo { get { return mInfo; } }

        public bool AddBook(string isbn, int floor)
        {
            mInfo = new BookQuery(isbn);
            try
            {
                mQueryResult = mInfo.doQuery();
                if (mQueryResult != BookQuery.BOOKQUERY_RESULT.SUCCESS)
                {
                    mLastError = ADDBOOK_ERRORCODE.E_QUERY_ERROR;
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                mLastError = ADDBOOK_ERRORCODE.E_INTERNAL_ERROR;
                return false;
            }
            // 获取数据库连接
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                mLastError = ADDBOOK_ERRORCODE.E_DATABASE_UNAVAILABLE;
                return false;
            }
            // 查询该书是否已存在
            OracleCommand sql;
            int BID = -1;
            bool AddTags = false;
LookUpAgain:
            sql = new OracleCommand("SELECT ID FROM BOOKS WHERE ISBN13 = :isbn13", conn);
            sql.Parameters.Add("isbn13", OracleType.Char);
            sql.Parameters["isbn13"].Value = mInfo.ISBN13;
            try
            {
                OracleDataReader reader = sql.ExecuteReader();
                if (reader.Read()) // 该书已存在
                {
                    if (BID == 0) // 刚加入
                    {
                        AddTags = true;
                    }
                    BID = reader.GetInt32(0);
                }else if (BID == 0)
                {
                    mLastError = ADDBOOK_ERRORCODE.E_INTERNAL_ERROR;
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                mLastError = ADDBOOK_ERRORCODE.E_DATABASE_ERROR;
                return false;
            }
            if (BID == -1)
            {
                // 不存在的话加入新书
                sql = new OracleCommand("INSERT INTO BOOKS (ISBN10, ISBN13, NAME, AUTHOR, PUBLISHER, PUBLISH_DATE, INTRO, TOTAL_NUMBER, AVAILABLE_NUMBER, COVER_PATH, LOCATION_FLOOR) VALUES (:isbn10, :isbn13, :name, :author, :publisher, :pubdate, :intro, 0, 0, :cover, :floor)", conn);
                sql.Parameters.Add(new OracleParameter("isbn10", OracleType.Char));
                sql.Parameters.Add(new OracleParameter("isbn13", OracleType.Char));
                sql.Parameters.Add(new OracleParameter("name", OracleType.VarChar));
                sql.Parameters.Add(new OracleParameter("author", OracleType.VarChar));
                sql.Parameters.Add(new OracleParameter("publisher", OracleType.VarChar));
                sql.Parameters.Add(new OracleParameter("pubdate", OracleType.VarChar));
                sql.Parameters.Add(new OracleParameter("intro", OracleType.Clob));
                sql.Parameters.Add(new OracleParameter("cover", OracleType.VarChar));
                sql.Parameters.Add(new OracleParameter("floor", OracleType.Int32));

                sql.Parameters["isbn10"].Value = mInfo.ISBN10;
                sql.Parameters["isbn13"].Value = mInfo.ISBN13;
                sql.Parameters["name"].Value = mInfo.Title;
                sql.Parameters["author"].Value = mInfo.Author;
                sql.Parameters["publisher"].Value = mInfo.Publisher;
                sql.Parameters["pubdate"].Value = mInfo.PublishDate;
                sql.Parameters["intro"].Value = mInfo.Summary;
                sql.Parameters["cover"].Value = mInfo.ImageUrl;
                sql.Parameters["floor"].Value = floor;

                // 执行
                try
                {
                    int ret = sql.ExecuteNonQuery();
                    if (ret != 1)
                    {
                        mLastError = ADDBOOK_ERRORCODE.E_DATABASE_LOGIC_ERROR;
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    mLastError = ADDBOOK_ERRORCODE.E_DATABASE_ERROR;
                    return false;
                }
                // 新书已加入
                BID = 0;
                goto LookUpAgain;
            }
            // 已知 BID
            if (AddTags)
            {
                // 增加书籍标签
                foreach (string tagName in mInfo.Tags)
                {
                    sql = new OracleCommand("INSERT INTO CATEGORIES (TAG_NAME) VALUES (:name)", conn);
                    sql.Parameters.AddWithValue("name", tagName);
                    try
                    {
                        sql.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    sql = new OracleCommand("INSERT INTO BOOKTAG (BOOK_ID, CATEGORY_ID) VALUES (:BID, (SELECT ID FROM CATEGORIES WHERE TAG_NAME = :name))", conn);
                    sql.Parameters.AddWithValue("name", tagName);
                    sql.Parameters.Add(new OracleParameter("BID", OracleType.Int32));
                    sql.Parameters["BID"].Value = BID;
                    try
                    {
                        sql.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            // 增加可借本数
            sql = new OracleCommand("UPDATE BOOKS SET TOTAL_NUMBER = TOTAL_NUMBER+1, AVAILABLE_NUMBER = AVAILABLE_NUMBER+1 WHERE ID = :BID", conn);
            sql.Parameters.Add(new OracleParameter("BID",OracleType.Int32));
            sql.Parameters["BID"].Value = BID;
            try
            {
                int ret = sql.ExecuteNonQuery();
                if (ret == 1)
                    return true;
                else
                {
                    mLastError = ADDBOOK_ERRORCODE.E_DATABASE_LOGIC_ERROR;
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                mLastError = ADDBOOK_ERRORCODE.E_DATABASE_ERROR;
                return false;
            }
        }

    }
}
