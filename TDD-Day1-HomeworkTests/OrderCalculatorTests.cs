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
        private List<Order> _orderData1 = new List<Order> {
            new Order(1, 1, 11, 21),
            new Order(2, 2, 12, 22),
            new Order(3, 3, 13, 23),
            new Order(4, 4, 14, 24),
            new Order(5, 5, 15, 25),
            new Order(6, 6, 16, 26),
            new Order(7, 7, 17, 27),
            new Order(8, 8, 18, 28),
            new Order(9, 9, 19, 29),
            new Order(10, 10, 20, 30),
            new Order(11, 11, 21, 31)
        };

        [TestMethod()]
        public void SumOneFieldByPagingTest_orders_is_orderData1_fieldName_is_Cost_numPerPage_is_3_result_should_be_6_15_24_21()
        {
            // arrange
            List<Order> orders = this._orderData1;
            string fieldName = "Cost";
            int numPerPage = 3;
            List<int> excepted = new List<int> { 6, 15, 24, 21 };

            OrderCalculator ordCalculator = new OrderCalculator();

            // act
            List<int> actual = ordCalculator.SumOneFieldByPaging(orders, fieldName, numPerPage);

            // assert
            CollectionAssert.AreEqual(excepted, actual);
        }

        [TestMethod()]
        public void SumOneFieldByPagingTest_orders_is_orderData1_fieldName_is_Revenue_numPerPage_is_4_result_should_be_50_66_60()
        {
            // arrange
            List<Order> orders = this._orderData1;
            string fieldName = "Revenue";
            int numPerPage = 4;
            List<int> excepted = new List<int> { 50, 66, 60 };

            OrderCalculator ordCalculator = new OrderCalculator();

            // act
            List<int> actual = ordCalculator.SumOneFieldByPaging(orders, fieldName, numPerPage);

            // assert
            CollectionAssert.AreEqual(excepted, actual);
        }
    }
}