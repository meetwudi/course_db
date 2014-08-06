namespace dbProjectGoolib
{
    partial class IndexHistoryUser
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
            this.IndexHistoryUser_dataGridView = new System.Windows.Forms.DataGridView();
            this.dETAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEARCHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEARCHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.sEARCHTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.SEARCHTableAdapter();
            this.ViewDetail_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexHistoryUser_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "检索历史";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "---------------------------------------------------------------";
            // 
            // IndexHistoryUser_dataGridView
            // 
            this.IndexHistoryUser_dataGridView.AllowUserToAddRows = false;
            this.IndexHistoryUser_dataGridView.AllowUserToDeleteRows = false;
            this.IndexHistoryUser_dataGridView.AutoGenerateColumns = false;
            this.IndexHistoryUser_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexHistoryUser_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dETAILDataGridViewTextBoxColumn,
            this.sEARCHDATEDataGridViewTextBoxColumn});
            this.IndexHistoryUser_dataGridView.DataSource = this.sEARCHBindingSource1;
            this.IndexHistoryUser_dataGridView.Location = new System.Drawing.Point(32, 94);
            this.IndexHistoryUser_dataGridView.Name = "IndexHistoryUser_dataGridView";
            this.IndexHistoryUser_dataGridView.ReadOnly = true;
            this.IndexHistoryUser_dataGridView.RowHeadersVisible = false;
            this.IndexHistoryUser_dataGridView.RowTemplate.Height = 23;
            this.IndexHistoryUser_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndexHistoryUser_dataGridView.Size = new System.Drawing.Size(325, 218);
            this.IndexHistoryUser_dataGridView.TabIndex = 3;
            // 
            // dETAILDataGridViewTextBoxColumn
            // 
            this.dETAILDataGridViewTextBoxColumn.DataPropertyName = "DETAIL";
            this.dETAILDataGridViewTextBoxColumn.HeaderText = "内容";
            this.dETAILDataGridViewTextBoxColumn.Name = "dETAILDataGridViewTextBoxColumn";
            this.dETAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.dETAILDataGridViewTextBoxColumn.Width = 170;
            // 
            // sEARCHDATEDataGridViewTextBoxColumn
            // 
            this.sEARCHDATEDataGridViewTextBoxColumn.DataPropertyName = "SEARCH_DATE";
            this.sEARCHDATEDataGridViewTextBoxColumn.HeaderText = "检索时间";
            this.sEARCHDATEDataGridViewTextBoxColumn.Name = "sEARCHDATEDataGridViewTextBoxColumn";
            this.sEARCHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEARCHDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // sEARCHBindingSource1
            // 
            this.sEARCHBindingSource1.DataMember = "SEARCH";
            this.sEARCHBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEARCHTableAdapter
            // 
            this.sEARCHTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDetail_btn
            // 
            this.ViewDetail_btn.Location = new System.Drawing.Point(282, 333);
            this.ViewDetail_btn.Name = "ViewDetail_btn";
            this.ViewDetail_btn.Size = new System.Drawing.Size(75, 25);
            this.ViewDetail_btn.TabIndex = 4;
            this.ViewDetail_btn.Text = "查看";
            this.ViewDetail_btn.UseVisualStyleBackColor = true;
            this.ViewDetail_btn.Click += new System.EventHandler(this.ViewDetail_btn_Click);
            // 
            // IndexHistoryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 427);
            this.Controls.Add(this.ViewDetail_btn);
            this.Controls.Add(this.IndexHistoryUser_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(415, 465);
            this.MinimumSize = new System.Drawing.Size(415, 465);
            this.Name = "IndexHistoryUser";
            this.Load += new System.EventHandler(this.IndexHistoryUser_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.IndexHistoryUser_dataGridView, 0);
            this.Controls.SetChildIndex(this.ViewDetail_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexHistoryUser_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView IndexHistoryUser_dataGridView;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.SEARCHTableAdapter sEARCHTableAdapter;
        private System.Windows.Forms.BindingSource sEARCHBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dETAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEARCHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ViewDetail_btn;
    }
}
