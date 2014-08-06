using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();
            this.passwordTextLg.PasswordChar = '*';
            this.passwordTextRg.PasswordChar = '*';
            this.passwordConfirm.PasswordChar = '*';
        }

        void Alert(string message)
        {
            MessageBox.Show(null, message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool CheckInfoRg()
        {
            if (this.usernameTextRg.Text == "")
            {
                Alert("用户名不能为空");
                return false;
            }

            if (this.passwordTextRg.Text == "")
            {
                Alert("密码不能为空");
                return false;
            }

            if (this.realNameTextRg.Text == "")
            {
                Alert("真实姓名不能为空");
                return false;
            }

            if (this.passwordTextRg.Text != this.passwordConfirm.Text)
            {
                Alert("密码不一致");
                return false;
            }

            

            return true;
        }

        bool CheckInfoLg()
        {
            if (this.usernameTextLg.Text == "")
            {
                Alert("用户名不能为空");
                return false;
            }

            if (this.passwordTextLg.Text == "")
            {
                Alert("密码不能为空");
                return false;
            }
            


            return true;
        }

        private void submitLg_Click(object sender, EventArgs e)
        {
            if(!CheckInfoLg())
            {
                return;
            }
            string result=User.Login(this.usernameTextLg.Text, this.passwordTextLg.Text, this.identity.Checked);
            if ( result== "Succeed")
            {
                Form userForm;
                if(this.identity.Checked)
                {
                    userForm= new AdminBasic();
                }
                else
                {
                    userForm = new UserBasic();
                }
                this.AddOwnedForm(userForm);
                this.Hide();
                userForm.Show();
      
                
            }
            else
            {
                Alert(result);
            }
            
            
        }

        private void submitRg_Click(object sender, EventArgs e)
        {
            if (CheckInfoRg())
            {
                string[] info = new string[5];
                info[0] = this.usernameTextRg.Text;
                info[1] = this.passwordTextRg.Text;
                info[2] = this.realNameTextRg.Text;
                info[3] = this.phoneNumberRg.Text;
                info[4] = this.emailRg.Text;
                string result = User.regist(info);
                User.UserClear();
                if (result == "UserName Already Exist" || result == "Not Connected")
                {
                    Alert(result);
                    return;
                }
                else
                {
                    Alert("Succeed:" + result);
                    User.Login(info[0], info[1], false);
                }

            }
            else
            {
                return;
            }
            this.Hide();
            Form userBasic = new UserBasic();
            this.AddOwnedForm(userBasic);
            userBasic.Show();
        }

        private void Initial_Load(object sender, EventArgs e)
        {
            
        }

    }
}
