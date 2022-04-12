using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_Thread
{
    internal class Shop
    {
        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public int GetOrdersAvg()
        {
            int sum = 0, count = 0;
            foreach (Order item in Orders)
            {
                sum += item.Price;
                count++;
            }
            return sum / count;
        }
        public List<int> GetOrderAvg(DateTime DT)
        {
            List<int> newOrders = new List<int>();
            foreach (var item in Orders)
            {
                if (item.dateTime > DT)
                    newOrders.Add(item.TotalAmount);
            }
            return newOrders;
        }
        public void RemoveOrderByNo(int no)
        {
            foreach (var item in Orders)
            {
                if (item.No == no) 
                    Orders.Remove(item);
            }
        }
        public List<Order> GetOrderByPrice(int minPrice, int maxPrice)
        {
            return Orders.FindAll(x => x.Price > minPrice && x.Price < maxPrice);
        }
    }
}
