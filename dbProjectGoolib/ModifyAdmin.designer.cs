namespace dbProjectGoolib
{
    partial class ModifyAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPasswordAdmin_textbox = new System.Windows.Forms.TextBox();
            this.NewPasswordAdmin_textbox = new System.Windows.Forms.TextBox();
            this.PasswordConfirmAdmin_textbox = new System.Windows.Forms.TextBox();
            this.SaveInfoAdmin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码";
            // 
            // OldPasswordAdmin_textbox
            // 
            this.OldPasswordAdmin_textbox.Location = new System.Drawing.Point(223, 53);
            this.OldPasswordAdmin_textbox.Name = "OldPasswordAdmin_textbox";
            this.OldPasswordAdmin_textbox.PasswordChar = '*';
            this.OldPasswordAdmin_textbox.Size = new System.Drawing.Size(100, 21);
            this.OldPasswordAdmin_textbox.TabIndex = 7;
            // 
            // NewPasswordAdmin_textbox
            // 
            this.NewPasswordAdmin_textbox.Location = new System.Drawing.Point(223, 121);
            this.NewPasswordAdmin_textbox.Name = "NewPasswordAdmin_textbox";
            this.NewPasswordAdmin_textbox.PasswordChar = '*';
            this.NewPasswordAdmin_textbox.Size = new System.Drawing.Size(100, 21);
            this.NewPasswordAdmin_textbox.TabIndex = 8;
            // 
            // PasswordConfirmAdmin_textbox
            // 
            this.PasswordConfirmAdmin_textbox.Location = new System.Drawing.Point(223, 202);
            this.PasswordConfirmAdmin_textbox.Name = "PasswordConfirmAdmin_textbox";
            this.PasswordConfirmAdmin_textbox.PasswordChar = '*';
            this.PasswordConfirmAdmin_textbox.Size = new System.Drawing.Size(100, 21);
            this.PasswordConfirmAdmin_textbox.TabIndex = 9;
            // 
            // SaveInfoAdmin_btn
            // 
            this.SaveInfoAdmin_btn.Location = new System.Drawing.Point(166, 283);
            this.SaveInfoAdmin_btn.Name = "SaveInfoAdmin_btn";
            this.SaveInfoAdmin_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveInfoAdmin_btn.TabIndex = 13;
            this.SaveInfoAdmin_btn.Text = "保存";
            this.SaveInfoAdmin_btn.UseVisualStyleBackColor = true;
            this.SaveInfoAdmin_btn.Click += new System.EventHandler(this.SaveInfoAdmin_Click);
            // 
            // ModifyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(459, 363);
            this.Controls.Add(this.SaveInfoAdmin_btn);
            this.Controls.Add(this.PasswordConfirmAdmin_textbox);
            this.Controls.Add(this.NewPasswordAdmin_textbox);
            this.Controls.Add(this.OldPasswordAdmin_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyAdmin";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.OldPasswordAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.NewPasswordAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.PasswordConfirmAdmin_textbox, 0);
            this.Controls.SetChildIndex(this.SaveInfoAdmin_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPasswordAdmin_textbox;
        private System.Windows.Forms.TextBox NewPasswordAdmin_textbox;
        private System.Windows.Forms.TextBox PasswordConfirmAdmin_textbox;
        private System.Windows.Forms.Button SaveInfoAdmin_btn;
    }
}
