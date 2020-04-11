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
    public partial class SearchIDForm : Form
    {
        public OrderService serviceCopy3;
        public Order order;
        public string ID { get; set; }
        public int id;

        public SearchIDForm()
        {
            InitializeComponent();
            SearchIDtbx.DataBindings.Clear();
            SearchIDtbx.DataBindings.Add("Text", this, "ID");

        }

        private void searchIDbtn_Click(object sender, EventArgs e)
        {
            SearchIDtbx.DataBindings.Clear();
            SearchIDtbx.DataBindings.Add("Text", this, "ID");
            if (int.TryParse(ID, out id))
            {
                if (serviceCopy3.SerchOrderByID(id) != null)
                {
                    order = serviceCopy3.SerchOrderByID(id).FirstOrDefault();
                    this.Close();

                }
                else
                {

                    label1.Text = "订单不存在";
                }
                }
            else label1.Text = "输入错误";


        }
    }
}
