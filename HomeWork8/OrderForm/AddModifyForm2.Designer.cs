namespace OrderForm
{
    partial class AddModifyForm2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtbx = new System.Windows.Forms.TextBox();
            this.Custbx = new System.Windows.Forms.TextBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.itemsGridview = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddModifySource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddModifySource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "orderItems";
            // 
            // IDtbx
            // 
            this.IDtbx.Location = new System.Drawing.Point(3, 50);
            this.IDtbx.Name = "IDtbx";
            this.IDtbx.Size = new System.Drawing.Size(100, 25);
            this.IDtbx.TabIndex = 5;
            this.IDtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Custbx
            // 
            this.Custbx.Location = new System.Drawing.Point(3, 110);
            this.Custbx.Name = "Custbx";
            this.Custbx.Size = new System.Drawing.Size(100, 25);
            this.Custbx.TabIndex = 6;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(439, 31);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 31);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "退出";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // itemsGridview
            // 
            this.itemsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemsGridview.Location = new System.Drawing.Point(0, 187);
            this.itemsGridview.Name = "itemsGridview";
            this.itemsGridview.RowTemplate.Height = 27;
            this.itemsGridview.Size = new System.Drawing.Size(475, 168);
            this.itemsGridview.TabIndex = 11;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(183, 31);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 31);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "添加";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Modifybtn
            // 
            this.Modifybtn.Location = new System.Drawing.Point(310, 31);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(75, 31);
            this.Modifybtn.TabIndex = 13;
            this.Modifybtn.Text = "修改";
            this.Modifybtn.UseVisualStyleBackColor = true;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 384);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IDtbx);
            this.panel2.Controls.Add(this.Custbx);
            this.panel2.Controls.Add(this.itemsGridview);
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 355);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Modifybtn);
            this.panel3.Controls.Add(this.Addbtn);
            this.panel3.Controls.Add(this.Exitbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 78);
            this.panel3.TabIndex = 16;
            // 
            // AddModifyForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "AddModifyForm2";
            this.Text = "AddModifyForm2";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddModifySource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtbx;
        private System.Windows.Forms.TextBox Custbx;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.DataGridView itemsGridview;
        private System.Windows.Forms.BindingSource AddModifySource1;
        public System.Windows.Forms.Button Addbtn;
        public System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}