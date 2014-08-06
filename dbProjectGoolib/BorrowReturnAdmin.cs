using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace dbProjectGoolib
{
    public partial class BorrowReturnAdmin : dbProjectGoolib.AdminBasic
    {
        public BorrowReturnAdmin()
        {
            InitializeComponent();
            base.BorrowReturnAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }
        private String Handlle_Isbn(String ISBN13)
        {
            String Isbn="";
            for (int i = 0; i < ISBN13.Length; i++)
            {
                if (ISBN13[i] >= '0' && ISBN13[i] <= '9')
                {
                    Isbn += ISBN13[i];
                }
            }
            return Isbn;
        }
        private void Borrow_btn_Click(object sender, EventArgs e)
        {
            String ISBN13 = Handlle_Isbn(isbn_textBox.Text);
            String name = UsernameAdmin_textbox.Text;
            Int32 UserId = get_UserId(name);
            Int32 BookId = get_BookId(ISBN13);
            if (UserId == -1 || BookId == -1) MessageBox.Show(null, "账号或书籍不存在", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else  borrow(UserId, BookId);

        }


        private void Return_btn_Click(object sender, EventArgs e)
        {
            String ISBN13 = Handlle_Isbn(isbn_textBox.Text);
            String name = UsernameAdmin_textbox.Text;
            Int32 UserId = get_UserId(name);
            Int32 BookId = get_BookId(ISBN13);
            if (UserId == -1 || BookId == -1) MessageBox.Show(null, "账号或书籍不存在", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else ReturnBook(UserId, BookId);
        }


        private Int32 get_UserId(String name)
        {
            Int32 UserId = -1;
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                return UserId;
            }
            OracleCommand sql;
            sql = new OracleCommand("SELECT ID FROM USERS WHERE NAME = :name AND IS_DELETED = 'N'", conn);
            sql.Parameters.Add("name", OracleType.VarChar);
            sql.Parameters["name"].Value = name;
            try
            {
                OracleDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    UserId = reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                UserId = -1;
            }
            return UserId;
            
        }


        private Int32 get_BookId(String ISBN13)
        {
            Int32 BookId = -1;
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                return BookId;
            }
            OracleCommand sql;
            sql = new OracleCommand("SELECT ID FROM BOOKS WHERE ISBN13 = :isbn13", conn);
            sql.Parameters.Add("isbn13", OracleType.Char);
            sql.Parameters["isbn13"].Value = ISBN13;
            try
            {
                OracleDataReader reader = sql.ExecuteReader();
                if (reader.Read())
                {
                    BookId = reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                BookId = -1;
            }
            return BookId;

        }

        private void borrow(Int32 UserId, Int32 BookId)
        {
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                MessageBox.Show(null, "数据库连接错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Int32 available = 0;
            OracleCommand check_available;
            check_available = new OracleCommand("SELECT AVAILABLE_NUMBER FROM BOOKS WHERE ID = :BookId", conn);
            check_available.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
            check_available.Parameters["BookId"].Value = BookId;
            try
            {
                OracleDataReader reader = check_available.ExecuteReader();
                if (reader.Read())
                {
                    available = reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(null, "未执行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Boolean borrowed = false;
            OracleCommand check_borrowed;
            check_borrowed = new OracleCommand("SELECT * FROM BORROW WHERE USER_ID = :UserId AND BOOK_ID = :BookId AND STATE = 'N'", conn);
            check_borrowed.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
            check_borrowed.Parameters.Add(new OracleParameter("UserId", OracleType.Int32));
            check_borrowed.Parameters["BookId"].Value = BookId;
            check_borrowed.Parameters["UserId"].Value = UserId;
            try
            {
                OracleDataReader reader1 = check_borrowed.ExecuteReader();
                if (reader1.Read())
                {
                    borrowed = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "未执行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (available >= 1 && !borrowed)
            {
                OracleCommand BorrowBook;
                BorrowBook = new OracleCommand("INSERT INTO BORROW(USER_ID,BOOK_ID,BORROW_TIME,DEADLINE) VALUES(:UserId,:BookId,sysdate,sysdate+numtodsinterval(30,'day'))", conn);
                BorrowBook.Parameters.Add(new OracleParameter("UserId", OracleType.Int32));
                BorrowBook.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
                BorrowBook.Parameters["UserId"].Value = UserId;
                BorrowBook.Parameters["BookId"].Value = BookId;

                OracleCommand UpdateAvailable;
                UpdateAvailable = new OracleCommand("UPDATE BOOKS SET AVAILABLE_NUMBER = AVAILABLE_NUMBER - 1 WHERE ID = :BookId", conn);
                UpdateAvailable.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
                UpdateAvailable.Parameters["BookId"].Value = BookId;
                try
                {
                    int ret1 = BorrowBook.ExecuteNonQuery();
                    int ret2 = UpdateAvailable.ExecuteNonQuery();
                    if (ret1 != 1 || ret2 != 1)
                    {
                        MessageBox.Show(null, "执行失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(null, "借书成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show(null, "未执行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (available < 1)
            {
                MessageBox.Show(null, "该书已经被借完了", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "不可重复借阅", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void ReturnBook(Int32 UserId, Int32 BookId)
        {
            OracleConnection conn = DBConnection.oracleConnection;
            if (conn == null || !DBConnection.Connected)
            {
                MessageBox.Show(null, "数据库连接错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OracleCommand ReturnSQL;
            ReturnSQL = new OracleCommand("UPDATE BORROW SET RETURN_TIME = sysdate, STATE = 'Y' WHERE STATE ='N' AND USER_ID = :UserId AND BOOK_ID = :BookId", conn);
            ReturnSQL.Parameters.Add(new OracleParameter("UserId", OracleType.Int32));
            ReturnSQL.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
            ReturnSQL.Parameters["UserId"].Value = UserId;
            ReturnSQL.Parameters["BookId"].Value = BookId;

            OracleCommand UpdateAvailable;
            UpdateAvailable = new OracleCommand("UPDATE BOOKS SET AVAILABLE_NUMBER = AVAILABLE_NUMBER +1 WHERE ID = :BookId", conn);
            UpdateAvailable.Parameters.Add(new OracleParameter("BookId", OracleType.Int32));
            UpdateAvailable.Parameters["BookId"].Value = BookId;
            try
            {
                int ret1 = ReturnSQL.ExecuteNonQuery();
                if (ret1 != 1)
                {
                    MessageBox.Show(null, "归还未成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int ret2 = UpdateAvailable.ExecuteNonQuery();
                    if (ret2 != 1) MessageBox.Show(null, "归还未成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show(null, "归还成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(null, "未执行", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

    }
}
