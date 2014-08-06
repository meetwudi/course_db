namespace dbProjectGoolib
{
    partial class UserBasic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBasic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutUser = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentBorrowUser = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowHistoryUser = new System.Windows.Forms.ToolStripMenuItem();
            this.RecommendUser = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexUser = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexHistoryUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MyRecommendUser = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyUser,
            this.LogoutUser});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // ModifyUser
            // 
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Size = new System.Drawing.Size(146, 22);
            this.ModifyUser.Text = "修改个人信息";
            this.ModifyUser.Click += new System.EventHandler(this.ModifyUser_Click);
            // 
            // LogoutUser
            // 
            this.LogoutUser.Name = "LogoutUser";
            this.LogoutUser.Size = new System.Drawing.Size(146, 22);
            this.LogoutUser.Text = "登出";
            this.LogoutUser.Click += new System.EventHandler(this.LogoutUser_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentBorrowUser,
            this.BorrowHistoryUser,
            this.RecommendUser,
            this.IndexUser,
            this.IndexHistoryUser,
            this.MyRecommendUser});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // CurrentBorrowUser
            // 
            this.CurrentBorrowUser.Name = "CurrentBorrowUser";
            this.CurrentBorrowUser.Size = new System.Drawing.Size(122, 22);
            this.CurrentBorrowUser.Text = "当前借阅";
            this.CurrentBorrowUser.Click += new System.EventHandler(this.CurrentBorrowUser_Click);
            // 
            // BorrowHistoryUser
            // 
            this.BorrowHistoryUser.Name = "BorrowHistoryUser";
            this.BorrowHistoryUser.Size = new System.Drawing.Size(122, 22);
            this.BorrowHistoryUser.Text = "借阅历史";
            this.BorrowHistoryUser.Click += new System.EventHandler(this.BorrowHistoryUser_Click);
            // 
            // RecommendUser
            // 
            this.RecommendUser.Name = "RecommendUser";
            this.RecommendUser.Size = new System.Drawing.Size(122, 22);
            this.RecommendUser.Text = "推荐购买";
            this.RecommendUser.Click += new System.EventHandler(this.RecommendUser_Click);
            // 
            // IndexUser
            // 
            this.IndexUser.Name = "IndexUser";
            this.IndexUser.Size = new System.Drawing.Size(122, 22);
            this.IndexUser.Text = "书籍索引";
            this.IndexUser.Click += new System.EventHandler(this.IndexUser_Click);
            // 
            // IndexHistoryUser
            // 
            this.IndexHistoryUser.Name = "IndexHistoryUser";
            this.IndexHistoryUser.Size = new System.Drawing.Size(122, 22);
            this.IndexHistoryUser.Text = "检索历史";
            this.IndexHistoryUser.Click += new System.EventHandler(this.IndexHistoryUser_Click);
            // 
            // MyRecommendUser
            // 
            this.MyRecommendUser.Name = "MyRecommendUser";
            this.MyRecommendUser.Size = new System.Drawing.Size(122, 22);
            this.MyRecommendUser.Text = "我的荐购";
            this.MyRecommendUser.Click += new System.EventHandler(this.MyRecommendUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 431);
            this.Name = "UserBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ModifyUser;
        protected System.Windows.Forms.ToolStripMenuItem LogoutUser;
        protected System.Windows.Forms.ToolStripMenuItem CurrentBorrowUser;
        protected System.Windows.Forms.ToolStripMenuItem BorrowHistoryUser;
        protected System.Windows.Forms.ToolStripMenuItem RecommendUser;
        protected System.Windows.Forms.ToolStripMenuItem IndexUser;
        protected System.Windows.Forms.ToolStripMenuItem IndexHistoryUser;
        protected System.Windows.Forms.ToolStripMenuItem MyRecommendUser;
        protected System.Windows.Forms.PictureBox pictureBox1;
    }
}