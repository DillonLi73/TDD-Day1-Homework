using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Day1_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day1_Homework.Tests
{
    [TestClass()]
    public class OrderCalculatorTests
    {
        private List<Order> GetOrders()
        {
            return new List<Order> {
                new Order() { Id=1,  Cost=1,  Revenue=11, SellPrice=21 },
                new Order() { Id=2,  Cost=2,  Revenue=12, SellPrice=22 },
                new Order() { Id=3,  Cost=3,  Revenue=13, SellPrice=23 },
                new Order() { Id=4,  Cost=4,  Revenue=14, SellPrice=24 },
                new Order() { Id=5,  Cost=5,  Revenue=15, SellPrice=25 },
                new Order() { Id=6,  Cost=6,  Revenue=16, SellPrice=26 },
                new Order() { Id=7,  Cost=7,  Revenue=17, SellPrice=27 },
                new Order() { Id=8,  Cost=8,  Revenue=18, SellPrice=28 },
                new Order() { Id=9,  Cost=9,  Revenue=19, SellPrice=29 },
                new Order() { Id=10, Cost=10, Revenue=20, SellPrice=30 },
                new Order() { Id=11, Cost=11, Revenue=21, SellPrice=31 },
            };
        }

        [TestMethod()]
        public void SumOneFieldByPagingTest_orders_is_GetOrders_fieldName_is_Cost_numPerPage_is_3_result_should_be_6_15_24_21()
        {
            // arrange
            OrderCalculator target = new OrderCalculator();

            List<Order> orders = this.GetOrders();
            string fieldName = "Cost";
            int numPerPage = 3;
            List<int> expected = new List<int> { 6, 15, 24, 21 };

            // act
            List<int> actual = target.SumOneFieldByPaging(orders, fieldName, numPerPage);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumOneFieldByPagingTest_orders_is_GetOrders_fieldName_is_Revenue_numPerPage_is_4_result_should_be_50_66_60()
        {
            // arrange
            OrderCalculator target = new OrderCalculator();
            List<Order> orders = this.GetOrders();
            string fieldName = "Revenue";
            int numPerPage = 4;
            List<int> expected = new List<int> { 50, 66, 60 };

            // act
            List<int> actual = target.SumOneFieldByPaging(orders, fieldName, numPerPage);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}