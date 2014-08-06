using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class CurrentBorrowUser : dbProjectGoolib.UserBasic
    {
        public CurrentBorrowUser()
        {
            InitializeComponent();
            this.CurrentBorrowUser.Visible = false;
            this.pictureBox1.Visible = false;
        }

        private void CurrentBorrowUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.BORROW”中。您可以根据需要移动或删除它。
            this.bORROWTableAdapter.FillBy(this.dataSet2.BORROW);

            bORROWBindingSource1.Filter = "USER_ID = " + User.UserId;
        }

        private void ViewDeta_btn_Click(object sender, EventArgs e)
        {
            Form bookDetail = new BookDetail();
            this.AddOwnedForm(bookDetail);
            bookDetail.Show();
        }

    }
}
