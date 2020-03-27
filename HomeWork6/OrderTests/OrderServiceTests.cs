using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service;
        OrderItem orderItem;
        List<OrderItem> orderItems;
        Order order1;
        Order order2;

        [TestInitialize]
        public void initialize()
        {
            service = new OrderService();
            orderItem = new OrderItem("1", 1, 1);
            orderItems = new List<OrderItem>();
            orderItems.Add(orderItem);
            order1 = new Order(orderItems, 1, "1");
            order2 = new Order(orderItems, 1, "1");
            service.OrderAdd(order1);
        }


        [TestMethod()]
        public void ExportTest()
        {
            string path = "";
            string path2 = "C:\\Users\\admin\\Desktop\\order.xml";
            Assert.IsFalse(service.Export(path));//空路径返回false
            Assert.IsTrue(service.Export(path2));//成功返回值为true
        }

        [TestMethod()]
        public void importTest()
        {
            string path = "";
            string path2 = "C:\\Users\\admin\\Desktop\\order.xml";
            Assert.IsFalse(service.Import(path)); //空路径返回false
            Assert.IsTrue(service.Import(path2));   //导入成功返回true
        }

        [TestMethod()]
        public void SerchOrderByIDTest()
        {
            Assert.IsNull(service.SerchOrderByID(-1));  //id小于0时返回值为null
            Assert.AreEqual(service.SerchOrderByID(1)[0], order1);//判断结果
        }

        [TestMethod()]
        public void SerchOrderByItemNameTest()
        {
            Assert.IsNull(service.SerchOrderByItemName(""));    //空字符串返回值为null
            Assert.AreEqual(service.SerchOrderByItemName("1")[0], order1);//判断结果
        }

        [TestMethod()]
        public void SerchOrderByCustomerTest()
        {
            string customer = "";
            Assert.IsNull(service.SerchOrderByCustomer(customer));//空串返回值为null
            Assert.AreEqual(service.SerchOrderByCustomer("1")[0], order1);//判断结果
        }

        [TestMethod()]
        public void OrderAddTest()
        {
            Assert.IsFalse(service.OrderAdd(null)); //空订单测试 ，返回false
            Assert.IsFalse(service.OrderAdd(order2));//订单重复，返回false
        }

        [TestMethod()]
        public void OrderDeleteTest()
        {
            int id = -1;        //当输入的id为负数时，返回false
            int id2 = 999;      //当要删除的订单id不存在时，返回false
            Assert.IsFalse(service.OrderDelete(id) || service.OrderDelete(id2));
            Assert.IsTrue(service.OrderDelete(1));      //删除订单order1
            Assert.IsTrue(!service.list.Contains(order1));//判断order1是否还存在
        }

        [TestMethod()]
        public void OrderModifyTest()
        {
            Assert.IsFalse(service.OrderModify(order1, order2));//重复订单，返回false
        }

    }
}