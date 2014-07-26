using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class AddBoolAdminForm : dbProjectGoolib.AdminBasic
    {
        public AddBoolAdminForm()
        {
            InitializeComponent();
        }

        private void isbn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string isbnTBValue = isbn_textBox.Text.ToString();
            if (isbnTBValue.Equals(""))
            {
                MessageBox.Show("请输入ISBN号!", "Error");
            }
            else
            {
                //写入逻辑处理部分
            }
        }

        private void AddBoolAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
