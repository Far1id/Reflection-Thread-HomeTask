using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_Thread
{
    internal class Order
    {
        public Order()
        {
            _no++;
            No = _no;
            dateTime = DateTime.Now;
        }
        static int _no;
        public int No { get; }
        public int ProductCount;
        public int Price;
        public int TotalAmount;
        public DateTime dateTime;
    }
}
