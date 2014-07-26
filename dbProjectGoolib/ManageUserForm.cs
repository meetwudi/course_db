using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class ManageUserForm : dbProjectGoolib.AdminBasic
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void SetAsAdmin_btn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_btn_Click(object sender, EventArgs e)
        {

        }

        private void ResetPSW_btn_Click(object sender, EventArgs e)
        {
            //重置密码
            MessageBox.Show("密码已经重置为123456","Tip:");
        }
    }
}
