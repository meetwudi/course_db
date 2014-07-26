using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class Modify : dbProjectGoolib.UserBasic
    {
        public Modify()
        {
            InitializeComponent();
            base.ModifyUser.Enabled = false;

        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
