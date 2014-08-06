using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class MyRecommendUser : dbProjectGoolib.UserBasic
    {
        public MyRecommendUser()
        {
            InitializeComponent();
            base.MyRecommendUser.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void MyRecommendUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.RECOMMENDATIONS”中。您可以根据需要移动或删除它。
            this.rECOMMENDATIONSBindingSource.Filter = "user_id="+User.UserId;
            RecommendHistory_dataGridView.Columns[5].Visible = false;
            this.rECOMMENDATIONSTableAdapter.Fill(this.dataSet2.RECOMMENDATIONS);

        }

        private void ViewDetail_btn_Click(object sender, EventArgs e)
        {
            Form bookDetail = new BookDetail();
            this.AddOwnedForm(bookDetail);
            bookDetail.Show();
        }

    }
}
