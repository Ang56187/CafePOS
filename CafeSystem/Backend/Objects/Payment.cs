using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Payment
    {
        decimal paidAmount;


        public Payment(decimal paidAmt)
        {
            PaidAmount = paidAmt;
            paidAmount = 0;

        }

        public decimal PaidAmount
        {
            get { return paidAmount; }

            set
            {
                if (value >= 0)
                {
                    paidAmount = value;
                }
            }
        }

    }
}
