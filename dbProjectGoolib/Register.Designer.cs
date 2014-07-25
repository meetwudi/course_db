namespace dbProjectGoolib
{
    partial class Register
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
            this.userIdText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordConfirmText = new System.Windows.Forms.TextBox();
            this.realNameText = new System.Windows.Forms.TextBox();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(196, 37);
            this.userIdText.Name = "userIdText";
            this.userIdText.Size = new System.Drawing.Size(100, 21);
            this.userIdText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(196, 73);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 21);
            this.passwordText.TabIndex = 6;
            // 
            // passwordConfirmText
            // 
            this.passwordConfirmText.Location = new System.Drawing.Point(196, 114);
            this.passwordConfirmText.Name = "passwordConfirmText";
            this.passwordConfirmText.PasswordChar = '*';
            this.passwordConfirmText.Size = new System.Drawing.Size(100, 21);
            this.passwordConfirmText.TabIndex = 7;
            // 
            // realNameText
            // 
            this.realNameText.Location = new System.Drawing.Point(196, 156);
            this.realNameText.Name = "realNameText";
            this.realNameText.Size = new System.Drawing.Size(100, 21);
            this.realNameText.TabIndex = 8;
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(196, 199);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(100, 21);
            this.phoneNumberText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "确认密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "真名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "电话";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(151, 283);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(196, 241);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 21);
            this.emailText.TabIndex = 17;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumberText);
            this.Controls.Add(this.realNameText);
            this.Controls.Add(this.passwordConfirmText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userIdText);
            this.Name = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.Controls.SetChildIndex(this.userIdText, 0);
            this.Controls.SetChildIndex(this.passwordText, 0);
            this.Controls.SetChildIndex(this.passwordConfirmText, 0);
            this.Controls.SetChildIndex(this.realNameText, 0);
            this.Controls.SetChildIndex(this.phoneNumberText, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.submit, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.emailText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox passwordConfirmText;
        private System.Windows.Forms.TextBox realNameText;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailText;
    }
}
