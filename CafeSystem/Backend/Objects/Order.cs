using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Order
    {
        DateTime orderDate;

        public Order()
        {

        }

        public User OrderUser { get; set; }
        public List<Item> OrderItem { get; set; }
        public DateTime OrderDate { get; }
        public String OrderNum { get; set; }
        public Tax OrderTax { get; set;}
        public Payment OrderPayment { get; set; }
        public String DineInTakeAway { get; set; }

    }
    
}
