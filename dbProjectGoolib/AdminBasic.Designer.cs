namespace dbProjectGoolib
{
    partial class AdminBasic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.BookIndexAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.RecommendationAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBookAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBookAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserAdmin,
            this.OperationAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserAdmin
            // 
            this.UserAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyAdmin,
            this.LogoutAdmin});
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.Size = new System.Drawing.Size(43, 20);
            this.UserAdmin.Text = "用户";
            // 
            // ModifyAdmin
            // 
            this.ModifyAdmin.Name = "ModifyAdmin";
            this.ModifyAdmin.Size = new System.Drawing.Size(152, 22);
            this.ModifyAdmin.Text = "修改个人信息";
            this.ModifyAdmin.Click += new System.EventHandler(this.ModifyAdmin_Click);
            // 
            // LogoutAdmin
            // 
            this.LogoutAdmin.Name = "LogoutAdmin";
            this.LogoutAdmin.Size = new System.Drawing.Size(152, 22);
            this.LogoutAdmin.Text = "登出";
            this.LogoutAdmin.Click += new System.EventHandler(this.LogoutAdmin_Click);
            // 
            // OperationAdmin
            // 
            this.OperationAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookIndexAdmin,
            this.RecommendationAdmin,
            this.AddBookAdmin,
            this.ManageBookAdmin,
            this.ManageUser});
            this.OperationAdmin.Name = "OperationAdmin";
            this.OperationAdmin.Size = new System.Drawing.Size(43, 20);
            this.OperationAdmin.Text = "操作";
            // 
            // BookIndexAdmin
            // 
            this.BookIndexAdmin.Name = "BookIndexAdmin";
            this.BookIndexAdmin.Size = new System.Drawing.Size(152, 22);
            this.BookIndexAdmin.Text = "书籍索引";
            this.BookIndexAdmin.Click += new System.EventHandler(this.BookIndexAdmin_Click);
            // 
            // RecommendationAdmin
            // 
            this.RecommendationAdmin.Name = "RecommendationAdmin";
            this.RecommendationAdmin.Size = new System.Drawing.Size(152, 22);
            this.RecommendationAdmin.Text = "查看购荐";
            this.RecommendationAdmin.Click += new System.EventHandler(this.RecommendationAdmin_Click);
            // 
            // AddBookAdmin
            // 
            this.AddBookAdmin.Name = "AddBookAdmin";
            this.AddBookAdmin.Size = new System.Drawing.Size(152, 22);
            this.AddBookAdmin.Text = "录入书籍";
            this.AddBookAdmin.Click += new System.EventHandler(this.AddBookAdmin_Click);
            // 
            // ManageBookAdmin
            // 
            this.ManageBookAdmin.Name = "ManageBookAdmin";
            this.ManageBookAdmin.Size = new System.Drawing.Size(152, 22);
            this.ManageBookAdmin.Text = "管理书籍";
            this.ManageBookAdmin.Click += new System.EventHandler(this.ManageBookAdmin_Click);
            // 
            // ManageUser
            // 
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Size = new System.Drawing.Size(152, 22);
            this.ManageUser.Text = "用户管理";
            this.ManageUser.Click += new System.EventHandler(this.ManageUser_Click);
            // 
            // AdminBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminBasic";
            this.Text = "AdminBasic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserAdmin;
        private System.Windows.Forms.ToolStripMenuItem ModifyAdmin;
        private System.Windows.Forms.ToolStripMenuItem LogoutAdmin;
        private System.Windows.Forms.ToolStripMenuItem OperationAdmin;
        private System.Windows.Forms.ToolStripMenuItem BookIndexAdmin;
        private System.Windows.Forms.ToolStripMenuItem RecommendationAdmin;
        private System.Windows.Forms.ToolStripMenuItem AddBookAdmin;
        private System.Windows.Forms.ToolStripMenuItem ManageBookAdmin;
        private System.Windows.Forms.ToolStripMenuItem ManageUser;
    }
}