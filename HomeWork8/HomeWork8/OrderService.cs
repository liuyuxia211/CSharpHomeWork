using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace HomeWork8
{
    [Serializable]
    public class OrderService
    {
        public List<Order> list { get; set; }

        public OrderService() {
          //  Order order = new Order();
            list = new List<Order>();
            //list.Add(order);
       }
        public OrderService(List<Order> orders) { list = orders; }

        public bool Export(string path)
        {
            try
            {
                if (path == null) return false;
                else
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        xmlSerializer.Serialize(fileStream, list);
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public bool Import(string path)
        {
            try
            {
                if (path == null) return false;
                else
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                    using (FileStream fileStream = new FileStream(path, FileMode.Open))
                    {
                        list = (List<Order>)xmlSerializer.Deserialize(fileStream);
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public List<Order> SerchOrderByID(int id)
        {
            try
            {
                var order = list.Where(item => item.ID == id);
                List<Order> ordlist = order.ToList();
                if (ordlist.Count == 0)
                {
                    Console.WriteLine("订单不存在");
                    return null;
                }
                else return ordlist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
        public List<Order> SerchOrderByItemName(string name)
        {
            if (name == "") return null;
            var order = list
                .Where(
                ord =>
                {
                    if (ord.OrderItems.Where(item => item.Name == name).Count() != 0)
                        return true;
                    return false;
                    //ord.OrderItems.Where(item => item.Name == name).Count() >0;
                })
                .OrderBy(ord => ord.TotalPrize);
            List<Order> ordlist = order.ToList();
            if (ordlist.Count == 0)
            {
                Console.WriteLine("订单不存在");
            }
            else
                return ordlist;
            return null;//
        }
        public List<Order> SerchOrderByCustomer(string customer)
        {
            if (customer == "") return null;
            var order = list
                .Where(ord => ord.Customer == customer)
                .OrderBy(ord => ord.TotalPrize);
            List<Order> ordlist = order.ToList();
            if (ordlist.Count == 0)
            {
                Console.WriteLine("订单不存在");
            }
            else return ordlist;
            return null;
        }
        public void OrderSort()
        {
            list.Sort();
        }
        public bool OrderAdd(Order order)
        {
            if (order == null) return false;
           // foreach (var item in list)
            //{
              //  if (item.OrderItems.Equals(order.OrderItems))
                //{
                 //   return false;
               // }
           // }
            if (list.Contains(order)) return false;
            list.Add(order);
            return true;


        }
        public bool OrderDelete(int id)
        {
            try
            {
                if (id < 0) return false;
                foreach (var item in list)
                {
                    if (item.ID == id)
                    {
                        list.Remove(item);
                        return true;
                    }

                }

                Console.WriteLine("订单不存在,");

                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e.Message}/n");
                return false;

            }

        }
        public bool OrderModify(Order oldOrder, Order newOrder)
        {
            try
            {
                if (oldOrder.Equals(newOrder))
                {
                    Console.WriteLine("要修改的订单与原订单相同");
                    return false;
                }
                if (!list.Contains(oldOrder))
                {
                    Console.WriteLine("订单不存在");
                    return false;
                }
                else
                {
                    list[list.IndexOf(oldOrder)] = newOrder;
                    return true;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error:{e.Message}");
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            var service = obj as OrderService;
            return service != null &&
                   EqualityComparer<List<Order>>.Default.Equals(list, service.list);
        }

        public override int GetHashCode()
        {
            return 276365737 + EqualityComparer<List<Order>>.Default.GetHashCode(list);
        }
    }
}
