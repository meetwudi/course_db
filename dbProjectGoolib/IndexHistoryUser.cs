using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class IndexHistoryUser : dbProjectGoolib.UserBasic
    {
        public IndexHistoryUser()
        {
            InitializeComponent();
            base.IndexHistoryUser.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void IndexHistoryUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.SEARCH”中。您可以根据需要移动或删除它。
            this.sEARCHTableAdapter.FillBy(this.dataSet2.SEARCH);

            this.sEARCHBindingSource1.Filter = "USER_ID = " + User.UserId;
        }

        private void ViewDetail_btn_Click(object sender, EventArgs e)
        {
            Form bookDetail = new BookDetail();
            this.AddOwnedForm(bookDetail);
            bookDetail.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
