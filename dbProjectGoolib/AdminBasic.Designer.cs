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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBasic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.BookIndexAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.RecommendationAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBookAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowReturnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserAdmin,
            this.OperationAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
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
            this.ModifyAdmin.Size = new System.Drawing.Size(146, 22);
            this.ModifyAdmin.Text = "修改个人信息";
            this.ModifyAdmin.Click += new System.EventHandler(this.ModifyAdmin_Click);
            // 
            // LogoutAdmin
            // 
            this.LogoutAdmin.Name = "LogoutAdmin";
            this.LogoutAdmin.Size = new System.Drawing.Size(146, 22);
            this.LogoutAdmin.Text = "登出";
            this.LogoutAdmin.Click += new System.EventHandler(this.LogoutAdmin_Click);
            // 
            // OperationAdmin
            // 
            this.OperationAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookIndexAdmin,
            this.RecommendationAdmin,
            this.AddBookAdmin,
            this.ManageUserAdmin,
            this.BorrowReturnAdmin,
            this.viewLogToolStripMenuItem});
            this.OperationAdmin.Name = "OperationAdmin";
            this.OperationAdmin.Size = new System.Drawing.Size(43, 20);
            this.OperationAdmin.Text = "操作";
            // 
            // BookIndexAdmin
            // 
            this.BookIndexAdmin.Name = "BookIndexAdmin";
            this.BookIndexAdmin.Size = new System.Drawing.Size(152, 22);
            this.BookIndexAdmin.Text = "管理书籍";
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
            // ManageUserAdmin
            // 
            this.ManageUserAdmin.Name = "ManageUserAdmin";
            this.ManageUserAdmin.Size = new System.Drawing.Size(152, 22);
            this.ManageUserAdmin.Text = "管理用户";
            this.ManageUserAdmin.Click += new System.EventHandler(this.ManageUser_Click);
            // 
            // BorrowReturnAdmin
            // 
            this.BorrowReturnAdmin.Name = "BorrowReturnAdmin";
            this.BorrowReturnAdmin.Size = new System.Drawing.Size(152, 22);
            this.BorrowReturnAdmin.Text = "借书/还书";
            this.BorrowReturnAdmin.Click += new System.EventHandler(this.BorrowReturnAdmin_Click);
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewLogToolStripMenuItem.Text = "查看日志";
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AdminBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 411);
            this.Name = "AdminBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem UserAdmin;
        private System.Windows.Forms.ToolStripMenuItem OperationAdmin;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.ToolStripMenuItem BookIndexAdmin;
        protected System.Windows.Forms.ToolStripMenuItem RecommendationAdmin;
        protected System.Windows.Forms.ToolStripMenuItem AddBookAdmin;
        protected System.Windows.Forms.ToolStripMenuItem ManageUserAdmin;
        protected System.Windows.Forms.ToolStripMenuItem BorrowReturnAdmin;
        protected System.Windows.Forms.ToolStripMenuItem ModifyAdmin;
        protected System.Windows.Forms.ToolStripMenuItem LogoutAdmin;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
    }
}