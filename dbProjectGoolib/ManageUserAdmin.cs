using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class ManageUserAdmin : dbProjectGoolib.AdminBasic
    {
        public ManageUserAdmin()
        {
            InitializeComponent();
            base.ManageUserAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void SetAsAdmin_btn_Click(object sender, EventArgs e)
        {
            int userID = (int)ManageUser_dataGridView.SelectedRows[0].Cells[0].Value;
            int adminID = User.UserId;
            AdminBasicOperation.setAdmin(userID, adminID);
            MessageBox.Show("设置用户为管理员成功！\n" , "Success");
            this.uSERSTableAdapter.Fill(this.dataSet2.USERS);
        }

        private void DeleteUser_btn_Click(object sender, EventArgs e)
        {
            int userID = (int)ManageUser_dataGridView.SelectedRows[0].Cells[0].Value;
            int adminID = User.UserId;
            string str = AdminBasicOperation.deleteUser(userID,adminID,true);
            MessageBox.Show("删除用户成功！\n"+str,"Success");
            this.uSERSTableAdapter.Fill(this.dataSet2.USERS);

        }

        private void ResetPSW_btn_Click(object sender, EventArgs e)
        {
            //重置密码
            int userID = (int)ManageUser_dataGridView.SelectedRows[0].Cells[0].Value;
            int adminID = User.UserId;
            AdminBasicOperation.resetPassword(userID, adminID);
            MessageBox.Show("密码已经重置为123456", "Tip:");
            this.uSERSTableAdapter.Fill(this.dataSet2.USERS);
        }

        private void ManageUserAdmin_Load(object sender, EventArgs e)
        {
            this.uSERSBindingSource.Filter = "IS_DELETED = 'N'";
            // TODO: 这行代码将数据加载到表“dataSet2.USERS”中。您可以根据需要移动或删除它。
            this.uSERSTableAdapter.Fill(this.dataSet2.USERS);

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            this.uSERSBindingSource.Filter = "NAME LIKE '%" + this.UsernameAdmin_textbox.Text.ToString() + "%'" + " AND " + "IS_DELETED = 'N'";
        }
    }
}
