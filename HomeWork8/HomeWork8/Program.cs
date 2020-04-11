using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;


namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderService service = new OrderService();
            PrintInterface printInterface = new PrintInterface();
            int input = 10;
            Console.WriteLine("订单管理程序:");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("0：添加订单       " + "1：删除订单      " + "    2：修改订单" +
                " \n3：以ID搜索订单   " + "4：以物品名字搜索    " + "5：以用户搜索 " +
                "\n6：所有订单       " + "7：导出订单到文件    " + "8：从文件导入订单：     " + "9：退出系统");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("输入0-7：");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("输入错误,输入0-7：");
            }
            if (input == 7) return;
            while (true)
            {
                printInterface.initialprint(service, input);
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("0：添加订单       " + "1：删除订单      " + "    2：修改订单" +
                    " \n3：以ID搜索订单   " + "4：以物品名字搜索    " + "5：以用户搜索 " +
                    "\n6：所有订单       " + "7：导出订单到文件    " + "8：从文件导入订单：     " + "9：退出系统");
                Console.WriteLine("-----------------------------------------------------");
                Console.Write("输入0-9：");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("输入错误,输入0-9：");
                }
                if (input == 9) break;


            }

        }
    }
    class PrintInterface
    {
        public void initialprint(OrderService service, int input)
        {
            switch (input)
            {
                case 0:// add
                    AddOrderPrint(service);
                    break;
                case 1:// delete
                    DeleteOrderPrint(service);
                    break;
                case 2:// modify
                    ModifyOrderPrint(service);
                    break;
                case 3://serchbyid
                    SerchByIDPrint(service);
                    break;
                case 4://serchbyname
                    SerchByNamePrint(service);
                    break;
                case 5://serchbycustomer
                    SerchByCustomerPrint(service);
                    break;
                case 6:// allorder
                    allOrder(service);
                    break;
                case 7:
                    ExportPrint(service);
                    break;
                case 8:
                    ImportPrint(service);
                    break;
                default:
                    break;
            }
        }
        public void ExportPrint(OrderService service)
        {
            string path = "";
            Console.Write("输入文件保存路径，包括后缀：");
            path = Console.ReadLine();
            service.Export(path);
            Console.WriteLine("输出内容如下：");
            Console.WriteLine(File.ReadAllText(path));
        }
        public void ImportPrint(OrderService service)
        {
            string path = "";
            Console.Write("输入读取文件路径，包括后缀：");
            path = Console.ReadLine();
            service.Import(path);
            Console.WriteLine("输入订单如下：");
            service.list.ForEach(order => Console.WriteLine(order));

        }
        public void allOrder(OrderService service)
        {
            Console.WriteLine("所有订单:");
            foreach (var item in service.list)
            {
                Console.WriteLine(item);
            }
        }
        public void SerchByCustomerPrint(OrderService service)
        {
            string customer;
            List<Order> orders;
            do
            {

                Console.Write("输入客户以搜索：");
                customer = Console.ReadLine();
                if ((orders = service.SerchOrderByCustomer(customer)) != null)
                {
                    foreach (var item in orders)
                        Console.WriteLine(item);
                }
                Console.WriteLine("继续搜索请输入c，退出请输入回车：");
            } while (Console.ReadLine() == "c");
        }
        public void SerchByNamePrint(OrderService service)
        {
            string name;
            List<Order> orders;
            do
            {
                Console.Write("输入物品名字以搜索：");
                name = Console.ReadLine();
                if ((orders = service.SerchOrderByItemName(name)) != null)
                {
                    foreach (var item in orders)
                        Console.WriteLine(item);
                }
                Console.WriteLine("继续搜索请输入c，退出请输入回车：");

            } while (Console.ReadLine() == "c");
        }
        public void SerchByIDPrint(OrderService service)
        {
            int id;
            List<Order> orders;
            do
            {
                Console.Write("输入ID以搜索：");
                int.TryParse(Console.ReadLine(), out id);
                if ((orders = service.SerchOrderByID(id)) != null)
                {
                    foreach (var item in orders)
                        Console.WriteLine(item);
                }
                Console.WriteLine("继续搜索请输入c，退出请输入回车：");
            } while (Console.ReadLine() == "c");
        }
        public void ModifyOrderPrint(OrderService service)
        {
            Order neworder;
            int id;
            List<Order> orders;
            do
            {
                Console.WriteLine("输入一个新订单：");
                neworder = CreateAOrder(service);
                Console.Write("输入旧订单的ID：");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("输入错误,");
                    Console.Write("输入旧订单的ID：");
                }
                if ((orders = service.SerchOrderByID(id)) != null)
                    if (service.OrderModify(orders[0], neworder))
                        Console.WriteLine("修改成功");
                    else Console.WriteLine("原订单不存在");
                Console.WriteLine("继续修改请输入c，退出请输入回车：");

            } while (Console.ReadLine() == "c");
        }
        public void DeleteOrderPrint(OrderService service)
        {
            int id = 0;
            do
            {
                Console.Write("输入需要删除的订单ID：");
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.Write("输入错误,");
                    Console.Write("输入需要删除的订单ID：");
                }
                if (service.OrderDelete(id))
                    Console.WriteLine("删除订单成功");
                Console.WriteLine("继续删除请输入c，退出请输入回车：");

            } while (Console.ReadLine() == "c");
        }
        public Order CreateAOrder(OrderService service)
        {
            Order temp;
            int id;
            string customer;
            List<OrderItem> items = new List<OrderItem>();
            Console.Write("输入订单ID：");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("输入错误,");
                Console.Write("输入订单ID：");
            }
            Console.Write("输入客户名称：");
            customer = Console.ReadLine();
            while (true)
            {
                items.Add(AddItemPrint());
                Console.Write("想要继续加入item请输入c，退出请输入回车：");
                if (Console.ReadLine() != "c")
                {
                    break;
                }
            }
            temp = new Order(items, id, customer);
            return temp;
        }
        public void AddOrderPrint(OrderService service)
        {
            do
            {
                service.OrderAdd(CreateAOrder(service));
                Console.Write("继续添加订单请输入c，退出请输入回车：");


            } while (Console.ReadLine() == "c");

        }
        public OrderItem AddItemPrint()
        {
            int num;
            int prize;
            string name;
            Console.Write("输入物品数量：");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("输入错误,");
                Console.Write("输入物品数量：");
            }
            Console.Write("输入物品价格：");
            while (!int.TryParse(Console.ReadLine(), out prize))
            {
                Console.Write("输入错误,");
                Console.Write("输入物品价格：");
            }
            Console.Write("输入物品名称：");
            name = Console.ReadLine();
            return new OrderItem(name, num, prize);
        }
    }
}
