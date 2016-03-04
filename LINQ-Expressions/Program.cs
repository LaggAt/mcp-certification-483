using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = { 1, 2, 5, 8, 11 };

            var result = from d
                         in data
                         where d % 2 == 0
                         select d;

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            List<int> l = data.Where(i => i % 2 == 0).ToList();

            var r = from d
                    in data
                    where d > 5
                    orderby d descending
                    select d;

            Console.WriteLine(string.Join(", ", r));// Displays 11, 8

            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };
            var r2 = from d1 in data1
                     from d2 in data2
                     select d1 * d2;

            Console.WriteLine(string.Join(", ", r2)); // Displays 2, 4, 6, 4, 8, 12, 10, 20, 30

            Product product1 = new Product
            {
                Price = 36,
                Description = "T-Shirt"
            };
            Product product2 = new Product
            {
                Price = 48,
                Description = "Shoes"
            };
            Product product3 = new Product
            {
                Price = 1300,
                Description = "Computer"
            };
            OrderLine orderLine1 = new OrderLine
            {
                Amount = 20,
                Product = product1,
            };
            OrderLine orderLine2 = new OrderLine
            {
                Amount = 39,
                Product = product2,
            };
            OrderLine orderLine3 = new OrderLine
            {
                Amount = 51,
                Product = product3,
            };
            List<OrderLine> orderLines = new List<OrderLine>
            {
                orderLine1,
                orderLine2,
                orderLine3,
            };

            var averageNumberOfOrderLines = orderLines.Average(o => o.Amount);
            Console.WriteLine("averageNumberOfOrderLines : " + averageNumberOfOrderLines);
            
            Console.ReadLine();
        }
    }

    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }
    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}
