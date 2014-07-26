namespace dbProjectGoolib
{
    partial class BookIndexAdminForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Search_textbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.bookList_label = new System.Windows.Forms.Label();
            this.SearchResult_dataGridView = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_textbox
            // 
            this.Search_textbox.Location = new System.Drawing.Point(45, 50);
            this.Search_textbox.Name = "Search_textbox";
            this.Search_textbox.Size = new System.Drawing.Size(180, 20);
            this.Search_textbox.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(266, 47);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(47, 24);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "搜索";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // bookList_label
            // 
            this.bookList_label.AutoSize = true;
            this.bookList_label.Location = new System.Drawing.Point(42, 114);
            this.bookList_label.Name = "bookList_label";
            this.bookList_label.Size = new System.Drawing.Size(55, 13);
            this.bookList_label.TabIndex = 5;
            this.bookList_label.Text = "书籍列表";
            // 
            // SearchResult_dataGridView
            // 
            this.SearchResult_dataGridView.AllowUserToAddRows = false;
            this.SearchResult_dataGridView.AllowUserToDeleteRows = false;
            this.SearchResult_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResult_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.Author});
            this.SearchResult_dataGridView.Location = new System.Drawing.Point(45, 160);
            this.SearchResult_dataGridView.Name = "SearchResult_dataGridView";
            this.SearchResult_dataGridView.ReadOnly = true;
            this.SearchResult_dataGridView.Size = new System.Drawing.Size(374, 150);
            this.SearchResult_dataGridView.TabIndex = 6;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "作者";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BookIndexAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.SearchResult_dataGridView);
            this.Controls.Add(this.bookList_label);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.Search_textbox);
            this.Name = "BookIndexAdminForm";
            this.Text = "书籍索引";
            this.Controls.SetChildIndex(this.Search_textbox, 0);
            this.Controls.SetChildIndex(this.search_btn, 0);
            this.Controls.SetChildIndex(this.bookList_label, 0);
            this.Controls.SetChildIndex(this.SearchResult_dataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_textbox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label bookList_label;
        private System.Windows.Forms.DataGridView SearchResult_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    }
}
