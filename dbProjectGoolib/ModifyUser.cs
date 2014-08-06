using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class ModifyUser : dbProjectGoolib.UserBasic
    {
        public ModifyUser()
        {
            InitializeComponent();
            base.ModifyUser.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private string changePassWord()
        {
            if (this.OldPasswordUser_textbox.Text == "")
            {
                return "未输入旧密码";
            }
            if (this.NewPasswordUser_textbox.Text == "")
            {
                return "未输入新密码\r\n提示：只有修改密码才需输入旧密码";
            }
            if (this.PasswordConfirmUser_textbox.Text != this.NewPasswordUser_textbox.Text)
            {
                return "新密码与确认密码不一致";
            }
            string strres=User.Login(User.UserName, this.OldPasswordUser_textbox.Text, false);
            if (strres == "Password Error")
            {
                return "旧密码错误";
            }
            if (strres == "Username Error")
            {
                return "用户受限，请重启程序";
            }
            
            if(strres=="Succeed")
            {
                return User.UpdateUserInformation(User.UserId, this.NewPasswordUser_textbox.Text, "", "", "");
            }
            return "未知错误";
        }

        private void SaveInfoUser_Click(object sender, EventArgs e)
        {
            bool changed = false;
            string errorMessage = "";
            //密码更改
            if ((this.OldPasswordUser_textbox.Text != "" && this.OldPasswordUser_textbox.Text != null)
                ||(this.NewPasswordUser_textbox.Text!=""&&this.NewPasswordUser_textbox.Text!=null)
                ||(this.PasswordConfirmUser_textbox.Text!=""&&this.PasswordConfirmUser_textbox!=null))
            {
                errorMessage = changePassWord();
                //7月29日早晨修改 start
                if (errorMessage == "")
                {
                    changed = true;
                }
                //7月29日早上修改 end
            }
            //其他项更改
            if ((this.RealNameUser_textbox.Text != "" && this.RealNameUser_textbox.Text != null)
                || (this.PhoneNumberUser_textbox.Text != "" && this.PhoneNumberUser_textbox.Text != null)
                || (this.EmailUser_textbox.Text != "" && this.EmailUser_textbox.Text != null))
            {
                User.UpdateUserInformation(User.UserId, "",
                    this.RealNameUser_textbox.Text,
                    this.PhoneNumberUser_textbox.Text,
                    this.EmailUser_textbox.Text);
                changed = true;
            }
            //反馈信息
            if (changed)
            {
                MessageBox.Show( "信息已更新","更新提示" , MessageBoxButtons.OK);
            }
            else
            {
                if (errorMessage == "")
                {
                    MessageBox.Show( "无信息更新","更新提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show( errorMessage,"更新提示", MessageBoxButtons.OK);
                }

            }

            this.OldPasswordUser_textbox.Text = "";
            this.NewPasswordUser_textbox.Text = "";
            this.PasswordConfirmUser_textbox.Text = "";
            this.RealNameUser_textbox.Text = "";
            this.PhoneNumberUser_textbox.Text = "";
            this.EmailUser_textbox.Text = "";
        }

    }
}
