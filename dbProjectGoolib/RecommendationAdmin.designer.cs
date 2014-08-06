namespace dbProjectGoolib
{
    partial class RecommendationAdmin
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
            this.RecommendationList_dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.Handle_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rECOMMENDATIONSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.RECOMMENDATIONSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationList_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // RecommendationList_dataGridView
            // 
            this.RecommendationList_dataGridView.AllowUserToAddRows = false;
            this.RecommendationList_dataGridView.AllowUserToDeleteRows = false;
            this.RecommendationList_dataGridView.AutoGenerateColumns = false;
            this.RecommendationList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecommendationList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn,
            this.rECOMMENDDATEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn});
            this.RecommendationList_dataGridView.DataSource = this.rECOMMENDATIONSBindingSource;
            this.RecommendationList_dataGridView.Location = new System.Drawing.Point(29, 80);
            this.RecommendationList_dataGridView.Name = "RecommendationList_dataGridView";
            this.RecommendationList_dataGridView.ReadOnly = true;
            this.RecommendationList_dataGridView.RowHeadersVisible = false;
            this.RecommendationList_dataGridView.RowTemplate.Height = 37;
            this.RecommendationList_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecommendationList_dataGridView.Size = new System.Drawing.Size(391, 246);
            this.RecommendationList_dataGridView.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "推荐用户";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.rECOMMENDDATEDataGridViewTextBoxColumn.HeaderText = "推荐日期";
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
            // rECOMMENDATIONSBindingSource
            // 
            this.rECOMMENDATIONSBindingSource.DataMember = "RECOMMENDATIONS";
            this.rECOMMENDATIONSBindingSource.DataSource = this.dataSet2;
            this.rECOMMENDATIONSBindingSource.Filter = "state=\'N\'";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Handle_btn
            // 
            this.Handle_btn.Location = new System.Drawing.Point(333, 333);
            this.Handle_btn.Name = "Handle_btn";
            this.Handle_btn.Size = new System.Drawing.Size(75, 23);
            this.Handle_btn.TabIndex = 5;
            this.Handle_btn.Text = "处理";
            this.Handle_btn.UseVisualStyleBackColor = true;
            this.Handle_btn.Click += new System.EventHandler(this.Handle_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "查看荐购";
            // 
            // rECOMMENDATIONSTableAdapter
            // 
            this.rECOMMENDATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // RecommendationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(454, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Handle_btn);
            this.Controls.Add(this.RecommendationList_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(470, 411);
            this.Name = "RecommendationAdmin";
            this.Load += new System.EventHandler(this.RecommendationAdmin_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.RecommendationList_dataGridView, 0);
            this.Controls.SetChildIndex(this.Handle_btn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendationList_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecommendationList_dataGridView;
        private System.Windows.Forms.Button Handle_btn;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rECOMMENDATIONSBindingSource;
        private DataSet2TableAdapters.RECOMMENDATIONSTableAdapter rECOMMENDATIONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECOMMENDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
    }
}
