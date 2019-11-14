using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Cash : Payment
    {
        public Cash(decimal paidAmt) : base(paidAmt)
        {

        }

        public decimal remainingAmount(decimal paidAmt,decimal totalAmt)
        {
            return totalAmt - paidAmt;
        }

        public bool isPaid(decimal paidAmt,decimal totalAmt)
        {
            if (remainingAmount(paidAmt, totalAmt) <= 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
