namespace dbProjectGoolib
{
    partial class Login
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
            this.userName = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userIdText = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(89, 71);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(41, 12);
            this.userName.TabIndex = 5;
            this.userName.Text = "用户名";
            // 
            // passWord
            // 
            this.passWord.AutoSize = true;
            this.passWord.Location = new System.Drawing.Point(94, 127);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(29, 12);
            this.passWord.TabIndex = 6;
            this.passWord.Text = "密码";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(183, 124);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 21);
            this.passwordText.TabIndex = 8;
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(183, 68);
            this.userIdText.Name = "userIdText";
            this.userIdText.Size = new System.Drawing.Size(100, 21);
            this.userIdText.TabIndex = 9;
            this.userIdText.TextChanged += new System.EventHandler(this.userIdText_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(148, 188);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "登陆";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.userName, 0);
            this.Controls.SetChildIndex(this.passWord, 0);
            this.Controls.SetChildIndex(this.passwordText, 0);
            this.Controls.SetChildIndex(this.userIdText, 0);
            this.Controls.SetChildIndex(this.submit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.Button submit;
    }
}
