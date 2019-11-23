﻿using System;
using System;
using System;
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

        public Order(String orderNum, String orderUserName, List<Item> orderItems , Tax orderTax, Payment orderPayment,String dineOrTakeAway)
        {
            //set based on current time
            OrderDate = DateTime.Now;


            OrderNum = orderNum;
            OrderUserName = orderUserName;
            OrderItems = orderItems;
            OrderTax = orderTax;
            OrderPayment = orderPayment;
            DineOrTakeAway = dineOrTakeAway;

            IsDone = false;

        }

        //can get the values from the properties
        public String OrderNum { get; set; }
        public String OrderUserName { get; set; }//contain properties Name and Position(get and set)
        public List<Item> OrderItems { get; set; }
        public DateTime OrderDate { get; }
        public Tax OrderTax { get; set;} // contains properties SerTax and SerCharge(get and set), use this to get service tax/charge
        public Payment OrderPayment { get; set; } // contain properties PaidAmt and TotalAmt(get and set), use this to get paid/total amount
        public String DineOrTakeAway { get; set; }
        public bool IsDone { get; set; }//set if the order have been done at kitchen


    }
    
}
