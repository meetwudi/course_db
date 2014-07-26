namespace dbProjectGoolib
{
    partial class ManageUserForm
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
            this.userID_label = new System.Windows.Forms.Label();
            this.userID_textbox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SetAsAdmin_btn = new System.Windows.Forms.Button();
            this.DeleteUser_btn = new System.Windows.Forms.Button();
            this.ResetPSW_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userID_label
            // 
            this.userID_label.AutoSize = true;
            this.userID_label.Location = new System.Drawing.Point(42, 53);
            this.userID_label.Name = "userID_label";
            this.userID_label.Size = new System.Drawing.Size(45, 13);
            this.userID_label.TabIndex = 1;
            this.userID_label.Text = "用户 ID";
            // 
            // userID_textbox
            // 
            this.userID_textbox.Location = new System.Drawing.Point(109, 50);
            this.userID_textbox.Name = "userID_textbox";
            this.userID_textbox.Size = new System.Drawing.Size(157, 20);
            this.userID_textbox.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(306, 47);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(46, 25);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "搜索";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 129);
            this.dataGridView1.TabIndex = 4;
            // 
            // SetAsAdmin_btn
            // 
            this.SetAsAdmin_btn.Location = new System.Drawing.Point(42, 268);
            this.SetAsAdmin_btn.Name = "SetAsAdmin_btn";
            this.SetAsAdmin_btn.Size = new System.Drawing.Size(82, 25);
            this.SetAsAdmin_btn.TabIndex = 5;
            this.SetAsAdmin_btn.Text = "设为管理员";
            this.SetAsAdmin_btn.UseVisualStyleBackColor = true;
            this.SetAsAdmin_btn.Click += new System.EventHandler(this.SetAsAdmin_btn_Click);
            // 
            // DeleteUser_btn
            // 
            this.DeleteUser_btn.Location = new System.Drawing.Point(156, 268);
            this.DeleteUser_btn.Name = "DeleteUser_btn";
            this.DeleteUser_btn.Size = new System.Drawing.Size(71, 25);
            this.DeleteUser_btn.TabIndex = 6;
            this.DeleteUser_btn.Text = "删除用户";
            this.DeleteUser_btn.UseVisualStyleBackColor = true;
            this.DeleteUser_btn.Click += new System.EventHandler(this.DeleteUser_btn_Click);
            // 
            // ResetPSW_btn
            // 
            this.ResetPSW_btn.Location = new System.Drawing.Point(258, 268);
            this.ResetPSW_btn.Name = "ResetPSW_btn";
            this.ResetPSW_btn.Size = new System.Drawing.Size(71, 25);
            this.ResetPSW_btn.TabIndex = 7;
            this.ResetPSW_btn.Text = "重置密码";
            this.ResetPSW_btn.UseVisualStyleBackColor = true;
            this.ResetPSW_btn.Click += new System.EventHandler(this.ResetPSW_btn_Click);
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 362);
            this.Controls.Add(this.ResetPSW_btn);
            this.Controls.Add(this.DeleteUser_btn);
            this.Controls.Add(this.SetAsAdmin_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.userID_textbox);
            this.Controls.Add(this.userID_label);
            this.Name = "ManageUserForm";
            this.Controls.SetChildIndex(this.userID_label, 0);
            this.Controls.SetChildIndex(this.userID_textbox, 0);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.SetAsAdmin_btn, 0);
            this.Controls.SetChildIndex(this.DeleteUser_btn, 0);
            this.Controls.SetChildIndex(this.ResetPSW_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID_label;
        private System.Windows.Forms.TextBox userID_textbox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SetAsAdmin_btn;
        private System.Windows.Forms.Button DeleteUser_btn;
        private System.Windows.Forms.Button ResetPSW_btn;
    }
}
