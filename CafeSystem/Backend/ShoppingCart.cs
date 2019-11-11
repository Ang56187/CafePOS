using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeSystem.Backend.Objects;

namespace CafeSystem.Backend
{
    class ShoppingCart
    {
        List<Item> cartList = new List<Item>();

        public List<Item> CartList
        {
            get { return cartList; }
            set
            {
                value = cartList;
            }
        }


    }
}
