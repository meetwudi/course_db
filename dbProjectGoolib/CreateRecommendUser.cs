using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class CreateRecommendUser : dbProjectGoolib.UserBasic
    {
        public CreateRecommendUser()
        {
            InitializeComponent();
            base.RecommendUser.Visible = false;
            base.pictureBox1.Visible = false;
        }

        public void reSetForm()
        {
            BookNameUser_textbox.Text = "";
            AuthorUser_textbox.Text = "";
            ReasonUser_textbox.Text = "";
        }

        private void submitRecoUser_btn_Click(object sender, EventArgs e)
        {
            string bookName = BookNameUser_textbox.Text;
            string author = AuthorUser_textbox.Text;
            string remark = ReasonUser_textbox.Text;

            Recommendation reco = new Recommendation();
            if (!reco.setReco(bookName, author, remark))
            {
                MessageBox.Show("书名不能为空!");
                this.DialogResult = DialogResult.Abort;
                return;
            }

            if (!reco.insertReco())
            {
                MessageBox.Show("推荐失败!");
                this.DialogResult = DialogResult.Abort;
                return;
            }
            MessageBox.Show("推荐成功!");
            this.reSetForm();                   //清空表单

            this.DialogResult = DialogResult.OK;
        }

    }
}
