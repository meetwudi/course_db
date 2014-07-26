namespace dbProjectGoolib
{
    partial class Modify
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OldPasswordTextUser = new System.Windows.Forms.TextBox();
            this.NewPasswordTextUser = new System.Windows.Forms.TextBox();
            this.PasswordConfirmUser = new System.Windows.Forms.TextBox();
            this.RealNameUser = new System.Windows.Forms.TextBox();
            this.PhoneNumberUser = new System.Windows.Forms.TextBox();
            this.EmailUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "真实姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // OldPasswordTextUser
            // 
            this.OldPasswordTextUser.Location = new System.Drawing.Point(223, 44);
            this.OldPasswordTextUser.Name = "OldPasswordTextUser";
            this.OldPasswordTextUser.Size = new System.Drawing.Size(100, 21);
            this.OldPasswordTextUser.TabIndex = 7;
            // 
            // NewPasswordTextUser
            // 
            this.NewPasswordTextUser.Location = new System.Drawing.Point(223, 84);
            this.NewPasswordTextUser.Name = "NewPasswordTextUser";
            this.NewPasswordTextUser.Size = new System.Drawing.Size(100, 21);
            this.NewPasswordTextUser.TabIndex = 8;
            // 
            // PasswordConfirmUser
            // 
            this.PasswordConfirmUser.Location = new System.Drawing.Point(223, 121);
            this.PasswordConfirmUser.Name = "PasswordConfirmUser";
            this.PasswordConfirmUser.Size = new System.Drawing.Size(100, 21);
            this.PasswordConfirmUser.TabIndex = 9;
            // 
            // RealNameUser
            // 
            this.RealNameUser.Location = new System.Drawing.Point(223, 158);
            this.RealNameUser.Name = "RealNameUser";
            this.RealNameUser.Size = new System.Drawing.Size(100, 21);
            this.RealNameUser.TabIndex = 10;
            // 
            // PhoneNumberUser
            // 
            this.PhoneNumberUser.Location = new System.Drawing.Point(223, 195);
            this.PhoneNumberUser.Name = "PhoneNumberUser";
            this.PhoneNumberUser.Size = new System.Drawing.Size(100, 21);
            this.PhoneNumberUser.TabIndex = 11;
            // 
            // EmailUser
            // 
            this.EmailUser.Location = new System.Drawing.Point(223, 232);
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.Size = new System.Drawing.Size(100, 21);
            this.EmailUser.TabIndex = 12;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.EmailUser);
            this.Controls.Add(this.PhoneNumberUser);
            this.Controls.Add(this.RealNameUser);
            this.Controls.Add(this.PasswordConfirmUser);
            this.Controls.Add(this.NewPasswordTextUser);
            this.Controls.Add(this.OldPasswordTextUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modify";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.OldPasswordTextUser, 0);
            this.Controls.SetChildIndex(this.NewPasswordTextUser, 0);
            this.Controls.SetChildIndex(this.PasswordConfirmUser, 0);
            this.Controls.SetChildIndex(this.RealNameUser, 0);
            this.Controls.SetChildIndex(this.PhoneNumberUser, 0);
            this.Controls.SetChildIndex(this.EmailUser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OldPasswordTextUser;
        private System.Windows.Forms.TextBox NewPasswordTextUser;
        private System.Windows.Forms.TextBox PasswordConfirmUser;
        private System.Windows.Forms.TextBox RealNameUser;
        private System.Windows.Forms.TextBox PhoneNumberUser;
        private System.Windows.Forms.TextBox EmailUser;
    }
}
