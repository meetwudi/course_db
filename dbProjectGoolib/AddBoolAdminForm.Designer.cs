namespace dbProjectGoolib
{
    partial class AddBoolAdminForm
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
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(42, 63);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 1;
            this.isbn_label.Text = "ISBN";
            // 
            // isbn_textBox
            // 
            this.isbn_textBox.Location = new System.Drawing.Point(99, 60);
            this.isbn_textBox.Name = "isbn_textBox";
            this.isbn_textBox.Size = new System.Drawing.Size(158, 20);
            this.isbn_textBox.TabIndex = 2;
            this.isbn_textBox.TextChanged += new System.EventHandler(this.isbn_textBox_TextChanged);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(45, 119);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(74, 25);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.Text = "添加";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // AddBoolAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.isbn_textBox);
            this.Controls.Add(this.isbn_label);
            this.Name = "AddBoolAdminForm";
            this.Controls.SetChildIndex(this.isbn_label, 0);
            this.Controls.SetChildIndex(this.isbn_textBox, 0);
            this.Controls.SetChildIndex(this.confirm_btn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.TextBox isbn_textBox;
        private System.Windows.Forms.Button confirm_btn;
    }
}
