using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace dbProjectGoolib
{
    public partial class BorrowerUser : Form
    {
        public BorrowerUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrow(System.Int32.Parse(textBox1.Text), System.Int32.Parse(textBox2.Text));
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
            check_available.Parameters.Add(new OracleParameter("BookId",OracleType.Int32));
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
            check_borrowed.Parameters.Add(new OracleParameter("BookId",OracleType.Int32));
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
            if (available >= 1&& !borrowed)
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
    }
}
