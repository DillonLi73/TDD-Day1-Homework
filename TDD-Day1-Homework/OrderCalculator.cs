using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day1_Homework
{
    public class OrderCalculator
    {
        public List<int> SumOneFieldByPaging(List<Order> orders, string fieldName, int numPerPage)
        {
            PropertyInfo prop = typeof(Order).GetProperty(fieldName);
            if ( prop == null || prop.PropertyType != typeof(Int32) )
            {
                throw new TypeAccessException("the type of field " + fieldName + " is not Int32!");
            }

            List<int> result = new List<int>();
            int processedNum = 0;
            while (processedNum < orders.Count)
            {
                IEnumerable<Order> orderPage = orders.Skip(processedNum).Take(numPerPage);

                int fieldSum = 0;
                foreach (Order order in orderPage)
                {
                    fieldSum += (int)prop.GetValue(order);
                }

                result.Add(fieldSum);
                processedNum += numPerPage;
            }

            return result;
        }
    }
}
