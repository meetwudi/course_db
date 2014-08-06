namespace dbProjectGoolib
{
    partial class CreateRecommendUser
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
            this.BookNameUser_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorUser_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReasonUser_textbox = new System.Windows.Forms.TextBox();
            this.submitRecoUser_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "读者荐购";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-------------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "书名 ";
            // 
            // BookNameUser_textbox
            // 
            this.BookNameUser_textbox.Location = new System.Drawing.Point(174, 100);
            this.BookNameUser_textbox.Name = "BookNameUser_textbox";
            this.BookNameUser_textbox.Size = new System.Drawing.Size(181, 20);
            this.BookNameUser_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "作者";
            // 
            // AuthorUser_textbox
            // 
            this.AuthorUser_textbox.Location = new System.Drawing.Point(174, 155);
            this.AuthorUser_textbox.Name = "AuthorUser_textbox";
            this.AuthorUser_textbox.Size = new System.Drawing.Size(181, 20);
            this.AuthorUser_textbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "推荐理由";
            // 
            // ReasonUser_textbox
            // 
            this.ReasonUser_textbox.Location = new System.Drawing.Point(174, 216);
            this.ReasonUser_textbox.Multiline = true;
            this.ReasonUser_textbox.Name = "ReasonUser_textbox";
            this.ReasonUser_textbox.Size = new System.Drawing.Size(181, 104);
            this.ReasonUser_textbox.TabIndex = 8;
            // 
            // submitRecoUser_btn
            // 
            this.submitRecoUser_btn.Location = new System.Drawing.Point(174, 343);
            this.submitRecoUser_btn.Name = "submitRecoUser_btn";
            this.submitRecoUser_btn.Size = new System.Drawing.Size(75, 25);
            this.submitRecoUser_btn.TabIndex = 9;
            this.submitRecoUser_btn.Text = "提交";
            this.submitRecoUser_btn.UseVisualStyleBackColor = true;
            this.submitRecoUser_btn.Click += new System.EventHandler(this.submitRecoUser_btn_Click);
            // 
            // CreateRecommendUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 373);
            this.Controls.Add(this.submitRecoUser_btn);
            this.Controls.Add(this.ReasonUser_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AuthorUser_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BookNameUser_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximumSize = new System.Drawing.Size(500, 778);
            this.MinimumSize = new System.Drawing.Size(500, 411);
            this.Name = "CreateRecommendUser";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BookNameUser_textbox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.AuthorUser_textbox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ReasonUser_textbox, 0);
            this.Controls.SetChildIndex(this.submitRecoUser_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BookNameUser_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorUser_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReasonUser_textbox;
        private System.Windows.Forms.Button submitRecoUser_btn;
    }
}
