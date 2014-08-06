namespace dbProjectGoolib
{
    partial class HandleRecommend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_handle = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECOMMENDATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.rECOMMENDATIONSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.RECOMMENDATIONSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_handle
            // 
            this.btn_handle.Location = new System.Drawing.Point(130, 505);
            this.btn_handle.Name = "btn_handle";
            this.btn_handle.Size = new System.Drawing.Size(165, 54);
            this.btn_handle.TabIndex = 0;
            this.btn_handle.Text = "Handle";
            this.btn_handle.UseVisualStyleBackColor = true;
            this.btn_handle.Click += new System.EventHandler(this.btn_handle_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(431, 505);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(154, 54);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn,
            this.rECOMMENDDATEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rECOMMENDATIONSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 323);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            // 
            // rECOMMENDDATEDataGridViewTextBoxColumn
            // 
            this.rECOMMENDDATEDataGridViewTextBoxColumn.DataPropertyName = "RECOMMEND_DATE";
            this.rECOMMENDDATEDataGridViewTextBoxColumn.HeaderText = "RECOMMEND_DATE";
            this.rECOMMENDDATEDataGridViewTextBoxColumn.Name = "rECOMMENDDATEDataGridViewTextBoxColumn";
            // 
            // sTATEDataGridViewTextBoxColumn
            // 
            this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewTextBoxColumn.HeaderText = "STATE";
            this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
            // 
            // rECOMMENDATIONSBindingSource
            // 
            this.rECOMMENDATIONSBindingSource.DataMember = "RECOMMENDATIONS";
            this.rECOMMENDATIONSBindingSource.DataSource = this.dataSet2;
            this.rECOMMENDATIONSBindingSource.Filter = "state=\'N\'";
            // 
            // dataSet1
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECOMMENDATIONSTableAdapter
            // 
            this.rECOMMENDATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // HandleRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_handle);
            this.Name = "HandleRecommend";
            this.Text = "HandleRecommend";
            this.Load += new System.EventHandler(this.HandleRecommend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECOMMENDATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_handle;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rECOMMENDATIONSBindingSource;
        private DataSet2TableAdapters.RECOMMENDATIONSTableAdapter rECOMMENDATIONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECOMMENDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
    }
}