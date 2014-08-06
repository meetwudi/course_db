namespace dbProjectGoolib
{
    partial class BookIndexUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookNameUser_textbox = new System.Windows.Forms.TextBox();
            this.SearchUser_btn = new System.Windows.Forms.Button();
            this.SearchResultUser_dataGridView = new System.Windows.Forms.DataGridView();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.bOOKSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKSTableAdapter();
            this.ViewDetail_btn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVAILABLE_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCATION_FLOOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultUser_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "书籍索引";
            // 
            // BookNameUser_textbox
            // 
            this.BookNameUser_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BookNameUser_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BookNameUser_textbox.Location = new System.Drawing.Point(38, 82);
            this.BookNameUser_textbox.Name = "BookNameUser_textbox";
            this.BookNameUser_textbox.Size = new System.Drawing.Size(193, 20);
            this.BookNameUser_textbox.TabIndex = 6;
            // 
            // SearchUser_btn
            // 
            this.SearchUser_btn.Location = new System.Drawing.Point(237, 79);
            this.SearchUser_btn.Name = "SearchUser_btn";
            this.SearchUser_btn.Size = new System.Drawing.Size(75, 25);
            this.SearchUser_btn.TabIndex = 7;
            this.SearchUser_btn.Text = "搜索";
            this.SearchUser_btn.UseVisualStyleBackColor = true;
            this.SearchUser_btn.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchResultUser_dataGridView
            // 
            this.SearchResultUser_dataGridView.AllowUserToAddRows = false;
            this.SearchResultUser_dataGridView.AllowUserToDeleteRows = false;
            this.SearchResultUser_dataGridView.AutoGenerateColumns = false;
            this.SearchResultUser_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultUser_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iSBN13DataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn,
            this.TOTAL_NUMBER,
            this.AVAILABLE_NUMBER,
            this.LOCATION_FLOOR});
            this.SearchResultUser_dataGridView.DataSource = this.bOOKSBindingSource;
            this.SearchResultUser_dataGridView.Location = new System.Drawing.Point(38, 140);
            this.SearchResultUser_dataGridView.MultiSelect = false;
            this.SearchResultUser_dataGridView.Name = "SearchResultUser_dataGridView";
            this.SearchResultUser_dataGridView.ReadOnly = true;
            this.SearchResultUser_dataGridView.RowHeadersVisible = false;
            this.SearchResultUser_dataGridView.RowTemplate.Height = 23;
            this.SearchResultUser_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResultUser_dataGridView.Size = new System.Drawing.Size(374, 197);
            this.SearchResultUser_dataGridView.TabIndex = 8;
            this.SearchResultUser_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultUser_dataGridView_CellContentClick);
            this.SearchResultUser_dataGridView.DoubleClick += new System.EventHandler(this.ViewDetail_btn_Click_1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "书籍列表";
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDetail_btn
            // 
            this.ViewDetail_btn.Location = new System.Drawing.Point(337, 343);
            this.ViewDetail_btn.Name = "ViewDetail_btn";
            this.ViewDetail_btn.Size = new System.Drawing.Size(75, 25);
            this.ViewDetail_btn.TabIndex = 10;
            this.ViewDetail_btn.Text = "查看";
            this.ViewDetail_btn.UseVisualStyleBackColor = true;
            this.ViewDetail_btn.Click += new System.EventHandler(this.ViewDetail_btn_Click_1);
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
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "作者";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            this.aUTHORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TOTAL_NUMBER
            // 
            this.TOTAL_NUMBER.DataPropertyName = "TOTAL_NUMBER";
            this.TOTAL_NUMBER.HeaderText = "总数";
            this.TOTAL_NUMBER.Name = "TOTAL_NUMBER";
            this.TOTAL_NUMBER.ReadOnly = true;
            // 
            // AVAILABLE_NUMBER
            // 
            this.AVAILABLE_NUMBER.DataPropertyName = "AVAILABLE_NUMBER";
            this.AVAILABLE_NUMBER.HeaderText = "可借数";
            this.AVAILABLE_NUMBER.Name = "AVAILABLE_NUMBER";
            this.AVAILABLE_NUMBER.ReadOnly = true;
            // 
            // LOCATION_FLOOR
            // 
            this.LOCATION_FLOOR.DataPropertyName = "LOCATION_FLOOR";
            this.LOCATION_FLOOR.HeaderText = "楼层";
            this.LOCATION_FLOOR.Name = "LOCATION_FLOOR";
            this.LOCATION_FLOOR.ReadOnly = true;
            // 
            // BookIndexUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 427);
            this.Controls.Add(this.ViewDetail_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchResultUser_dataGridView);
            this.Controls.Add(this.SearchUser_btn);
            this.Controls.Add(this.BookNameUser_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(475, 465);
            this.MinimumSize = new System.Drawing.Size(475, 465);
            this.Name = "BookIndexUser";
            this.Load += new System.EventHandler(this.Index_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.BookNameUser_textbox, 0);
            this.Controls.SetChildIndex(this.SearchUser_btn, 0);
            this.Controls.SetChildIndex(this.SearchResultUser_dataGridView, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ViewDetail_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultUser_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookNameUser_textbox;
        private System.Windows.Forms.Button SearchUser_btn;
        private System.Windows.Forms.DataGridView SearchResultUser_dataGridView;
        private System.Windows.Forms.Label label3;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.Button ViewDetail_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVAILABLE_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCATION_FLOOR;
    }
}
