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
    public partial class AdminBasic : Form
    {
        public AdminBasic()
        {
            InitializeComponent();
        }

        private void LogoutAdmin_Click(object sender, EventArgs e)
        {
            //Log Out   --->
        }

        private void ModifyAdmin_Click(object sender, EventArgs e)
        {

        }

        private void BookIndexAdmin_Click(object sender, EventArgs e)
        {

        }

        private void RecommendationAdmin_Click(object sender, EventArgs e)
        {

        }

        private void AddBookAdmin_Click(object sender, EventArgs e)
        {
            //添加书籍
            AddBoolAdminForm addBookAdminForm = new AddBoolAdminForm();
            addBookAdminForm.Show();
        }

        private void ManageBookAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ManageUser_Click(object sender, EventArgs e)
        {

        }

    }
}
