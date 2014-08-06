namespace dbProjectGoolib
{
    partial class Log
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rESETDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMIN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESETLOGSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dELETEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETELOGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESETLOGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESETLOGSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.RESETLOGSTableAdapter();
            this.dELETELOGSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.DELETELOGSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESETLOGSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELETELOGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESETLOGSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 367);
            this.pictureBox1.Size = new System.Drawing.Size(435, 10);
            this.pictureBox1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(450, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "重置日志";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rESETDATEDataGridViewTextBoxColumn,
            this.USER_NAME,
            this.ADMIN_NAME});
            this.dataGridView1.DataSource = this.rESETLOGSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(448, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // rESETDATEDataGridViewTextBoxColumn
            // 
            this.rESETDATEDataGridViewTextBoxColumn.DataPropertyName = "RESET_DATE";
            this.rESETDATEDataGridViewTextBoxColumn.HeaderText = "重置日期";
            this.rESETDATEDataGridViewTextBoxColumn.Name = "rESETDATEDataGridViewTextBoxColumn";
            this.rESETDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rESETDATEDataGridViewTextBoxColumn.Width = 300;
            // 
            // USER_NAME
            // 
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "用户名";
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            this.USER_NAME.Width = 200;
            // 
            // ADMIN_NAME
            // 
            this.ADMIN_NAME.DataPropertyName = "ADMIN_NAME";
            this.ADMIN_NAME.HeaderText = "管理员";
            this.ADMIN_NAME.Name = "ADMIN_NAME";
            this.ADMIN_NAME.ReadOnly = true;
            this.ADMIN_NAME.Width = 200;
            // 
            // rESETLOGSBindingSource1
            // 
            this.rESETLOGSBindingSource1.DataMember = "RESETLOGS";
            this.rESETLOGSBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(450, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dELETEDATEDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.aDMINNAMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dELETELOGSBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(446, 365);
            this.dataGridView2.TabIndex = 0;
            // 
            // dELETEDATEDataGridViewTextBoxColumn
            // 
            this.dELETEDATEDataGridViewTextBoxColumn.DataPropertyName = "DELETE_DATE";
            this.dELETEDATEDataGridViewTextBoxColumn.HeaderText = "删除日期 ";
            this.dELETEDATEDataGridViewTextBoxColumn.Name = "dELETEDATEDataGridViewTextBoxColumn";
            this.dELETEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dELETEDATEDataGridViewTextBoxColumn.Width = 300;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // aDMINNAMEDataGridViewTextBoxColumn
            // 
            this.aDMINNAMEDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_NAME";
            this.aDMINNAMEDataGridViewTextBoxColumn.HeaderText = "管理员";
            this.aDMINNAMEDataGridViewTextBoxColumn.Name = "aDMINNAMEDataGridViewTextBoxColumn";
            this.aDMINNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDMINNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // dELETELOGSBindingSource
            // 
            this.dELETELOGSBindingSource.DataMember = "DELETELOGS";
            this.dELETELOGSBindingSource.DataSource = this.dataSet2;
            // 
            // rESETLOGSBindingSource
            // 
            this.rESETLOGSBindingSource.DataMember = "RESETLOGS";
            this.rESETLOGSBindingSource.DataSource = this.dataSet2;
            // 
            // rESETLOGSTableAdapter
            // 
            this.rESETLOGSTableAdapter.ClearBeforeFill = true;
            // 
            // dELETELOGSTableAdapter
            // 
            this.dELETELOGSTableAdapter.ClearBeforeFill = true;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 440);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(470, 478);
            this.MinimumSize = new System.Drawing.Size(470, 478);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESETLOGSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELETELOGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESETLOGSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource rESETLOGSBindingSource;
        private DataSet2TableAdapters.RESETLOGSTableAdapter rESETLOGSTableAdapter;
        private System.Windows.Forms.BindingSource rESETLOGSBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESETDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADMIN_NAME;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dELETELOGSBindingSource;
        private DataSet2TableAdapters.DELETELOGSTableAdapter dELETELOGSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINNAMEDataGridViewTextBoxColumn;


    }
}