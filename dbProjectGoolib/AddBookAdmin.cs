using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class AddBookAdmin : dbProjectGoolib.AdminBasic
    {
        public AddBookAdmin()
        {
            InitializeComponent();
            base.AddBookAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void isbn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string isbnTBValue = isbn_textBox.Text.ToString().Trim();
            if (isbnTBValue == "")
            {
                MessageBox.Show("请输入ISBN号!", "Error");
            }
            else
            {
                //写入逻辑处理部分
                BookUtility util = new BookUtility();
                if (util.AddBook(isbnTBValue, floor_combo.SelectedIndex + 1))
                {
                    MessageBox.Show("书籍《" + util.BookInfo.Title + "》录入成功", "成功");
                    isbn_textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("录入错误:" + util.LastError.ToString() + "\r\n" + "API查询结果:" + util.QueryResult.ToString(), "错误");
                }
            }
        }

        private void AddBookAdmin_Load(object sender, EventArgs e)
        {
            for (int i=1;i<=10;i++)
                floor_combo.Items.Add(i + "层");
            floor_combo.SelectedIndex = 0;
        }
    }
}
