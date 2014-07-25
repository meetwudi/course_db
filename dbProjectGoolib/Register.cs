using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class Register : dbProjectGoolib.basic
    {
        public Register()
        {
            InitializeComponent();
            base.RegisterToolStripMenuItem.Enabled = false;
        }

        void Alert(string message)
        {
            MessageBox.Show(null, message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool CheckInfo()
        {
            if (this.userIdText.Text == "")
            {
                Alert("用户名不能为空");
                return false;
            }

            if (this.passwordText.Text == "")
            {
                Alert("密码不能为空");
                return false;
            }

            if (this.realNameText.Text == "")
            {
                Alert("真实姓名不能为空");
                return false;
            }

            if (this.passwordText != this.passwordConfirmText)
            {
                Alert("密码不一致");
                return false;
            }
            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            CheckInfo();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


    }
}
