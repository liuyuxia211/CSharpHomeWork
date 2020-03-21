using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Order:IComparable
    {
        public List<OrderItem> OrderItems;
        public int ID { get; set; }
        public string Customer { get; set; }
        public int TotalPrize
        {
            get
            {
                int total = 0;
                foreach (OrderItem item in OrderItems)
                {
                    total += item.Prize * item.Num;
                }
                return total;
            } }

        public Order(List<OrderItem> items,int id, string customer)
        {
            this.OrderItems = items;
            this.ID = id;
            this.Customer = customer;
            
        }
        public int CompareTo(object obj)
        {
            Order ord = obj as Order;
            if (ord == null)
                throw new System.ArgumentException();
            return this.ID.CompareTo(ord.ID);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(OrderItems, order.OrderItems) &&
                   ID == order.ID &&
                   Customer == order.Customer &&
                   TotalPrize == order.TotalPrize;
        }

        public override int GetHashCode()
        {
            var hashCode = -1084566199;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + TotalPrize.GetHashCode();
            return hashCode;
        }


        public override string ToString()
        {
            string str = "-----------------------------------------------------"+
                "\nID: " + ID + "          " + "Customer: " + Customer + "      " + "ToatalPrize: " + TotalPrize +
                        "\nItemName" + "        " + "ItemPrize" + "        " + "ItemNum";
            foreach (var item in OrderItems)
            {
                str+=item.ToString();
            }
           return str+ "\n-----------------------------------------------------";

        }


    }
  
    
}
