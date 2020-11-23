using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_3;

namespace OrderClassTestProject
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void GettersAndSetters()
        {
            Order expected = new Order(1, "john doe", "1234567890", 'S', 2, DateTime.Today, DateTime.Today);

            Assert.AreEqual(expected.OrderNum, 1);
            Assert.AreEqual(expected.CustomerName, "john doe");
            Assert.AreEqual(expected.PhoneNumber, "1234567890");
            Assert.AreEqual(expected.CookieType, 'S');
            Assert.AreEqual(expected.Quantity, 2);
            Assert.AreEqual(expected.OrderDate, DateTime.Today);
            Assert.AreEqual(expected.DeliveryDate, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CustomerNameValidation()
        {
            Order expected = new Order(1, "", "1234567890", 'S', 2, DateTime.Today, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PhoneNumberValidation()
        {
            Order expected = new Order(1, "john doe", "", 'S', 2, DateTime.Today, DateTime.Today);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void QuantityValidation()
        {
            Order expected = new Order(1, "john doe", "1234567890", 'S', 0, DateTime.Today, DateTime.Today);
        }

        [TestMethod]
        public void SortOrders()
        {
            Order order1 = new Order(1, "john doe", "1234567890", 'S', 1, DateTime.Today, new DateTime(2020, 12, 1));
            Order order2 = new Order(2, "john doe", "1234567890", 'S', 2, DateTime.Today, DateTime.Today);
            Order order3 = new Order(3, "john doe", "1234567890", 'S', 3, DateTime.Today, new DateTime(2020, 11, 11));
            Order order4 = new Order(4, "john doe", "1234567890", 'S', 4, DateTime.Today, new DateTime(2021, 2, 1));

            List<Order> orderList = new List<Order>();

            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);

            orderList.Sort();

            Assert.AreEqual(orderList[0], order2);
            Assert.AreEqual(orderList[1], order3);
            Assert.AreEqual(orderList[2], order1);
            Assert.AreEqual(orderList[3], order4);
        }
    }
}
