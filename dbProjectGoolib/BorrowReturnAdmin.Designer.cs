namespace dbProjectGoolib
{
    partial class BorrowReturnAdmin
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
            this.UsernameAdmin_textbox = new System.Windows.Forms.TextBox();
            this.userID_label = new System.Windows.Forms.Label();
            this.Borrow_btn = new System.Windows.Forms.Button();
            this.Return_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(81, 86);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(29, 12);
            this.isbn_label.TabIndex = 2;
            this.isbn_label.Text = "ISBN";
            // 
            // isbn_textBox
            // 
            this.isbn_textBox.Location = new System.Drawing.Point(145, 83);
            this.isbn_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isbn_textBox.Name = "isbn_textBox";
            this.isbn_textBox.Size = new System.Drawing.Size(158, 21);
            this.isbn_textBox.TabIndex = 3;
            // 
            // UsernameAdmin_textbox
            // 
            this.UsernameAdmin_textbox.Location = new System.Drawing.Point(145, 149);
            this.UsernameAdmin_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameAdmin_textbox.Name = "UsernameAdmin_textbox";
            this.UsernameAdmin_textbox.Size = new System.Drawing.Size(158, 21);
            this.UsernameAdmin_textbox.TabIndex = 4;
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(81, 151);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(41, 12);
            this.userID_label.TabIndex = 5;
            this.userID_label.Text = "用户名";
            // 
            // Borrow_btn
            // 
            this.Borrow_btn.Location = new System.Drawing.Point(83, 229);
            this.Borrow_btn.Name = "Borrow_btn";
            this.Borrow_btn.Size = new System.Drawing.Size(71, 23);
            this.Borrow_btn.TabIndex = 7;
            this.Borrow_btn.Text = "借阅书籍";
            this.Borrow_btn.UseVisualStyleBackColor = true;
            this.Borrow_btn.Click += new System.EventHandler(this.Borrow_btn_Click);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(253, 229);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(71, 23);
            this.Return_btn.TabIndex = 8;
            this.Return_btn.Text = "返还书籍";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "借书/还书";
            // 
            // BorrowReturnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Borrow_btn);
            this.Controls.Add(this.userID_label);
            this.Controls.Add(this.UsernameAdmin_textbox);
            this.Controls.Add(this.isbn_textBox);
            this.Controls.Add(this.isbn_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowReturnAdmin";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.isbn_label, 0);
            this.Controls.SetChildIndex(this.isbn_textBox, 0);
            this.Controls.SetChildIndex(this.UsernameAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.userID_label, 0);
            this.Controls.SetChildIndex(this.Borrow_btn, 0);
            this.Controls.SetChildIndex(this.Return_btn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox isbn_textBox;
        private System.Windows.Forms.TextBox UsernameAdmin_textbox;
        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.Button Borrow_btn;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
