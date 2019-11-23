using CafeSystem.Backend.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend
{
    class DailyOrderSummary
    {
        List<Order> orderList = OrderCollection.OrderList;

        //count the total orders made today
        List<Order> orderListToday = new List<Order>();
        //count total tax collected today
        private decimal serTaxAmtToday = 0;
        //count total charge collected today
        private decimal serChargeAmtToday = 0;
        //count total revenue colledted
        private decimal totalRevenueAmtToday = 0;

        //obtain todays data
        public void GenerateTodayOrdersData()
        {
            //set the total orders made today
            foreach (Order order in orderList)
            {
                if (order.OrderDate.Date == DateTime.Today.Date)
                {
                    orderListToday.Add(order);
                    serTaxAmtToday += order.OrderTax.SerTax;
                    serChargeAmtToday += order.OrderTax.SerCharge;
                    totalRevenueAmtToday += order.OrderPayment.TotalAmt;
                }
            }
        }

        public List<Order> OrderListToday
        {
            get { return orderListToday; }
            set { value = orderListToday; }
        }

        public decimal SerTaxAmtToday
        {
            get { return serTaxAmtToday; }
            set
            {
                if (value >= 0)
                {
                    value = serTaxAmtToday;
                }
            }
        }

        public decimal SerChargeAmtToday
        {
            get { return serChargeAmtToday; }
            set
            {
                if (value >= 0)
                {
                    value = serChargeAmtToday;
                }
            }
        }

        public decimal TotalRevenueAmtToday
        {
            get { return totalRevenueAmtToday; }
            set
            {
                if (value >= 0)
                {
                    value = totalRevenueAmtToday;
                }
            }
        }

    }
}
