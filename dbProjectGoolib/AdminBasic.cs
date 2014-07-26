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
            //书籍索引
            BookIndexAdminForm bookIndexAdminForm = new BookIndexAdminForm();
            bookIndexAdminForm.Show();
        }

        private void RecommendationAdmin_Click(object sender, EventArgs e)
        {
            //查看推荐
            RecommendationAdminForm recommendationAdminForm = new RecommendationAdminForm();
            recommendationAdminForm.Show();
        }

        private void AddBookAdmin_Click(object sender, EventArgs e)
        {
            //添加书籍
            AddBoolAdminForm addBookAdminForm = new AddBoolAdminForm();
            addBookAdminForm.Show();
        }

        private void ManageBookAdmin_Click(object sender, EventArgs e)
        {
            //管理书籍
            ManageBookAdminForm manageBookAdminForm = new ManageBookAdminForm();
            manageBookAdminForm.Show();
        }

        private void ManageUser_Click(object sender, EventArgs e)
        {

        }

    }
}
