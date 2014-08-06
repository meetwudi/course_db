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
    public partial class UserBasic : Form
    {
        public UserBasic()
        {
            InitializeComponent();
            this.FormClosing+=new FormClosingEventHandler(UserBasic_FormClosing);
            this.FormClosed += new FormClosedEventHandler(UserBasic_FormClosed);
        }

        void UserBasic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ModifyUser_Click(object sender, EventArgs e)
        {
            Form modify = new ModifyUser();
            this.AddOwnedForm(modify);
            modify.Show();
            this.Hide();
        }

        private void CurrentBorrowUser_Click(object sender, EventArgs e)
        {
            Form currentBorrow = new CurrentBorrowUser();
            this.AddOwnedForm(currentBorrow);
            currentBorrow.Show();
            this.Hide();
        }

        private void IndexUser_Click(object sender, EventArgs e)
        {
            Form index = new BookIndexUser();
            this.AddOwnedForm(index);
            index.Show();
            this.Hide();
        }
        private void UserBasic_FormClosing(object sender, FormClosingEventArgs e) 
        {
           // if (MessageBox.Show("确认关闭程序？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           // {
                Application.Exit();
           // }
          //  else
           // {
          //      e.Cancel = true;
          //  }
        }

        private void BorrowHistoryUser_Click(object sender, EventArgs e)
        {
            Form borrowHistory = new BorrowHistoryUser();
            this.AddOwnedForm(borrowHistory);
            borrowHistory.Show();
            this.Hide();
        }

        private void RecommendUser_Click(object sender, EventArgs e)
        {
            Form createRecommend = new CreateRecommendUser();
            this.AddOwnedForm(createRecommend);
            createRecommend.Show();
            this.Hide();
        }

        private void IndexHistoryUser_Click(object sender, EventArgs e)
        {
            Form indexHistory = new IndexHistoryUser();
            this.AddOwnedForm(indexHistory);
            indexHistory.Show();
            this.Hide();
        }

        private void MyRecommendUser_Click(object sender, EventArgs e)
        {
            Form myRecommend = new MyRecommendUser();
            this.AddOwnedForm(myRecommend);
            myRecommend.Show();
            this.Hide();
        }

        private void LogoutUser_Click(object sender, EventArgs e)
        {
            User.UserClear();
            Form initial = new Initial();
            initial.Show();
            this.Hide();
        }
    }
}
