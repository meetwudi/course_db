using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class BookIndexAdmin : dbProjectGoolib.AdminBasic
    {
        public BookIndexAdmin()
        {
            InitializeComponent();
            base.BookIndexAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookIndexAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.BOOKS”中。您可以根据需要移动或删除它。
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);

        }

        private void ViewDetail_btn_Click(object sender, EventArgs e)
        {
            if (SearchResultAdmin_dataGridView1.SelectedRows.Count == 1)
            {
                BookDetail bookDetail = new BookDetail();
                this.AddOwnedForm(bookDetail);
                bookDetail.CurrentBookId = int.Parse(SearchResultAdmin_dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                bookDetail.Show();
            }
        }

        private void SearchResultAdmin_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchAdmin_btn_Click(object sender, EventArgs e)
        {
            this.bOOKSBindingSource2.Filter = "NAME LIKE '%" + this.BookNameAdmin_textbox.Text.Replace("'", "") + "%'";
        }
        
    }
}
