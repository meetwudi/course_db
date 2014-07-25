using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class basic : Form
    {
        public basic()
        {
            InitializeComponent();
        }

        private void basic_Load(object sender, EventArgs e)
        {

        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.AddOwnedForm(login);
            login.Show();
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            this.AddOwnedForm(register);
            register.Show();
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
