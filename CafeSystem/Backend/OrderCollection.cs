using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeSystem.Backend.Objects;

namespace CafeSystem.Backend
{
    class OrderCollection
    {
        private static List<Order> orderList = new List<Order>();

        public static List<Order> OrderList
        {
            get { return orderList; }
            set { orderList = value; }
        }

    }
}
