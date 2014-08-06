namespace dbProjectGoolib
{
    partial class CurrentBorrowUser
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
            this.BorrowUser_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewDeta_btn = new System.Windows.Forms.Button();
            this.bORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.bORROWTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BORROWTableAdapter();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKSTableAdapter();
            this.bORROWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEADLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowUser_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowUser_dataGridView
            // 
            this.BorrowUser_dataGridView.AllowUserToAddRows = false;
            this.BorrowUser_dataGridView.AllowUserToDeleteRows = false;
            this.BorrowUser_dataGridView.AutoGenerateColumns = false;
            this.BorrowUser_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowUser_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn,
            this.bOOKIDDataGridViewTextBoxColumn,
            this.bORROWTIMEDataGridViewTextBoxColumn,
            this.rETURNTIMEDataGridViewTextBoxColumn,
            this.dEADLINEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewTextBoxColumn});
            this.BorrowUser_dataGridView.DataSource = this.bORROWBindingSource1;
            this.BorrowUser_dataGridView.Location = new System.Drawing.Point(34, 77);
            this.BorrowUser_dataGridView.Name = "BorrowUser_dataGridView";
            this.BorrowUser_dataGridView.ReadOnly = true;
            this.BorrowUser_dataGridView.RowHeadersVisible = false;
            this.BorrowUser_dataGridView.RowTemplate.Height = 23;
            this.BorrowUser_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowUser_dataGridView.Size = new System.Drawing.Size(393, 247);
            this.BorrowUser_dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前借阅";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // ViewDeta_btn
            // 
            this.ViewDeta_btn.Location = new System.Drawing.Point(352, 342);
            this.ViewDeta_btn.Name = "ViewDeta_btn";
            this.ViewDeta_btn.Size = new System.Drawing.Size(75, 25);
            this.ViewDeta_btn.TabIndex = 4;
            this.ViewDeta_btn.Text = "查看";
            this.ViewDeta_btn.UseVisualStyleBackColor = true;
            this.ViewDeta_btn.Click += new System.EventHandler(this.ViewDeta_btn_Click);
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
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.dataSet2;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // bORROWBindingSource1
            // 
            this.bORROWBindingSource1.DataMember = "BORROW";
            this.bORROWBindingSource1.DataSource = this.dataSet2;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "书名";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKIDDataGridViewTextBoxColumn
            // 
            this.bOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOK_ID";
            this.bOOKIDDataGridViewTextBoxColumn.Name = "bOOKIDDataGridViewTextBoxColumn";
            this.bOOKIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKIDDataGridViewTextBoxColumn.Visible = false;
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
            // dEADLINEDataGridViewTextBoxColumn
            // 
            this.dEADLINEDataGridViewTextBoxColumn.DataPropertyName = "DEADLINE";
            this.dEADLINEDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.dEADLINEDataGridViewTextBoxColumn.Name = "dEADLINEDataGridViewTextBoxColumn";
            this.dEADLINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATEDataGridViewTextBoxColumn
            // 
            this.sTATEDataGridViewTextBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewTextBoxColumn.HeaderText = "归还状态";
            this.sTATEDataGridViewTextBoxColumn.Name = "sTATEDataGridViewTextBoxColumn";
            this.sTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CurrentBorrowUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 426);
            this.Controls.Add(this.ViewDeta_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorrowUser_dataGridView);
            this.MaximumSize = new System.Drawing.Size(475, 464);
            this.MinimumSize = new System.Drawing.Size(475, 464);
            this.Name = "CurrentBorrowUser";
            this.Load += new System.EventHandler(this.CurrentBorrowUser_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.BorrowUser_dataGridView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ViewDeta_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowUser_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BorrowUser_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bORROWBindingSource;
        private DataSet2TableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private System.Windows.Forms.Button ViewDeta_btn;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bORROWTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETURNTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEADLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bORROWBindingSource1;

    }
}
