namespace dbProjectGoolib
{
    partial class AddBookAdmin
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
            this.isbn_label = new System.Windows.Forms.Label();
            this.isbn_textBox = new System.Windows.Forms.TextBox();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.floor_label = new System.Windows.Forms.Label();
            this.floor_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(65, 88);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 1;
            this.isbn_label.Text = "ISBN";
            // 
            // isbn_textBox
            // 
            this.isbn_textBox.Location = new System.Drawing.Point(122, 85);
            this.isbn_textBox.Name = "isbn_textBox";
            this.isbn_textBox.Size = new System.Drawing.Size(158, 20);
            this.isbn_textBox.TabIndex = 2;
            this.isbn_textBox.TextChanged += new System.EventHandler(this.isbn_textBox_TextChanged);
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Location = new System.Drawing.Point(160, 192);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(74, 25);
            this.AddBook_btn.TabIndex = 3;
            this.AddBook_btn.Text = "添加";
            this.AddBook_btn.UseVisualStyleBackColor = true;
            this.AddBook_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "录入书籍";
            // 
            // floor_label
            // 
            this.floor_label.AutoSize = true;
            this.floor_label.Location = new System.Drawing.Point(65, 120);
            this.floor_label.Name = "floor_label";
            this.floor_label.Size = new System.Drawing.Size(31, 13);
            this.floor_label.TabIndex = 13;
            this.floor_label.Text = "楼层";
            // 
            // floor_combo
            // 
            this.floor_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor_combo.FormattingEnabled = true;
            this.floor_combo.Location = new System.Drawing.Point(122, 117);
            this.floor_combo.Name = "floor_combo";
            this.floor_combo.Size = new System.Drawing.Size(158, 21);
            this.floor_combo.TabIndex = 14;
            // 
            // AddBookAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(467, 438);
            this.Controls.Add(this.floor_combo);
            this.Controls.Add(this.floor_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddBook_btn);
            this.Controls.Add(this.isbn_textBox);
            this.Controls.Add(this.isbn_label);
            this.MaximumSize = new System.Drawing.Size(475, 465);
            this.MinimumSize = new System.Drawing.Size(475, 465);
            this.Name = "AddBookAdmin";
            this.Load += new System.EventHandler(this.AddBookAdmin_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.isbn_label, 0);
            this.Controls.SetChildIndex(this.isbn_textBox, 0);
            this.Controls.SetChildIndex(this.AddBook_btn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.floor_label, 0);
            this.Controls.SetChildIndex(this.floor_combo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox isbn_textBox;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label floor_label;
        private System.Windows.Forms.ComboBox floor_combo;
    }
}
