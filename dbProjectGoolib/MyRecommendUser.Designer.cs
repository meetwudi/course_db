namespace dbProjectGoolib
{
    partial class MyRecommendUser
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
            this.RecommendHistory_dataGridView = new System.Windows.Forms.DataGridView();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.rECOMMENDATIONSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.RECOMMENDATIONSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendHistory_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "我的荐购";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "----------------------------------------------------------------------";
            // 
            // RecommendHistory_dataGridView
            // 
            this.RecommendHistory_dataGridView.AllowUserToAddRows = false;
            this.RecommendHistory_dataGridView.AllowUserToDeleteRows = false;
            this.RecommendHistory_dataGridView.AutoGenerateColumns = false;
            this.RecommendHistory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecommendHistory_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn,
            this.rECOMMENDDATEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn,
            this.USER_ID});
            this.RecommendHistory_dataGridView.DataSource = this.rECOMMENDATIONSBindingSource;
            this.RecommendHistory_dataGridView.Location = new System.Drawing.Point(18, 88);
            this.RecommendHistory_dataGridView.Name = "RecommendHistory_dataGridView";
            this.RecommendHistory_dataGridView.ReadOnly = true;
            this.RecommendHistory_dataGridView.RowHeadersVisible = false;
            this.RecommendHistory_dataGridView.RowTemplate.Height = 23;
            this.RecommendHistory_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecommendHistory_dataGridView.Size = new System.Drawing.Size(504, 234);
            this.RecommendHistory_dataGridView.TabIndex = 3;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "书名";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "作者";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            this.aUTHORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "备注";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECOMMENDDATEDataGridViewTextBoxColumn
            // 
            this.rECOMMENDDATEDataGridViewTextBoxColumn.DataPropertyName = "RECOMMEND_DATE";
            this.rECOMMENDDATEDataGridViewTextBoxColumn.HeaderText = "推荐时间";
            this.rECOMMENDDATEDataGridViewTextBoxColumn.Name = "rECOMMENDDATEDataGridViewTextBoxColumn";
            this.rECOMMENDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATEDataGridViewTextBoxColumn
            // 
            this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewTextBoxColumn.HeaderText = "状态";
            this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
            this.sTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.ReadOnly = true;
            this.USER_ID.Visible = false;
            // 
            // rECOMMENDATIONSBindingSource
            // 
            this.rECOMMENDATIONSBindingSource.DataMember = "RECOMMENDATIONS";
            this.rECOMMENDATIONSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECOMMENDATIONSTableAdapter
            // 
            this.rECOMMENDATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // MyRecommendUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 373);
            this.Controls.Add(this.RecommendHistory_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(566, 411);
            this.MinimumSize = new System.Drawing.Size(566, 411);
            this.Name = "MyRecommendUser";
            this.Load += new System.EventHandler(this.MyRecommendUser_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.RecommendHistory_dataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendHistory_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RecommendHistory_dataGridView;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rECOMMENDATIONSBindingSource;
        private DataSet2TableAdapters.RECOMMENDATIONSTableAdapter rECOMMENDATIONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECOMMENDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
    }
}
