namespace windowsform
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
            this.hellobutton = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.opearte = new System.Windows.Forms.Button();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hellobutton
            // 
            this.hellobutton.Location = new System.Drawing.Point(207, 68);
            this.hellobutton.Name = "hellobutton";
            this.hellobutton.Size = new System.Drawing.Size(92, 23);
            this.hellobutton.TabIndex = 0;
            this.hellobutton.Text = "say hello";
            this.hellobutton.UseVisualStyleBackColor = true;
            this.hellobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // add1
            // 
            this.add1.AutoSize = true;
            this.add1.Location = new System.Drawing.Point(425, 72);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(95, 15);
            this.add1.TabIndex = 1;
            this.add1.Text = "greetbutton";
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 4;
            // 
            // opearte
            // 
            this.opearte.Location = new System.Drawing.Point(207, 253);
            this.opearte.Name = "opearte";
            this.opearte.Size = new System.Drawing.Size(75, 23);
            this.opearte.TabIndex = 6;
            this.opearte.Text = "operate";
            this.opearte.UseVisualStyleBackColor = true;
            this.opearte.Click += new System.EventHandler(this.button2_Click);
            // 
            // functionBox
            // 
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "add",
            "sub",
            "mul",
            "div"});
            this.functionBox.Location = new System.Drawing.Point(161, 191);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(121, 23);
            this.functionBox.TabIndex = 7;
            this.functionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(455, 199);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(55, 15);
            this.result.TabIndex = 5;
            this.result.Text = "result";
            this.result.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.opearte);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.hellobutton);
            this.Name = "Form1";
            this.Text = "compute";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hellobutton;
        private System.Windows.Forms.Label add1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button opearte;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.Label result;
    }
}

