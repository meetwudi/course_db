namespace dbProjectGoolib
{
    partial class ManageBookAdmin
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
            this.isbn_label = new System.Windows.Forms.Label();
            this.SearchISBNAdmin_btn = new System.Windows.Forms.Button();
            this.ISBNAdmin_textbox = new System.Windows.Forms.TextBox();
            this.ManageBookAdmin_dataGridView = new System.Windows.Forms.DataGridView();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONFLOORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.bOOKSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKSTableAdapter();
            this.ViewDetail_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBookAdmin_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(39, 81);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 1;
            this.isbn_label.Text = "ISBN";
            // 
            // SearchISBNAdmin_btn
            // 
            this.SearchISBNAdmin_btn.Location = new System.Drawing.Point(255, 76);
            this.SearchISBNAdmin_btn.Name = "SearchISBNAdmin_btn";
            this.SearchISBNAdmin_btn.Size = new System.Drawing.Size(75, 23);
            this.SearchISBNAdmin_btn.TabIndex = 2;
            this.SearchISBNAdmin_btn.Text = "搜索";
            this.SearchISBNAdmin_btn.UseVisualStyleBackColor = true;
            // 
            // ISBNAdmin_textbox
            // 
            this.ISBNAdmin_textbox.Location = new System.Drawing.Point(77, 78);
            this.ISBNAdmin_textbox.Name = "ISBNAdmin_textbox";
            this.ISBNAdmin_textbox.Size = new System.Drawing.Size(156, 20);
            this.ISBNAdmin_textbox.TabIndex = 3;
            // 
            // ManageBookAdmin_dataGridView
            // 
            this.ManageBookAdmin_dataGridView.AllowUserToAddRows = false;
            this.ManageBookAdmin_dataGridView.AllowUserToDeleteRows = false;
            this.ManageBookAdmin_dataGridView.AutoGenerateColumns = false;
            this.ManageBookAdmin_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageBookAdmin_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.pUBLISHERDataGridViewTextBoxColumn,
            this.pUBLISHDATEDataGridViewTextBoxColumn,
            this.tOTALNUMBERDataGridViewTextBoxColumn,
            this.aVAILABLENUMBERDataGridViewTextBoxColumn,
            this.lOCATIONFLOORDataGridViewTextBoxColumn});
            this.ManageBookAdmin_dataGridView.DataSource = this.bOOKSBindingSource;
            this.ManageBookAdmin_dataGridView.Location = new System.Drawing.Point(19, 116);
            this.ManageBookAdmin_dataGridView.Name = "ManageBookAdmin_dataGridView";
            this.ManageBookAdmin_dataGridView.RowHeadersVisible = false;
            this.ManageBookAdmin_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageBookAdmin_dataGridView.Size = new System.Drawing.Size(515, 224);
            this.ManageBookAdmin_dataGridView.TabIndex = 4;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "作者";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            // 
            // pUBLISHERDataGridViewTextBoxColumn
            // 
            this.pUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.pUBLISHERDataGridViewTextBoxColumn.Name = "pUBLISHERDataGridViewTextBoxColumn";
            // 
            // pUBLISHDATEDataGridViewTextBoxColumn
            // 
            this.pUBLISHDATEDataGridViewTextBoxColumn.DataPropertyName = "PUBLISH_DATE";
            this.pUBLISHDATEDataGridViewTextBoxColumn.HeaderText = "出版时间";
            this.pUBLISHDATEDataGridViewTextBoxColumn.Name = "pUBLISHDATEDataGridViewTextBoxColumn";
            // 
            // tOTALNUMBERDataGridViewTextBoxColumn
            // 
            this.tOTALNUMBERDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_NUMBER";
            this.tOTALNUMBERDataGridViewTextBoxColumn.HeaderText = "总数量";
            this.tOTALNUMBERDataGridViewTextBoxColumn.Name = "tOTALNUMBERDataGridViewTextBoxColumn";
            // 
            // aVAILABLENUMBERDataGridViewTextBoxColumn
            // 
            this.aVAILABLENUMBERDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE_NUMBER";
            this.aVAILABLENUMBERDataGridViewTextBoxColumn.HeaderText = "可借数量";
            this.aVAILABLENUMBERDataGridViewTextBoxColumn.Name = "aVAILABLENUMBERDataGridViewTextBoxColumn";
            // 
            // lOCATIONFLOORDataGridViewTextBoxColumn
            // 
            this.lOCATIONFLOORDataGridViewTextBoxColumn.DataPropertyName = "LOCATION_FLOOR";
            this.lOCATIONFLOORDataGridViewTextBoxColumn.HeaderText = "位置";
            this.lOCATIONFLOORDataGridViewTextBoxColumn.Name = "lOCATIONFLOORDataGridViewTextBoxColumn";
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDetail_btn
            // 
            this.ViewDetail_btn.Location = new System.Drawing.Point(459, 352);
            this.ViewDetail_btn.Name = "ViewDetail_btn";
            this.ViewDetail_btn.Size = new System.Drawing.Size(75, 25);
            this.ViewDetail_btn.TabIndex = 5;
            this.ViewDetail_btn.Text = "查看";
            this.ViewDetail_btn.UseVisualStyleBackColor = true;
            this.ViewDetail_btn.Click += new System.EventHandler(this.ViewDetail_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "管理书籍";
            // 
            // ManageBookAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(564, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewDetail_btn);
            this.Controls.Add(this.ManageBookAdmin_dataGridView);
            this.Controls.Add(this.ISBNAdmin_textbox);
            this.Controls.Add(this.SearchISBNAdmin_btn);
            this.Controls.Add(this.isbn_label);
            this.MaximumSize = new System.Drawing.Size(580, 449);
            this.MinimumSize = new System.Drawing.Size(580, 442);
            this.Name = "ManageBookAdmin";
            this.Load += new System.EventHandler(this.ManageBookAdmin_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.isbn_label, 0);
            this.Controls.SetChildIndex(this.SearchISBNAdmin_btn, 0);
            this.Controls.SetChildIndex(this.ISBNAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.ManageBookAdmin_dataGridView, 0);
            this.Controls.SetChildIndex(this.ViewDetail_btn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageBookAdmin_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Button SearchISBNAdmin_btn;
        private System.Windows.Forms.TextBox ISBNAdmin_textbox;
        private System.Windows.Forms.DataGridView ManageBookAdmin_dataGridView;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONFLOORDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ViewDetail_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
