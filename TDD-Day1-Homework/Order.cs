using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day1_Homework
{
    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }

        public Order(int id, int cost, int revenue, int sellPrice)
        {
            this.Id = id;
            this.Cost = cost;
            this.Revenue = revenue;
            this.SellPrice = sellPrice;
        }
    }
}
