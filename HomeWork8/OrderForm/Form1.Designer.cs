namespace OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.ordersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsdataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.MODIFYbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Importbtn = new System.Windows.Forms.Button();
            this.Exportbtn = new System.Windows.Forms.Button();
            this.SearchModecbx = new System.Windows.Forms.ComboBox();
            this.SearchModetbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchlabel2 = new System.Windows.Forms.Label();
            this.Allordersbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ordersdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersdataGridView1
            // 
            this.ordersdataGridView1.AutoGenerateColumns = false;
            this.ordersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.totalPrizeDataGridViewTextBoxColumn});
            this.ordersdataGridView1.DataSource = this.orderSource;
            this.ordersdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.ordersdataGridView1.Name = "ordersdataGridView1";
            this.ordersdataGridView1.RowTemplate.Height = 27;
            this.ordersdataGridView1.Size = new System.Drawing.Size(476, 203);
            this.ordersdataGridView1.TabIndex = 0;
            this.ordersdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // totalPrizeDataGridViewTextBoxColumn
            // 
            this.totalPrizeDataGridViewTextBoxColumn.DataPropertyName = "TotalPrize";
            this.totalPrizeDataGridViewTextBoxColumn.HeaderText = "TotalPrize";
            this.totalPrizeDataGridViewTextBoxColumn.Name = "totalPrizeDataGridViewTextBoxColumn";
            this.totalPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderSource
            // 
            this.orderSource.DataMember = "list";
            this.orderSource.DataSource = typeof(HomeWork8.OrderService);
            // 
            // detailsdataGridView2
            // 
            this.detailsdataGridView2.AutoGenerateColumns = false;
            this.detailsdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsdataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.prizeDataGridViewTextBoxColumn});
            this.detailsdataGridView2.DataMember = "OrderItems";
            this.detailsdataGridView2.DataSource = this.orderSource;
            this.detailsdataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsdataGridView2.Location = new System.Drawing.Point(0, 0);
            this.detailsdataGridView2.Name = "detailsdataGridView2";
            this.detailsdataGridView2.RowTemplate.Height = 27;
            this.detailsdataGridView2.Size = new System.Drawing.Size(520, 203);
            this.detailsdataGridView2.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // prizeDataGridViewTextBoxColumn
            // 
            this.prizeDataGridViewTextBoxColumn.DataPropertyName = "Prize";
            this.prizeDataGridViewTextBoxColumn.HeaderText = "Prize";
            this.prizeDataGridViewTextBoxColumn.Name = "prizeDataGridViewTextBoxColumn";
            // 
            // ADDbtn
            // 
            this.ADDbtn.Location = new System.Drawing.Point(12, 33);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(75, 31);
            this.ADDbtn.TabIndex = 2;
            this.ADDbtn.Text = "添加";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(343, 33);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 31);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "删除";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // MODIFYbtn
            // 
            this.MODIFYbtn.Location = new System.Drawing.Point(189, 33);
            this.MODIFYbtn.Name = "MODIFYbtn";
            this.MODIFYbtn.Size = new System.Drawing.Size(75, 31);
            this.MODIFYbtn.TabIndex = 4;
            this.MODIFYbtn.Text = "修改";
            this.MODIFYbtn.UseVisualStyleBackColor = true;
            this.MODIFYbtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(600, 23);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 26);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "查询";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(576, 33);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(75, 31);
            this.Importbtn.TabIndex = 6;
            this.Importbtn.Text = "导入";
            this.Importbtn.UseVisualStyleBackColor = true;
            this.Importbtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // Exportbtn
            // 
            this.Exportbtn.Location = new System.Drawing.Point(735, 33);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(75, 31);
            this.Exportbtn.TabIndex = 7;
            this.Exportbtn.Text = "导出";
            this.Exportbtn.UseVisualStyleBackColor = true;
            this.Exportbtn.Click += new System.EventHandler(this.Exportbtn_Click);
            // 
            // SearchModecbx
            // 
            this.SearchModecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchModecbx.FormattingEnabled = true;
            this.SearchModecbx.Items.AddRange(new object[] {
            "ID",
            "Customer",
            "ItemName"});
            this.SearchModecbx.Location = new System.Drawing.Point(353, 24);
            this.SearchModecbx.Name = "SearchModecbx";
            this.SearchModecbx.Size = new System.Drawing.Size(121, 23);
            this.SearchModecbx.TabIndex = 8;
            // 
            // SearchModetbx
            // 
            this.SearchModetbx.Location = new System.Drawing.Point(480, 24);
            this.SearchModetbx.Name = "SearchModetbx";
            this.SearchModetbx.Size = new System.Drawing.Size(100, 25);
            this.SearchModetbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "查询方式";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Searchlabel2
            // 
            this.Searchlabel2.AutoSize = true;
            this.Searchlabel2.Location = new System.Drawing.Point(453, 62);
            this.Searchlabel2.Name = "Searchlabel2";
            this.Searchlabel2.Size = new System.Drawing.Size(0, 15);
            this.Searchlabel2.TabIndex = 11;
            // 
            // Allordersbtn
            // 
            this.Allordersbtn.Location = new System.Drawing.Point(428, 80);
            this.Allordersbtn.Name = "Allordersbtn";
            this.Allordersbtn.Size = new System.Drawing.Size(95, 26);
            this.Allordersbtn.TabIndex = 12;
            this.Allordersbtn.Text = "所有订单";
            this.Allordersbtn.UseVisualStyleBackColor = true;
            this.Allordersbtn.Click += new System.EventHandler(this.Allordersbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Allordersbtn);
            this.panel1.Controls.Add(this.Searchlabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchModecbx);
            this.panel1.Controls.Add(this.SearchModetbx);
            this.panel1.Controls.Add(this.Searchbtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 109);
            this.panel1.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 136);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ordersdataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailsdataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 203);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ADDbtn);
            this.panel2.Controls.Add(this.MODIFYbtn);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Exportbtn);
            this.panel2.Controls.Add(this.Importbtn);
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 100);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ordersdataGridView1;
        private System.Windows.Forms.BindingSource orderSource;
        private System.Windows.Forms.DataGridView detailsdataGridView2;
        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button MODIFYbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.Button Exportbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox SearchModecbx;
        private System.Windows.Forms.TextBox SearchModetbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Searchlabel2;
        private System.Windows.Forms.Button Allordersbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
    }
}

