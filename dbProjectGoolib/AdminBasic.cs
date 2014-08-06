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
            this.FormClosing += new FormClosingEventHandler(UserBasic_FormClosing);
            this.FormClosed += new FormClosedEventHandler(UserBasic_FormClosed);
        }

        void UserBasic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserBasic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutAdmin_Click(object sender, EventArgs e)
        {
            //Log Out   --->
            User.UserClear();
            Form initial = new Initial();
            initial.Show();
            this.Hide();
        }

        private void ModifyAdmin_Click(object sender, EventArgs e)
        {
            Form modifyAdmin = new ModifyAdmin();
            this.AddOwnedForm(modifyAdmin);
            modifyAdmin.Show();
            this.Hide();
        }

        private void BookIndexAdmin_Click(object sender, EventArgs e)
        {
            Form bookIndexAdmin = new BookIndexAdmin();
            this.AddOwnedForm(bookIndexAdmin);
            bookIndexAdmin.Show();
            this.Hide();
        }

        private void RecommendationAdmin_Click(object sender, EventArgs e)
        {
            Form recommendationAdmin = new RecommendationAdmin();
            this.AddOwnedForm(recommendationAdmin);
            recommendationAdmin.Show();
            this.Hide();
        }

        private void AddBookAdmin_Click(object sender, EventArgs e)
        {
            Form addBookAdmin = new AddBookAdmin();
            this.AddOwnedForm(addBookAdmin);
            addBookAdmin.Show();
            this.Hide();
        }

        //private void ManageBookAdmin_Click(object sender, EventArgs e)
        //{
        //    Form manageBookAdmin = new ManageBookAdmin();
        //    this.AddOwnedForm(manageBookAdmin);
        //    manageBookAdmin.Show();
        //    this.Hide();
        //}

        private void ManageUser_Click(object sender, EventArgs e)
        {
            Form manageUserAdmin = new ManageUserAdmin();
            this.AddOwnedForm(manageUserAdmin);
            manageUserAdmin.Show();
            this.Hide();
        }

        private void BorrowReturnAdmin_Click(object sender, EventArgs e)
        {
            Form borrowReturnAdmin = new BorrowReturnAdmin();
            this.AddOwnedForm(borrowReturnAdmin);
            borrowReturnAdmin.Show();
            this.Hide();
        }

        private void viewLogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form logCheckForm = new Log();
            this.AddOwnedForm(logCheckForm);
            logCheckForm.Show();
            this.Hide();
        }


    }
}
