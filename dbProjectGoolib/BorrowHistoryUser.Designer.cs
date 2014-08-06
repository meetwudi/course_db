namespace dbProjectGoolib
{
    partial class BorrowHistoryUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BorrowHistoryUser_dataGridView = new System.Windows.Forms.DataGridView();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.bORROWTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BORROWTableAdapter();
            this.ViewDetail_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowHistoryUser_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "借阅历史";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // BorrowHistoryUser_dataGridView
            // 
            this.BorrowHistoryUser_dataGridView.AllowUserToAddRows = false;
            this.BorrowHistoryUser_dataGridView.AllowUserToDeleteRows = false;
            this.BorrowHistoryUser_dataGridView.AutoGenerateColumns = false;
            this.BorrowHistoryUser_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowHistoryUser_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKIDDataGridViewTextBoxColumn,
            this.bORROWTIMEDataGridViewTextBoxColumn,
            this.rETURNTIMEDataGridViewTextBoxColumn});
            this.BorrowHistoryUser_dataGridView.DataSource = this.bORROWBindingSource;
            this.BorrowHistoryUser_dataGridView.Location = new System.Drawing.Point(26, 91);
            this.BorrowHistoryUser_dataGridView.Name = "BorrowHistoryUser_dataGridView";
            this.BorrowHistoryUser_dataGridView.ReadOnly = true;
            this.BorrowHistoryUser_dataGridView.RowHeadersVisible = false;
            this.BorrowHistoryUser_dataGridView.RowTemplate.Height = 23;
            this.BorrowHistoryUser_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowHistoryUser_dataGridView.Size = new System.Drawing.Size(354, 246);
            this.BorrowHistoryUser_dataGridView.TabIndex = 3;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "书名";
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bORROWTIMEDataGridViewTextBoxColumn
            // 
            this.bORROWTIMEDataGridViewTextBoxColumn.DataPropertyName = "BORROW_TIME";
            this.bORROWTIMEDataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.bORROWTIMEDataGridViewTextBoxColumn.Name = "bORROWTIMEDataGridViewTextBoxColumn";
            this.bORROWTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rETURNTIMEDataGridViewTextBoxColumn
            // 
            this.rETURNTIMEDataGridViewTextBoxColumn.DataPropertyName = "RETURN_TIME";
            this.rETURNTIMEDataGridViewTextBoxColumn.HeaderText = "归还时间";
            this.rETURNTIMEDataGridViewTextBoxColumn.Name = "rETURNTIMEDataGridViewTextBoxColumn";
            this.rETURNTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bORROWBindingSource
            // 
            this.bORROWBindingSource.DataMember = "BORROW";
            this.bORROWBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDetail_btn
            // 
            this.ViewDetail_btn.Location = new System.Drawing.Point(305, 354);
            this.ViewDetail_btn.Name = "ViewDetail_btn";
            this.ViewDetail_btn.Size = new System.Drawing.Size(75, 25);
            this.ViewDetail_btn.TabIndex = 4;
            this.ViewDetail_btn.Text = "查看";
            this.ViewDetail_btn.UseVisualStyleBackColor = true;
            this.ViewDetail_btn.Click += new System.EventHandler(this.ViewDetail_btn_Click);
            // 
            // BorrowHistoryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(419, 426);
            this.Controls.Add(this.ViewDetail_btn);
            this.Controls.Add(this.BorrowHistoryUser_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(435, 464);
            this.MinimumSize = new System.Drawing.Size(435, 464);
            this.Name = "BorrowHistoryUser";
            this.Load += new System.EventHandler(this.BorrowHistoryUser_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.BorrowHistoryUser_dataGridView, 0);
            this.Controls.SetChildIndex(this.ViewDetail_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowHistoryUser_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView BorrowHistoryUser_dataGridView;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bORROWBindingSource;
        private DataSet2TableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private System.Windows.Forms.Button ViewDetail_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bORROWTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETURNTIMEDataGridViewTextBoxColumn;
    }
}
