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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutUser = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentBorrowUser = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowHistoryUser = new System.Windows.Forms.ToolStripMenuItem();
            this.RecommendUser = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexUser = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexHistoryUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MyRecommendUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyUser,
            this.LogoutUser});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
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
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // ModifyUser
            // 
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Size = new System.Drawing.Size(152, 22);
            this.ModifyUser.Text = "修改个人信息";
            // 
            // LogoutUser
            // 
            this.LogoutUser.Name = "LogoutUser";
            this.LogoutUser.Size = new System.Drawing.Size(152, 22);
            this.LogoutUser.Text = "登出";
            // 
            // CurrentBorrowUser
            // 
            this.CurrentBorrowUser.Name = "CurrentBorrowUser";
            this.CurrentBorrowUser.Size = new System.Drawing.Size(152, 22);
            this.CurrentBorrowUser.Text = "当前借阅";
            // 
            // BorrowHistoryUser
            // 
            this.BorrowHistoryUser.Name = "BorrowHistoryUser";
            this.BorrowHistoryUser.Size = new System.Drawing.Size(152, 22);
            this.BorrowHistoryUser.Text = "借阅历史";
            // 
            // RecommendUser
            // 
            this.RecommendUser.Name = "RecommendUser";
            this.RecommendUser.Size = new System.Drawing.Size(152, 22);
            this.RecommendUser.Text = "推荐购买";
            // 
            // IndexUser
            // 
            this.IndexUser.Name = "IndexUser";
            this.IndexUser.Size = new System.Drawing.Size(152, 22);
            this.IndexUser.Text = "书籍索引";
            // 
            // IndexHistoryUser
            // 
            this.IndexHistoryUser.Name = "IndexHistoryUser";
            this.IndexHistoryUser.Size = new System.Drawing.Size(152, 22);
            this.IndexHistoryUser.Text = "检索历史";
            // 
            // MyRecommendUser
            // 
            this.MyRecommendUser.Name = "MyRecommendUser";
            this.MyRecommendUser.Size = new System.Drawing.Size(152, 22);
            this.MyRecommendUser.Text = "我的荐购";
            // 
            // UserBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserBasic";
            this.Text = "Library Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}