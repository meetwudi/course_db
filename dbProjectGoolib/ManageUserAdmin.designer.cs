namespace dbProjectGoolib
{
    partial class ManageUserAdmin
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
            this.userID_label = new System.Windows.Forms.Label();
            this.UsernameAdmin_textbox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.ManageUser_dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEALNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.SetAsAdmin_btn = new System.Windows.Forms.Button();
            this.DeleteUser_btn = new System.Windows.Forms.Button();
            this.ResetPSW_btn = new System.Windows.Forms.Button();
            this.uSERSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.USERSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(67, 88);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(43, 13);
            this.userID_label.TabIndex = 1;
            this.userID_label.Text = "用户名";
            // 
            // UsernameAdmin_textbox
            // 
            this.UsernameAdmin_textbox.Location = new System.Drawing.Point(134, 85);
            this.UsernameAdmin_textbox.Name = "UsernameAdmin_textbox";
            this.UsernameAdmin_textbox.Size = new System.Drawing.Size(157, 20);
            this.UsernameAdmin_textbox.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(331, 81);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(46, 25);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "搜索";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // ManageUser_dataGridView
            // 
            this.ManageUser_dataGridView.AllowUserToAddRows = false;
            this.ManageUser_dataGridView.AllowUserToDeleteRows = false;
            this.ManageUser_dataGridView.AutoGenerateColumns = false;
            this.ManageUser_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageUser_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.rEALNAMEDataGridViewTextBoxColumn,
            this.pHONENUMBERDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.ManageUser_dataGridView.DataSource = this.uSERSBindingSource;
            this.ManageUser_dataGridView.Location = new System.Drawing.Point(59, 130);
            this.ManageUser_dataGridView.Name = "ManageUser_dataGridView";
            this.ManageUser_dataGridView.ReadOnly = true;
            this.ManageUser_dataGridView.RowHeadersVisible = false;
            this.ManageUser_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageUser_dataGridView.Size = new System.Drawing.Size(344, 129);
            this.ManageUser_dataGridView.TabIndex = 4;
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
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEALNAMEDataGridViewTextBoxColumn
            // 
            this.rEALNAMEDataGridViewTextBoxColumn.DataPropertyName = "REAL_NAME";
            this.rEALNAMEDataGridViewTextBoxColumn.HeaderText = "真实姓名";
            this.rEALNAMEDataGridViewTextBoxColumn.Name = "rEALNAMEDataGridViewTextBoxColumn";
            this.rEALNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHONENUMBERDataGridViewTextBoxColumn
            // 
            this.pHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "PHONE_NUMBER";
            this.pHONENUMBERDataGridViewTextBoxColumn.HeaderText = "手机号码";
            this.pHONENUMBERDataGridViewTextBoxColumn.Name = "pHONENUMBERDataGridViewTextBoxColumn";
            this.pHONENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SetAsAdmin_btn
            // 
            this.SetAsAdmin_btn.Location = new System.Drawing.Point(75, 294);
            this.SetAsAdmin_btn.Name = "SetAsAdmin_btn";
            this.SetAsAdmin_btn.Size = new System.Drawing.Size(82, 25);
            this.SetAsAdmin_btn.TabIndex = 5;
            this.SetAsAdmin_btn.Text = "设为管理员";
            this.SetAsAdmin_btn.UseVisualStyleBackColor = true;
            this.SetAsAdmin_btn.Click += new System.EventHandler(this.SetAsAdmin_btn_Click);
            // 
            // DeleteUser_btn
            // 
            this.DeleteUser_btn.Location = new System.Drawing.Point(189, 294);
            this.DeleteUser_btn.Name = "DeleteUser_btn";
            this.DeleteUser_btn.Size = new System.Drawing.Size(71, 25);
            this.DeleteUser_btn.TabIndex = 6;
            this.DeleteUser_btn.Text = "删除用户";
            this.DeleteUser_btn.UseVisualStyleBackColor = true;
            this.DeleteUser_btn.Click += new System.EventHandler(this.DeleteUser_btn_Click);
            // 
            // ResetPSW_btn
            // 
            this.ResetPSW_btn.Location = new System.Drawing.Point(291, 294);
            this.ResetPSW_btn.Name = "ResetPSW_btn";
            this.ResetPSW_btn.Size = new System.Drawing.Size(71, 25);
            this.ResetPSW_btn.TabIndex = 7;
            this.ResetPSW_btn.Text = "重置密码";
            this.ResetPSW_btn.UseVisualStyleBackColor = true;
            this.ResetPSW_btn.Click += new System.EventHandler(this.ResetPSW_btn_Click);
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
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
            this.label4.Text = "管理用户";
            // 
            // ManageUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResetPSW_btn);
            this.Controls.Add(this.DeleteUser_btn);
            this.Controls.Add(this.SetAsAdmin_btn);
            this.Controls.Add(this.ManageUser_dataGridView);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.UsernameAdmin_textbox);
            this.Controls.Add(this.userID_label);
            this.MaximumSize = new System.Drawing.Size(475, 464);
            this.MinimumSize = new System.Drawing.Size(475, 464);
            this.Name = "ManageUserAdmin";
            this.Load += new System.EventHandler(this.ManageUserAdmin_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.userID_label, 0);
            this.Controls.SetChildIndex(this.UsernameAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.ManageUser_dataGridView, 0);
            this.Controls.SetChildIndex(this.SetAsAdmin_btn, 0);
            this.Controls.SetChildIndex(this.DeleteUser_btn, 0);
            this.Controls.SetChildIndex(this.ResetPSW_btn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.TextBox UsernameAdmin_textbox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView ManageUser_dataGridView;
        private System.Windows.Forms.Button SetAsAdmin_btn;
        private System.Windows.Forms.Button DeleteUser_btn;
        private System.Windows.Forms.Button ResetPSW_btn;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private DataSet2TableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEALNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
