namespace OrderForm
{
    partial class SearchIDForm
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
            this.SearchIDtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchIDbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchIDtbx
            // 
            this.SearchIDtbx.Location = new System.Drawing.Point(398, 158);
            this.SearchIDtbx.Name = "SearchIDtbx";
            this.SearchIDtbx.Size = new System.Drawing.Size(100, 25);
            this.SearchIDtbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入订单ID";
            // 
            // searchIDbtn
            // 
            this.searchIDbtn.Location = new System.Drawing.Point(344, 227);
            this.searchIDbtn.Name = "searchIDbtn";
            this.searchIDbtn.Size = new System.Drawing.Size(75, 32);
            this.searchIDbtn.TabIndex = 3;
            this.searchIDbtn.Text = "搜索";
            this.searchIDbtn.UseVisualStyleBackColor = true;
            this.searchIDbtn.Click += new System.EventHandler(this.searchIDbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 4;
            // 
            // SearchIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchIDbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchIDtbx);
            this.Name = "SearchIDForm";
            this.Text = "SearchIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchIDtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchIDbtn;
        private System.Windows.Forms.Label label1;
    }
}