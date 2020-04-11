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
    public partial class AddModifyForm2 : Form
    {
        public Order ordertemp { get; set; }
        public bool ok = false;
        public OrderService serviceCopy { get; set; }
        public Form1 form1Copy { get; set; }

        public AddModifyForm2()
        {
            InitializeComponent();
            ordertemp = new Order();
            AddModifySource1.DataSource = ordertemp.OrderItems;
            itemsGridview.DataSource = AddModifySource1;

        }
        public void Addbindings(Order order)
        {
            IDtbx.DataBindings.Clear();
            Custbx.DataBindings.Clear();
            IDtbx.DataBindings.Add("Text", order, "ID");
            Custbx.DataBindings.Add("Text", order, "Customer");
            AddModifySource1.DataSource = order.OrderItems;
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            serviceCopy.OrderAdd(ordertemp);
            form1Copy.ResetSource();
            ordertemp = new Order(); // 使ordertemp指向堆中新的对象，不然永远是同一个对象，list中只有一个order
            Addbindings(ordertemp);//修改绑定新的对象，便于继续添加
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
