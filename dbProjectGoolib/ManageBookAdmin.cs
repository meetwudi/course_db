using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class ManageBookAdmin : dbProjectGoolib.AdminBasic
    {
        public ManageBookAdmin()
        {
            InitializeComponent();
            //base.ManageBookAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void ManageBookAdmin_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.BOOKS”中。您可以根据需要移动或删除它。
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);

        }

        private void ViewDetail_btn_Click(object sender, EventArgs e)
        {
            Form bookDetail = new BookDetail();
            this.AddOwnedForm(bookDetail);
            bookDetail.Show();
        }
    }
}
