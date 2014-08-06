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
    public partial class ReturnBookUser : Form
    {
        public ReturnBookUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnBook(System.Int32.Parse(textBox1.Text), System.Int32.Parse(textBox2.Text));
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
            UpdateAvailable = new OracleCommand("UPDATE BOOKS SET AVAILABLE_NUMBER = AVAILABLE_NUMBER +1 WHERE ID = :BookId",conn);
            UpdateAvailable.Parameters.Add(new OracleParameter("BookId",OracleType.Int32));
            UpdateAvailable.Parameters["BookId"].Value = BookId;
            try
            {
                int ret1 = ReturnSQL.ExecuteNonQuery();
                if (ret1 !=1)
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
