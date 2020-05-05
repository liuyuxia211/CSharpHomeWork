namespace ScrawlForm
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartUrltbx = new System.Windows.Forms.TextBox();
            this.Crawlbtn = new System.Windows.Forms.Button();
            this.Urls = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartUrltbx
            // 
            this.StartUrltbx.Location = new System.Drawing.Point(67, 45);
            this.StartUrltbx.Name = "StartUrltbx";
            this.StartUrltbx.Size = new System.Drawing.Size(417, 25);
            this.StartUrltbx.TabIndex = 0;
            // 
            // Crawlbtn
            // 
            this.Crawlbtn.Location = new System.Drawing.Point(565, 45);
            this.Crawlbtn.Name = "Crawlbtn";
            this.Crawlbtn.Size = new System.Drawing.Size(75, 23);
            this.Crawlbtn.TabIndex = 1;
            this.Crawlbtn.Text = "Crawl";
            this.Crawlbtn.UseVisualStyleBackColor = true;
            this.Crawlbtn.Click += new System.EventHandler(this.Crawlbtn_Click);
            // 
            // Urls
            // 
            this.Urls.Location = new System.Drawing.Point(67, 119);
            this.Urls.Multiline = true;
            this.Urls.Name = "Urls";
            this.Urls.Size = new System.Drawing.Size(496, 319);
            this.Urls.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Urls);
            this.Controls.Add(this.Crawlbtn);
            this.Controls.Add(this.StartUrltbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartUrltbx;
        private System.Windows.Forms.Button Crawlbtn;
        private System.Windows.Forms.TextBox Urls;
    }
}

