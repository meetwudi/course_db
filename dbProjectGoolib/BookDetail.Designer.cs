namespace dbProjectGoolib
{
    partial class BookDetail
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
            this.BookCover_picturebox = new System.Windows.Forms.PictureBox();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new dbProjectGoolib.DataSet2();
            this.ISBN_label = new System.Windows.Forms.Label();
            this.BookName_Label = new System.Windows.Forms.Label();
            this.Author_label = new System.Windows.Forms.Label();
            this.Publisher_label = new System.Windows.Forms.Label();
            this.Introduction_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Comment_dataGridView = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dETAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROWID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentContent_textbox = new System.Windows.Forms.TextBox();
            this.Comment_btn = new System.Windows.Forms.Button();
            this.BookeTotal_label = new System.Windows.Forms.Label();
            this.BookAvailable_label = new System.Windows.Forms.Label();
            this.cOMMENTSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.COMMENTSTableAdapter();
            this.Label_label = new System.Windows.Forms.Label();
            this.bOOKSTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKSTableAdapter();
            this.ISBN_Content = new System.Windows.Forms.Label();
            this.BookName_Content = new System.Windows.Forms.Label();
            this.BookAuthor_Content = new System.Windows.Forms.Label();
            this.BookPublisher_Content = new System.Windows.Forms.Label();
            this.BookIntro_Content = new System.Windows.Forms.TextBox();
            this.TotalNum_Content = new System.Windows.Forms.Label();
            this.AvailNum_Content = new System.Windows.Forms.Label();
            this.BookTag_Content = new System.Windows.Forms.ComboBox();
            this.bOOKTAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTAGTableAdapter = new dbProjectGoolib.DataSet2TableAdapters.BOOKTAGTableAdapter();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKTAGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookCover_picturebox
            // 
            this.BookCover_picturebox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.bOOKSBindingSource, "COVER_PATH", true));
            this.BookCover_picturebox.Location = new System.Drawing.Point(12, 13);
            this.BookCover_picturebox.Name = "BookCover_picturebox";
            this.BookCover_picturebox.Size = new System.Drawing.Size(136, 166);
            this.BookCover_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookCover_picturebox.TabIndex = 0;
            this.BookCover_picturebox.TabStop = false;
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
            // ISBN_label
            // 
            this.ISBN_label.AutoSize = true;
            this.ISBN_label.Location = new System.Drawing.Point(174, 26);
            this.ISBN_label.Name = "ISBN_label";
            this.ISBN_label.Size = new System.Drawing.Size(44, 13);
            this.ISBN_label.TabIndex = 1;
            this.ISBN_label.Text = "ISBN：";
            // 
            // BookName_Label
            // 
            this.BookName_Label.AutoSize = true;
            this.BookName_Label.Location = new System.Drawing.Point(174, 58);
            this.BookName_Label.Name = "BookName_Label";
            this.BookName_Label.Size = new System.Drawing.Size(43, 13);
            this.BookName_Label.TabIndex = 2;
            this.BookName_Label.Text = "书名：";
            // 
            // Author_label
            // 
            this.Author_label.AutoSize = true;
            this.Author_label.Location = new System.Drawing.Point(174, 89);
            this.Author_label.Name = "Author_label";
            this.Author_label.Size = new System.Drawing.Size(43, 13);
            this.Author_label.TabIndex = 3;
            this.Author_label.Text = "作者：";
            // 
            // Publisher_label
            // 
            this.Publisher_label.AutoSize = true;
            this.Publisher_label.Location = new System.Drawing.Point(174, 119);
            this.Publisher_label.Name = "Publisher_label";
            this.Publisher_label.Size = new System.Drawing.Size(55, 13);
            this.Publisher_label.TabIndex = 4;
            this.Publisher_label.Text = "出版社：";
            // 
            // Introduction_label
            // 
            this.Introduction_label.AutoSize = true;
            this.Introduction_label.Location = new System.Drawing.Point(29, 200);
            this.Introduction_label.Name = "Introduction_label";
            this.Introduction_label.Size = new System.Drawing.Size(43, 13);
            this.Introduction_label.TabIndex = 5;
            this.Introduction_label.Text = "简介：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "书籍状态：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "书评：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Comment_dataGridView
            // 
            this.Comment_dataGridView.AllowUserToAddRows = false;
            this.Comment_dataGridView.AllowUserToDeleteRows = false;
            this.Comment_dataGridView.AutoGenerateColumns = false;
            this.Comment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comment_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.dETAILDataGridViewTextBoxColumn,
            this.cOMMENTDATEDataGridViewTextBoxColumn,
            this.ROWID});
            this.Comment_dataGridView.DataSource = this.dataSet2BindingSource;
            this.Comment_dataGridView.Location = new System.Drawing.Point(32, 374);
            this.Comment_dataGridView.Name = "Comment_dataGridView";
            this.Comment_dataGridView.ReadOnly = true;
            this.Comment_dataGridView.RowHeadersVisible = false;
            this.Comment_dataGridView.RowTemplate.Height = 23;
            this.Comment_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Comment_dataGridView.Size = new System.Drawing.Size(382, 130);
            this.Comment_dataGridView.TabIndex = 9;
            this.Comment_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 80;
            // 
            // dETAILDataGridViewTextBoxColumn
            // 
            this.dETAILDataGridViewTextBoxColumn.DataPropertyName = "DETAIL";
            this.dETAILDataGridViewTextBoxColumn.HeaderText = "评论内容";
            this.dETAILDataGridViewTextBoxColumn.Name = "dETAILDataGridViewTextBoxColumn";
            this.dETAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.dETAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // cOMMENTDATEDataGridViewTextBoxColumn
            // 
            this.cOMMENTDATEDataGridViewTextBoxColumn.DataPropertyName = "COMMENT_DATE";
            this.cOMMENTDATEDataGridViewTextBoxColumn.HeaderText = "日期";
            this.cOMMENTDATEDataGridViewTextBoxColumn.Name = "cOMMENTDATEDataGridViewTextBoxColumn";
            this.cOMMENTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMMENTDATEDataGridViewTextBoxColumn.Width = 80;
            // 
            // ROWID
            // 
            this.ROWID.DataPropertyName = "ROWID";
            this.ROWID.HeaderText = "ROWID";
            this.ROWID.Name = "ROWID";
            this.ROWID.ReadOnly = true;
            this.ROWID.Visible = false;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataMember = "COMMENTS";
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Filter = "BOOK_ID = 1";
            // 
            // CommentContent_textbox
            // 
            this.CommentContent_textbox.Location = new System.Drawing.Point(32, 510);
            this.CommentContent_textbox.Multiline = true;
            this.CommentContent_textbox.Name = "CommentContent_textbox";
            this.CommentContent_textbox.Size = new System.Drawing.Size(382, 85);
            this.CommentContent_textbox.TabIndex = 10;
            this.CommentContent_textbox.TextChanged += new System.EventHandler(this.CommentContent_textbox_TextChanged);
            // 
            // Comment_btn
            // 
            this.Comment_btn.Location = new System.Drawing.Point(339, 601);
            this.Comment_btn.Name = "Comment_btn";
            this.Comment_btn.Size = new System.Drawing.Size(75, 25);
            this.Comment_btn.TabIndex = 11;
            this.Comment_btn.Text = "评论";
            this.Comment_btn.UseVisualStyleBackColor = true;
            this.Comment_btn.Click += new System.EventHandler(this.Comment_btn_Click);
            // 
            // BookeTotal_label
            // 
            this.BookeTotal_label.AutoSize = true;
            this.BookeTotal_label.Location = new System.Drawing.Point(93, 301);
            this.BookeTotal_label.Name = "BookeTotal_label";
            this.BookeTotal_label.Size = new System.Drawing.Size(43, 13);
            this.BookeTotal_label.TabIndex = 12;
            this.BookeTotal_label.Text = "总数：";
            this.BookeTotal_label.Click += new System.EventHandler(this.BookeTotal_label_Click);
            // 
            // BookAvailable_label
            // 
            this.BookAvailable_label.AutoSize = true;
            this.BookAvailable_label.Location = new System.Drawing.Point(93, 331);
            this.BookAvailable_label.Name = "BookAvailable_label";
            this.BookAvailable_label.Size = new System.Drawing.Size(43, 13);
            this.BookAvailable_label.TabIndex = 13;
            this.BookAvailable_label.Text = "可用：";
            this.BookAvailable_label.Click += new System.EventHandler(this.BookAvailable_label_Click);
            // 
            // cOMMENTSTableAdapter
            // 
            this.cOMMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // Label_label
            // 
            this.Label_label.AutoSize = true;
            this.Label_label.Location = new System.Drawing.Point(174, 156);
            this.Label_label.Name = "Label_label";
            this.Label_label.Size = new System.Drawing.Size(43, 13);
            this.Label_label.TabIndex = 14;
            this.Label_label.Text = "标签：";
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // ISBN_Content
            // 
            this.ISBN_Content.AutoSize = true;
            this.ISBN_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ISBN13", true));
            this.ISBN_Content.Location = new System.Drawing.Point(251, 26);
            this.ISBN_Content.Name = "ISBN_Content";
            this.ISBN_Content.Size = new System.Drawing.Size(67, 13);
            this.ISBN_Content.TabIndex = 15;
            this.ISBN_Content.Text = "1234567890";
            // 
            // BookName_Content
            // 
            this.BookName_Content.AutoSize = true;
            this.BookName_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "NAME", true));
            this.BookName_Content.Location = new System.Drawing.Point(251, 58);
            this.BookName_Content.Name = "BookName_Content";
            this.BookName_Content.Size = new System.Drawing.Size(77, 13);
            this.BookName_Content.TabIndex = 16;
            this.BookName_Content.Text = "Design Pattern";
            // 
            // BookAuthor_Content
            // 
            this.BookAuthor_Content.AutoSize = true;
            this.BookAuthor_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "AUTHOR", true));
            this.BookAuthor_Content.Location = new System.Drawing.Point(251, 89);
            this.BookAuthor_Content.Name = "BookAuthor_Content";
            this.BookAuthor_Content.Size = new System.Drawing.Size(37, 13);
            this.BookAuthor_Content.TabIndex = 17;
            this.BookAuthor_Content.Text = "JJHou";
            // 
            // BookPublisher_Content
            // 
            this.BookPublisher_Content.AutoSize = true;
            this.BookPublisher_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PUBLISHER", true));
            this.BookPublisher_Content.Location = new System.Drawing.Point(251, 119);
            this.BookPublisher_Content.Name = "BookPublisher_Content";
            this.BookPublisher_Content.Size = new System.Drawing.Size(82, 13);
            this.BookPublisher_Content.TabIndex = 18;
            this.BookPublisher_Content.Text = "Tongji Publisher";
            // 
            // BookIntro_Content
            // 
            this.BookIntro_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "INTRO", true));
            this.BookIntro_Content.Location = new System.Drawing.Point(32, 216);
            this.BookIntro_Content.Multiline = true;
            this.BookIntro_Content.Name = "BookIntro_Content";
            this.BookIntro_Content.ReadOnly = true;
            this.BookIntro_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookIntro_Content.Size = new System.Drawing.Size(382, 69);
            this.BookIntro_Content.TabIndex = 19;
            // 
            // TotalNum_Content
            // 
            this.TotalNum_Content.AutoSize = true;
            this.TotalNum_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "TOTAL_NUMBER", true));
            this.TotalNum_Content.Location = new System.Drawing.Point(137, 301);
            this.TotalNum_Content.Name = "TotalNum_Content";
            this.TotalNum_Content.Size = new System.Drawing.Size(13, 13);
            this.TotalNum_Content.TabIndex = 20;
            this.TotalNum_Content.Text = "5";
            // 
            // AvailNum_Content
            // 
            this.AvailNum_Content.AutoSize = true;
            this.AvailNum_Content.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "AVAILABLE_NUMBER", true));
            this.AvailNum_Content.Location = new System.Drawing.Point(137, 331);
            this.AvailNum_Content.Name = "AvailNum_Content";
            this.AvailNum_Content.Size = new System.Drawing.Size(13, 13);
            this.AvailNum_Content.TabIndex = 21;
            this.AvailNum_Content.Text = "0";
            // 
            // BookTag_Content
            // 
            this.BookTag_Content.DataSource = this.bOOKTAGBindingSource;
            this.BookTag_Content.DisplayMember = "TAG_NAME";
            this.BookTag_Content.FormattingEnabled = true;
            this.BookTag_Content.Location = new System.Drawing.Point(254, 153);
            this.BookTag_Content.Name = "BookTag_Content";
            this.BookTag_Content.Size = new System.Drawing.Size(121, 21);
            this.BookTag_Content.TabIndex = 22;
            // 
            // bOOKTAGBindingSource
            // 
            this.bOOKTAGBindingSource.DataMember = "BOOKTAG";
            this.bOOKTAGBindingSource.DataSource = this.dataSet2;
            // 
            // bOOKTAGTableAdapter
            // 
            this.bOOKTAGTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(146, 602);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 24);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "删除书评 ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // BookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 635);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.BookTag_Content);
            this.Controls.Add(this.AvailNum_Content);
            this.Controls.Add(this.TotalNum_Content);
            this.Controls.Add(this.BookIntro_Content);
            this.Controls.Add(this.BookPublisher_Content);
            this.Controls.Add(this.BookAuthor_Content);
            this.Controls.Add(this.BookName_Content);
            this.Controls.Add(this.ISBN_Content);
            this.Controls.Add(this.Label_label);
            this.Controls.Add(this.BookAvailable_label);
            this.Controls.Add(this.BookeTotal_label);
            this.Controls.Add(this.Comment_btn);
            this.Controls.Add(this.CommentContent_textbox);
            this.Controls.Add(this.Comment_dataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Introduction_label);
            this.Controls.Add(this.Publisher_label);
            this.Controls.Add(this.Author_label);
            this.Controls.Add(this.BookName_Label);
            this.Controls.Add(this.ISBN_label);
            this.Controls.Add(this.BookCover_picturebox);
            this.Name = "BookDetail";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.BookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookCover_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKTAGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookCover_picturebox;
        private System.Windows.Forms.Label ISBN_label;
        private System.Windows.Forms.Label BookName_Label;
        private System.Windows.Forms.Label Author_label;
        private System.Windows.Forms.Label Publisher_label;
        private System.Windows.Forms.Label Introduction_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Comment_dataGridView;
        private System.Windows.Forms.TextBox CommentContent_textbox;
        private System.Windows.Forms.Button Comment_btn;
        private System.Windows.Forms.Label BookeTotal_label;
        private System.Windows.Forms.Label BookAvailable_label;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.COMMENTSTableAdapter cOMMENTSTableAdapter;
        private System.Windows.Forms.Label Label_label;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private DataSet2TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.Label ISBN_Content;
        private System.Windows.Forms.Label BookName_Content;
        private System.Windows.Forms.Label BookAuthor_Content;
        private System.Windows.Forms.Label BookPublisher_Content;
        private System.Windows.Forms.TextBox BookIntro_Content;
        private System.Windows.Forms.Label TotalNum_Content;
        private System.Windows.Forms.Label AvailNum_Content;
        private System.Windows.Forms.ComboBox BookTag_Content;
        private System.Windows.Forms.BindingSource bOOKTAGBindingSource;
        private DataSet2TableAdapters.BOOKTAGTableAdapter bOOKTAGTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dETAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROWID;
    }
}