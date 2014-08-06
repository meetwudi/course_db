using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class ModifyAdmin : dbProjectGoolib.AdminBasic{
        public ModifyAdmin()
        {
            InitializeComponent();
            base.ModifyAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
        private string changePassWord()
        {
            if (this.OldPasswordAdmin_textbox.Text == "")
            {
                return "未输入旧密码";
            }
            if (this.NewPasswordAdmin_textbox.Text == "")
            {
                return "未输入新密码";
            }
            if (this.PasswordConfirmAdmin_textbox.Text != this.NewPasswordAdmin_textbox.Text)
            {
                return "新密码与确认密码不一致";
            }
            string strres =User.Login(User.UserName, this.OldPasswordAdmin_textbox.Text, true);
            if (strres == "Password Error")
            {
                return "旧密码错误";
            }
            if (strres == "Adminname Error")
            {
                return "用户受限，请重启程序";
            }

            if (strres == "Succeed")
            {
                return AdminBasicOperation.AdminChangePassword(this.NewPasswordAdmin_textbox.Text,User.UserId);
            }
            return "未知错误";
        }

        private void SaveInfoAdmin_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            //密码更改
            if ((this.OldPasswordAdmin_textbox.Text != "" && this.OldPasswordAdmin_textbox.Text != null)
                || (this.NewPasswordAdmin_textbox.Text != "" && this.NewPasswordAdmin_textbox.Text != null)
                || (this.PasswordConfirmAdmin_textbox.Text != "" && this.PasswordConfirmAdmin_textbox != null))
            {
                errorMessage = changePassWord();
                if (errorMessage == "1 got influenced.")
                {
                    errorMessage = "更改成功";
                }
                MessageBox.Show(errorMessage, "更改提醒", MessageBoxButtons.OK);
            }
            else 
            {
                MessageBox.Show("无内容更改", "更改提醒", MessageBoxButtons.OK);
            }

            this.OldPasswordAdmin_textbox.Text = "";
            this.NewPasswordAdmin_textbox.Text = "";
            this.PasswordConfirmAdmin_textbox.Text = "";
        }

    }
}
