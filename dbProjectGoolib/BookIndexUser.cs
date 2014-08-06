using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class BookIndexUser : dbProjectGoolib.UserBasic
    {
        public BookIndexUser()
        {
            InitializeComponent();
            base.IndexUser.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.BOOKS”中。您可以根据需要移动或删除它。
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);

            // User.Impersonate(1, "Default User", false);

            AutoCompleteStringCollection candidates = new AutoCompleteStringCollection();
            candidates.AddRange(SearchUtility.fetchSearchHistory(User.UserId).ToArray());
            BookNameUser_textbox.AutoCompleteCustomSource = candidates;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.bOOKSBindingSource.Filter = "NAME LIKE '%"+this.BookNameUser_textbox.Text.Replace("'","")+"%'";
            SearchUtility.ADD_RESULT res = SearchUtility.addSearchHistory(User.UserId, this.BookNameUser_textbox.Text);
            if (res != SearchUtility.ADD_RESULT.SUCCESS)
            {
                Console.WriteLine("记录搜索历史时出错 " + res.ToString());
            }
        }

        private void ViewDetail_btn_Click_1(object sender, EventArgs e)
        {
            if (SearchResultUser_dataGridView.SelectedRows.Count == 1)
            {
                BookDetail bookDetail = new BookDetail();
                this.AddOwnedForm(bookDetail);
                bookDetail.CurrentBookId = int.Parse(SearchResultUser_dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
                bookDetail.Show();
            }
            
        }

        private void SearchResultUser_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
