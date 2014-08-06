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
    public partial class BookDetail : Form
    {
        private int mCurrentBookId;

        public int CurrentBookId
        {
            get { return mCurrentBookId; }
            set
            {
                mCurrentBookId = value;
                bOOKSBindingSource.Filter = "ID = " + mCurrentBookId.ToString();
                dataSet2BindingSource.Filter = "BOOK_ID = " + mCurrentBookId.ToString();
                bOOKTAGBindingSource.Filter = "BOOK_ID = " + mCurrentBookId.ToString();
            }
        }

        public BookDetail()
        {
            InitializeComponent();
            if (User.IsAdmin)
            {
                this.CommentContent_textbox.Visible = false;
                this.Comment_btn.Visible = false;
            }
            else
            {
                this.btn_delete.Visible = false;
            }
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.BOOKTAG”中。您可以根据需要移动或删除它。
            this.bOOKTAGTableAdapter.FillBy(this.dataSet2.BOOKTAG);
            // TODO: 这行代码将数据加载到表“dataSet2.BOOKS”中。您可以根据需要移动或删除它。
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);
            // TODO: 这行代码将数据加载到表“dataSet2.COMMENTS”中。您可以根据需要移动或删除它。
            this.cOMMENTSTableAdapter.FillBy(this.dataSet2.COMMENTS);

            /*CurrentBookId = 1;
            User.Impersonate(1, "123", false);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookeTotal_label_Click(object sender, EventArgs e)
        {

        }

        private void BookAvailable_label_Click(object sender, EventArgs e)
        {

        }

        private void CommentContent_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comment_btn_Click(object sender, EventArgs e)
        {
            string contents = CommentContent_textbox.Text.ToString();
            int result = CommentsUtils.addComments(CurrentBookId, contents);
            if (result > 0)
            {
                MessageBox.Show("评论成功！", "Success");
                this.cOMMENTSTableAdapter.FillBy(this.dataSet2.COMMENTS);
                CommentContent_textbox.Text = "";
            }
            else
            {
                MessageBox.Show("Unknown exception！", "Fail");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Comment_dataGridView.SelectedRows.Count; ++i)
            {
                if (!CommentsUtils.deleteComment((string)this.Comment_dataGridView.SelectedRows[i].Cells[3].Value))
                {
                    MessageBox.Show("删除书评失败");
                    this.DialogResult = DialogResult.Abort;
                    return;
                } 
            }
            MessageBox.Show("删除书评成功");
            this.DialogResult = DialogResult.OK;
            this.cOMMENTSTableAdapter.FillBy(this.dataSet2.COMMENTS);
            
        }
    }
}
