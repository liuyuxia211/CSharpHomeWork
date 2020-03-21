using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class OrderService
    {
        public List<Order> list;

        public List<Order> SerchOrderByID(int id)
        {
            var order = list.Where(item => item.ID == id);
            List<Order> ordlist = order.ToList();
            if (ordlist.Count == 0)
            {
                Console.WriteLine("订单不存在");
            }
            else return ordlist;
            return null;
        }
        public List<Order> SerchOrderByItemName(string name)
        {
            var order = list
                .Where(
                ord =>
                {
                   if( ord.OrderItems.Where(item => item.Name == name).Count() != 0)
                    return true;
                    return false;
                })
                .OrderBy(ord => ord.TotalPrize);
            List<Order> ordlist = order.ToList();
            if (ordlist.Count == 0)
            {
                Console.WriteLine("订单不存在");
            }else
            return ordlist;
            return null;//
        }
        public List<Order> SerchOrderByCustomer(string customer)
        {
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
            foreach (var item in list)
            {
                if (item.OrderItems.Equals(order.OrderItems))
                {
                    return false;
                }
            }
            if (list.Contains(order)) return false;
            list.Add(order);
            return true;


        }
        public bool OrderDelete(int id)
        {
            try
            {
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
                Console.WriteLine($"Error:{e.Message}/n" );
                return false;

            }

        }
        public bool OrderModify(Order oldOrder,Order newOrder)
        {
            try
            {
                foreach (var item in list)
                {
                    if (item.OrderItems.Equals(newOrder.OrderItems))
                    {
                        
                        return false;
                    }
                }
                if (oldOrder == null)
                {
                    Console.WriteLine("订单不存在");
                }
                else
                {
                    list[list.IndexOf(oldOrder)] = newOrder;
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error:{e.Message}");
                return false;
            }
        }
    }
}
