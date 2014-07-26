namespace dbProjectGoolib
{
    partial class Initial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.submitLg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.passwordTextLg = new System.Windows.Forms.TextBox();
            this.usernameTextLg = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.TabPage();
            this.submitRg = new System.Windows.Forms.Button();
            this.emailRg = new System.Windows.Forms.TextBox();
            this.phoneNumberRg = new System.Windows.Forms.TextBox();
            this.realNameTextRg = new System.Windows.Forms.TextBox();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.passwordTextRg = new System.Windows.Forms.TextBox();
            this.usernameTextRg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identity = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.register);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // login
            // 
            this.login.Controls.Add(this.identity);
            this.login.Controls.Add(this.submitLg);
            this.login.Controls.Add(this.label2);
            this.login.Controls.Add(this.username);
            this.login.Controls.Add(this.passwordTextLg);
            this.login.Controls.Add(this.usernameTextLg);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(454, 337);
            this.login.TabIndex = 0;
            this.login.Text = "登陆";
            this.login.UseVisualStyleBackColor = true;
            // 
            // submitLg
            // 
            this.submitLg.Location = new System.Drawing.Point(187, 250);
            this.submitLg.Name = "submitLg";
            this.submitLg.Size = new System.Drawing.Size(75, 23);
            this.submitLg.TabIndex = 5;
            this.submitLg.Text = "登陆";
            this.submitLg.UseVisualStyleBackColor = true;
            this.submitLg.Click += new System.EventHandler(this.submitLg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(130, 83);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(41, 12);
            this.username.TabIndex = 2;
            this.username.Text = "用户名";
            // 
            // passwordTextLg
            // 
            this.passwordTextLg.Location = new System.Drawing.Point(203, 144);
            this.passwordTextLg.Name = "passwordTextLg";
            this.passwordTextLg.Size = new System.Drawing.Size(100, 21);
            this.passwordTextLg.TabIndex = 1;
            // 
            // usernameTextLg
            // 
            this.usernameTextLg.Location = new System.Drawing.Point(203, 80);
            this.usernameTextLg.Name = "usernameTextLg";
            this.usernameTextLg.Size = new System.Drawing.Size(100, 21);
            this.usernameTextLg.TabIndex = 0;
            // 
            // register
            // 
            this.register.Controls.Add(this.submitRg);
            this.register.Controls.Add(this.emailRg);
            this.register.Controls.Add(this.phoneNumberRg);
            this.register.Controls.Add(this.realNameTextRg);
            this.register.Controls.Add(this.passwordConfirm);
            this.register.Controls.Add(this.passwordTextRg);
            this.register.Controls.Add(this.usernameTextRg);
            this.register.Controls.Add(this.label7);
            this.register.Controls.Add(this.label6);
            this.register.Controls.Add(this.label5);
            this.register.Controls.Add(this.label4);
            this.register.Controls.Add(this.label3);
            this.register.Controls.Add(this.label1);
            this.register.Location = new System.Drawing.Point(4, 22);
            this.register.Name = "register";
            this.register.Padding = new System.Windows.Forms.Padding(3);
            this.register.Size = new System.Drawing.Size(454, 335);
            this.register.TabIndex = 1;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            // 
            // submitRg
            // 
            this.submitRg.Location = new System.Drawing.Point(157, 256);
            this.submitRg.Name = "submitRg";
            this.submitRg.Size = new System.Drawing.Size(75, 23);
            this.submitRg.TabIndex = 12;
            this.submitRg.Text = "提交";
            this.submitRg.UseVisualStyleBackColor = true;
            this.submitRg.Click += new System.EventHandler(this.submitRg_Click);
            // 
            // emailRg
            // 
            this.emailRg.Location = new System.Drawing.Point(206, 205);
            this.emailRg.Name = "emailRg";
            this.emailRg.Size = new System.Drawing.Size(100, 21);
            this.emailRg.TabIndex = 11;
            // 
            // phoneNumberRg
            // 
            this.phoneNumberRg.Location = new System.Drawing.Point(206, 173);
            this.phoneNumberRg.Name = "phoneNumberRg";
            this.phoneNumberRg.Size = new System.Drawing.Size(100, 21);
            this.phoneNumberRg.TabIndex = 10;
            // 
            // realNameTextRg
            // 
            this.realNameTextRg.Location = new System.Drawing.Point(206, 140);
            this.realNameTextRg.Name = "realNameTextRg";
            this.realNameTextRg.Size = new System.Drawing.Size(100, 21);
            this.realNameTextRg.TabIndex = 9;
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(206, 107);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(100, 21);
            this.passwordConfirm.TabIndex = 8;
            // 
            // passwordTextRg
            // 
            this.passwordTextRg.Location = new System.Drawing.Point(206, 75);
            this.passwordTextRg.Name = "passwordTextRg";
            this.passwordTextRg.Size = new System.Drawing.Size(100, 21);
            this.passwordTextRg.TabIndex = 7;
            // 
            // usernameTextRg
            // 
            this.usernameTextRg.Location = new System.Drawing.Point(206, 43);
            this.usernameTextRg.Name = "usernameTextRg";
            this.usernameTextRg.Size = new System.Drawing.Size(100, 21);
            this.usernameTextRg.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "真实姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码确认";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // identity
            // 
            this.identity.AutoSize = true;
            this.identity.Location = new System.Drawing.Point(203, 202);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(60, 16);
            this.identity.TabIndex = 6;
            this.identity.Text = "管理员";
            this.identity.UseVisualStyleBackColor = true;
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.tabControl1);
            this.Name = "Initial";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Initial_Load);
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.register.ResumeLayout(false);
            this.register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox passwordTextLg;
        private System.Windows.Forms.TextBox usernameTextLg;
        private System.Windows.Forms.TabPage register;
        private System.Windows.Forms.Button submitLg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitRg;
        private System.Windows.Forms.TextBox emailRg;
        private System.Windows.Forms.TextBox phoneNumberRg;
        private System.Windows.Forms.TextBox realNameTextRg;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.TextBox passwordTextRg;
        private System.Windows.Forms.TextBox usernameTextRg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox identity;
    }
}