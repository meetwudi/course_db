namespace dbProjectGoolib
{
    partial class RecommendationAdminForm
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
            this.RecommendationList_dataGridView = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteItem_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationList_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RecommendationList_dataGridView
            // 
            this.RecommendationList_dataGridView.AllowUserToAddRows = false;
            this.RecommendationList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecommendationList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.Author});
            this.RecommendationList_dataGridView.Location = new System.Drawing.Point(44, 123);
            this.RecommendationList_dataGridView.Name = "RecommendationList_dataGridView";
            this.RecommendationList_dataGridView.ReadOnly = true;
            this.RecommendationList_dataGridView.Size = new System.Drawing.Size(355, 150);
            this.RecommendationList_dataGridView.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "下面两个控件全部是实验用的 没用 可以删掉";
            // 
            // DeleteItem_btn
            // 
            this.DeleteItem_btn.Location = new System.Drawing.Point(297, 291);
            this.DeleteItem_btn.Name = "DeleteItem_btn";
            this.DeleteItem_btn.Size = new System.Drawing.Size(75, 23);
            this.DeleteItem_btn.TabIndex = 5;
            this.DeleteItem_btn.Text = "删除该项";
            this.DeleteItem_btn.UseVisualStyleBackColor = true;
            // 
            // RecommendationAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.DeleteItem_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecommendationList_dataGridView);
            this.Name = "RecommendationAdminForm";
            this.Controls.SetChildIndex(this.RecommendationList_dataGridView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DeleteItem_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationList_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecommendationList_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteItem_btn;
    }
}
