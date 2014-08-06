namespace dbProjectGoolib
{
    partial class ModifyUser
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
            this.OldPasswordUser_textbox = new System.Windows.Forms.TextBox();
            this.NewPasswordUser_textbox = new System.Windows.Forms.TextBox();
            this.PasswordConfirmUser_textbox = new System.Windows.Forms.TextBox();
            this.RealNameUser_textbox = new System.Windows.Forms.TextBox();
            this.PhoneNumberUser_textbox = new System.Windows.Forms.TextBox();
            this.EmailUser_textbox = new System.Windows.Forms.TextBox();
            this.SaveInfoUser_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // OldPasswordUser_textbox
            // 
            this.OldPasswordUser_textbox.Location = new System.Drawing.Point(223, 44);
            this.OldPasswordUser_textbox.Name = "OldPasswordUser_textbox";
            this.OldPasswordUser_textbox.PasswordChar = '*';
            this.OldPasswordUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.OldPasswordUser_textbox.TabIndex = 7;
            // 
            // NewPasswordUser_textbox
            // 
            this.NewPasswordUser_textbox.Location = new System.Drawing.Point(223, 84);
            this.NewPasswordUser_textbox.Name = "NewPasswordUser_textbox";
            this.NewPasswordUser_textbox.PasswordChar = '*';
            this.NewPasswordUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.NewPasswordUser_textbox.TabIndex = 8;
            // 
            // PasswordConfirmUser_textbox
            // 
            this.PasswordConfirmUser_textbox.Location = new System.Drawing.Point(223, 121);
            this.PasswordConfirmUser_textbox.Name = "PasswordConfirmUser_textbox";
            this.PasswordConfirmUser_textbox.PasswordChar = '*';
            this.PasswordConfirmUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.PasswordConfirmUser_textbox.TabIndex = 9;
            // 
            // RealNameUser_textbox
            // 
            this.RealNameUser_textbox.Location = new System.Drawing.Point(223, 158);
            this.RealNameUser_textbox.Name = "RealNameUser_textbox";
            this.RealNameUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.RealNameUser_textbox.TabIndex = 10;
            // 
            // PhoneNumberUser_textbox
            // 
            this.PhoneNumberUser_textbox.Location = new System.Drawing.Point(223, 195);
            this.PhoneNumberUser_textbox.Name = "PhoneNumberUser_textbox";
            this.PhoneNumberUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.PhoneNumberUser_textbox.TabIndex = 11;
            // 
            // EmailUser_textbox
            // 
            this.EmailUser_textbox.Location = new System.Drawing.Point(223, 232);
            this.EmailUser_textbox.Name = "EmailUser_textbox";
            this.EmailUser_textbox.Size = new System.Drawing.Size(100, 21);
            this.EmailUser_textbox.TabIndex = 12;
            // 
            // SaveInfoUser_btn
            // 
            this.SaveInfoUser_btn.Location = new System.Drawing.Point(175, 293);
            this.SaveInfoUser_btn.Name = "SaveInfoUser_btn";
            this.SaveInfoUser_btn.Size = new System.Drawing.Size(75, 23);
            this.SaveInfoUser_btn.TabIndex = 13;
            this.SaveInfoUser_btn.Text = "保存";
            this.SaveInfoUser_btn.UseVisualStyleBackColor = true;
            this.SaveInfoUser_btn.Click += new System.EventHandler(this.SaveInfoUser_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.SaveInfoUser_btn);
            this.Controls.Add(this.EmailUser_textbox);
            this.Controls.Add(this.PhoneNumberUser_textbox);
            this.Controls.Add(this.RealNameUser_textbox);
            this.Controls.Add(this.PasswordConfirmUser_textbox);
            this.Controls.Add(this.NewPasswordUser_textbox);
            this.Controls.Add(this.OldPasswordUser_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyUser";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.OldPasswordUser_textbox, 0);
            this.Controls.SetChildIndex(this.NewPasswordUser_textbox, 0);
            this.Controls.SetChildIndex(this.PasswordConfirmUser_textbox, 0);
            this.Controls.SetChildIndex(this.RealNameUser_textbox, 0);
            this.Controls.SetChildIndex(this.PhoneNumberUser_textbox, 0);
            this.Controls.SetChildIndex(this.EmailUser_textbox, 0);
            this.Controls.SetChildIndex(this.SaveInfoUser_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox OldPasswordUser_textbox;
        private System.Windows.Forms.TextBox NewPasswordUser_textbox;
        private System.Windows.Forms.TextBox PasswordConfirmUser_textbox;
        private System.Windows.Forms.TextBox RealNameUser_textbox;
        private System.Windows.Forms.TextBox PhoneNumberUser_textbox;
        private System.Windows.Forms.TextBox EmailUser_textbox;
        private System.Windows.Forms.Button SaveInfoUser_btn;
    }
}
