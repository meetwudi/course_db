namespace dbProjectGoolib
{
    partial class ManageBookAdminForm
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
            this.isbn_label = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publish_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(39, 57);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 1;
            this.isbn_label.Text = "ISBN";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(278, 52);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "搜索";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.name,
            this.author,
            this.publisher,
            this.intro,
            this.publish_name,
            this.total_name,
            this.available_number,
            this.location_floor});
            this.dataGridView1.Location = new System.Drawing.Point(42, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 218);
            this.dataGridView1.TabIndex = 4;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "书籍名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "作者";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "供应商";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // intro
            // 
            this.intro.HeaderText = "书籍介绍";
            this.intro.Name = "intro";
            this.intro.ReadOnly = true;
            // 
            // publish_name
            // 
            this.publish_name.HeaderText = "出版日期";
            this.publish_name.Name = "publish_name";
            this.publish_name.ReadOnly = true;
            // 
            // total_name
            // 
            this.total_name.HeaderText = "库存";
            this.total_name.Name = "total_name";
            // 
            // available_number
            // 
            this.available_number.HeaderText = "可借数量";
            this.available_number.Name = "available_number";
            // 
            // location_floor
            // 
            this.location_floor.HeaderText = "可借数量";
            this.location_floor.Name = "location_floor";
            // 
            // ManageBookAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.isbn_label);
            this.Name = "ManageBookAdminForm";
            this.Controls.SetChildIndex(this.isbn_label, 0);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn intro;
        private System.Windows.Forms.DataGridViewTextBoxColumn publish_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn available_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_floor;
    }
}
