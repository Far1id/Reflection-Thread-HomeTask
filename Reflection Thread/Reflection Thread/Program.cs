using System;

namespace Reflection_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.Price = 23;
            order1.ProductCount = 5;
            Order order2 = new Order();
            order1.Price = 33;
            order1.ProductCount = 15;
            Order order3 = new Order();
            order1.Price = 43;
            order1.ProductCount = 25;
            Order order4 = new Order();
            order1.Price = 53;
            order1.ProductCount = 35;
            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            shop.AddOrder(order4);

            Console.WriteLine(shop.GetOrdersAvg());
            //shop.RemoveOrderByNo(2);
            //foreach (var item in shop.Orders)
            //{
            //    Console.WriteLine(item.No);
            //}
            foreach (var item in shop.GetOrderByPrice(20,40))
            {
                Console.WriteLine(item.No);
            }
        }
    }
}
