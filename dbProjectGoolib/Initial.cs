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

            if (this.passwordTextRg != this.passwordConfirm)
            {
                Alert("密码不一致");
                return false;
            }

            if (this.usernameTextRg.Text.Contains("'"))
            {
                Alert("字符串中不能含有  '");
                return false;
            }

            if (this.passwordTextRg.Text.Contains("'"))
            {
                Alert("字符串中不能含有  '");
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
            if (this.usernameTextLg.Text.Contains("'"))
            {
                Alert("字符串中不能含有  '");
                return false;
            }
            if (this.passwordTextLg.Text.Contains("'"))
            {
                Alert("字符串中不能含有  '");
                return false;
            }


            return true;
        }

        private void submitLg_Click(object sender, EventArgs e)
        {
            CheckInfoLg();
            Form userBasic = new UserBasic();
            this.AddOwnedForm(userBasic);
            userBasic.Show();
            
        }

        private void submitRg_Click(object sender, EventArgs e)
        {
            CheckInfoRg();
            Form userBasic = new UserBasic();
            this.AddOwnedForm(userBasic);
            userBasic.Show();
        }

        private void Initial_Load(object sender, EventArgs e)
        {

        }

    }
}
