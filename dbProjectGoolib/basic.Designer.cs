namespace dbProjectGoolib
{
    partial class basic
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
        protected void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecommendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.RegisterToolStripMenuItem,
            this.ModifyToolStripMenuItem});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.UserToolStripMenuItem.Text = "用户";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.LoginToolStripMenuItem.Text = "登陆";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // RegisterToolStripMenuItem
            // 
            this.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem";
            this.RegisterToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.RegisterToolStripMenuItem.Text = "注册";
            this.RegisterToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ModifyToolStripMenuItem.Text = "修改信息";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentToolStripMenuItem,
            this.RecommendToolStripMenuItem,
            this.TypeinToolStripMenuItem,
            this.ManageBooksToolStripMenuItem,
            this.ManageUserToolStripMenuItem,
            this.IndexToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // CurrentToolStripMenuItem
            // 
            this.CurrentToolStripMenuItem.Name = "CurrentToolStripMenuItem";
            this.CurrentToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.CurrentToolStripMenuItem.Text = "当前借阅";
            // 
            // RecommendToolStripMenuItem
            // 
            this.RecommendToolStripMenuItem.Name = "RecommendToolStripMenuItem";
            this.RecommendToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.RecommendToolStripMenuItem.Text = "查看荐购";
            // 
            // TypeinToolStripMenuItem
            // 
            this.TypeinToolStripMenuItem.Name = "TypeinToolStripMenuItem";
            this.TypeinToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.TypeinToolStripMenuItem.Text = "录入图书";
            // 
            // ManageBooksToolStripMenuItem
            // 
            this.ManageBooksToolStripMenuItem.Name = "ManageBooksToolStripMenuItem";
            this.ManageBooksToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ManageBooksToolStripMenuItem.Text = "管理书籍";
            // 
            // ManageUserToolStripMenuItem
            // 
            this.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem";
            this.ManageUserToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ManageUserToolStripMenuItem.Text = "用户管理";
            // 
            // IndexToolStripMenuItem
            // 
            this.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem";
            this.IndexToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.IndexToolStripMenuItem.Text = "书籍索引";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 4;
            // 
            // basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "basic";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.basic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ToolStripMenuItem RegisterToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem CurrentToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem RecommendToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem TypeinToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ManageBooksToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem ManageUserToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem IndexToolStripMenuItem;
    }
}

