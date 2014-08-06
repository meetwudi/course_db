namespace dbProjectGoolib
{
    partial class BookIndexAdmin
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
            this.bookList_label = new System.Windows.Forms.Label();
            this.SearchResultAdmin_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.SearchAdmin_btn = new System.Windows.Forms.Button();
            this.BookNameAdmin_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bOOKSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKSTableAdapter();
            this.ViewDetail_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultAdmin_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            // 
            // bookList_label
            // 
            this.bookList_label.AutoSize = true;
            this.bookList_label.Location = new System.Drawing.Point(25, 112);
            this.bookList_label.Name = "bookList_label";
            this.bookList_label.Size = new System.Drawing.Size(55, 13);
            this.bookList_label.TabIndex = 5;
            this.bookList_label.Text = "书籍列表";
            // 
            // SearchResultAdmin_dataGridView1
            // 
            this.SearchResultAdmin_dataGridView1.AllowUserToAddRows = false;
            this.SearchResultAdmin_dataGridView1.AllowUserToDeleteRows = false;
            this.SearchResultAdmin_dataGridView1.AutoGenerateColumns = false;
            this.SearchResultAdmin_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultAdmin_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iSBN13DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.SearchResultAdmin_dataGridView1.DataSource = this.bOOKSBindingSource2;
            this.SearchResultAdmin_dataGridView1.Location = new System.Drawing.Point(27, 132);
            this.SearchResultAdmin_dataGridView1.MultiSelect = false;
            this.SearchResultAdmin_dataGridView1.Name = "SearchResultAdmin_dataGridView1";
            this.SearchResultAdmin_dataGridView1.ReadOnly = true;
            this.SearchResultAdmin_dataGridView1.RowHeadersVisible = false;
            this.SearchResultAdmin_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultAdmin_dataGridView1.Size = new System.Drawing.Size(374, 197);
            this.SearchResultAdmin_dataGridView1.TabIndex = 6;
            this.SearchResultAdmin_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultAdmin_dataGridView1_CellContentClick);
            this.SearchResultAdmin_dataGridView1.DoubleClick += new System.EventHandler(this.ViewDetail_btn_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBN13DataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "书名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AUTHOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "作者";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bOOKSBindingSource2
            // 
            this.bOOKSBindingSource2.DataMember = "BOOKS";
            this.bOOKSBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchAdmin_btn
            // 
            this.SearchAdmin_btn.Location = new System.Drawing.Point(228, 76);
            this.SearchAdmin_btn.Name = "SearchAdmin_btn";
            this.SearchAdmin_btn.Size = new System.Drawing.Size(75, 25);
            this.SearchAdmin_btn.TabIndex = 12;
            this.SearchAdmin_btn.Text = "搜索";
            this.SearchAdmin_btn.UseVisualStyleBackColor = true;
            this.SearchAdmin_btn.Click += new System.EventHandler(this.SearchAdmin_btn_Click);
            // 
            // BookNameAdmin_textbox
            // 
            this.BookNameAdmin_textbox.Location = new System.Drawing.Point(92, 78);
            this.BookNameAdmin_textbox.Name = "BookNameAdmin_textbox";
            this.BookNameAdmin_textbox.Size = new System.Drawing.Size(100, 20);
            this.BookNameAdmin_textbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "书籍索引";
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDetail_btn
            // 
            this.ViewDetail_btn.Location = new System.Drawing.Point(326, 336);
            this.ViewDetail_btn.Name = "ViewDetail_btn";
            this.ViewDetail_btn.Size = new System.Drawing.Size(75, 30);
            this.ViewDetail_btn.TabIndex = 13;
            this.ViewDetail_btn.Text = "查看";
            this.ViewDetail_btn.UseVisualStyleBackColor = true;
            this.ViewDetail_btn.Click += new System.EventHandler(this.ViewDetail_btn_Click);
            // 
            // BookIndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 427);
            this.Controls.Add(this.ViewDetail_btn);
            this.Controls.Add(this.SearchAdmin_btn);
            this.Controls.Add(this.BookNameAdmin_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchResultAdmin_dataGridView1);
            this.Controls.Add(this.bookList_label);
            this.MaximumSize = new System.Drawing.Size(475, 465);
            this.MinimumSize = new System.Drawing.Size(475, 465);
            this.Name = "BookIndexAdmin";
            this.Load += new System.EventHandler(this.BookIndexAdminForm_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.bookList_label, 0);
            this.Controls.SetChildIndex(this.SearchResultAdmin_dataGridView1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BookNameAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.SearchAdmin_btn, 0);
            this.Controls.SetChildIndex(this.ViewDetail_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultAdmin_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookList_label;
        private System.Windows.Forms.DataGridView SearchResultAdmin_dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONFLOORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOVERPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchAdmin_btn;
        private System.Windows.Forms.TextBox BookNameAdmin_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource2;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.Button ViewDetail_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
