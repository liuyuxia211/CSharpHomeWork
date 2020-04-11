using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork8;
namespace OrderForm
{
    public partial class Form1 : Form
    {
        public OrderService service { get; set; }

        public Order ordertemp { get; set; }

        public string mode { get; set; }

        public int ID;
        public string CustomerItemID { get; set; }
        public Form1()
        {
            InitializeComponent();
            ordertemp = new Order();

            service = new OrderService();
            orderSource.DataSource = service.list;
            orderSource.ResetBindings(true);
            SearchModecbx.DataBindings.Add("Text", this, "mode");
            SearchModetbx.DataBindings.Add("Text", this, "CustomerItemID");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            SearchIDForm searchIDForm = new SearchIDForm();
            searchIDForm.serviceCopy3 = service;
            searchIDForm.ShowDialog();
            if (searchIDForm.order != null)
            {
                service.OrderDelete(searchIDForm.order.ID);
                orderSource.ResetBindings(true);
            }
        }
        public void ResetSource()
        {
            orderSource.ResetBindings(true);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {

            AddModifyForm2 form2 = new AddModifyForm2();
            form2.serviceCopy = service;
            form2.Addbindings(form2.ordertemp);
            form2.form1Copy = this;
            form2.Modifybtn.Visible = false;
            form2.ShowDialog();

        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            SearchIDForm searchIDForm = new SearchIDForm();
            searchIDForm.serviceCopy3 = service;
            searchIDForm.ShowDialog();

            if (searchIDForm.order != null)
            {
                AddModifyForm2 form2 = new AddModifyForm2();
                form2.serviceCopy = service;
                form2.Addbindings(searchIDForm.order);
                form2.Addbtn.Visible = false;
                form2.ShowDialog();
                orderSource.ResetBindings(true);
            }

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Searchlabel2.Text = "";

            switch (mode)
            {
                case "ID":
                    if (int.TryParse(CustomerItemID, out ID))
                    {
                        if (service.SerchOrderByID(ID) == null)
                        {
                            Searchlabel2.Text = "订单不存在";

                        }
                        else
                        {
                            orderSource.DataSource = service.SerchOrderByID(ID);
                            ResetSource();
                        }
                    }
                    else Searchlabel2.Text = "输入错误";
                    break;
                case "Customer":
                    if (service.SerchOrderByCustomer(CustomerItemID) == null)
                    {
                        Searchlabel2.Text = "订单不存在";
                    }
                    else
                    {
                        orderSource.DataSource = service.SerchOrderByCustomer(CustomerItemID);
                        ResetSource();
                    }
                    break;
                case "ItemName":
                    if (service.SerchOrderByItemName(CustomerItemID) == null)
                    {
                        Searchlabel2.Text = "订单不存在";

                    }
                    else
                    {
                        orderSource.DataSource = service.SerchOrderByItemName(CustomerItemID);
                        ResetSource();
                    }
                    break;

                default:
                    break;
            }
            // SearchcomboBox1.DataBindings("Text",)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Allordersbtn_Click(object sender, EventArgs e)
        {
            orderSource.DataSource = service.list;

        }

        private void Importbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                service.Import(openFileDialog1.FileName.ToString());
                orderSource.DataSource = service.list;

                ResetSource();

            }
            ResetSource();

        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                service.Export(saveFileDialog1.FileName.ToString());

            }

        }
    }
}
