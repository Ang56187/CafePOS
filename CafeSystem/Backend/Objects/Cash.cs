using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Cash : Payment
    {
        //paid is here, since user might not pay exact amount to total price of items
        private decimal paidAmt;

        public Cash(decimal totalAmt,decimal paidAmt) : base(totalAmt)
        {
            TotalAmt = totalAmt;
            PaidAmt = paidAmt;
            this.paidAmt = 0;
        }


        public decimal PaidAmt
        {
            get { return paidAmt; }
            set
            {
                if (value >= 0)
                {
                    paidAmt = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Paid amount must be 0 or more.");
            }
        }

        public decimal RemainingAmount()
        {
            return base.TotalAmt - PaidAmt;
        }

        public bool IsPaid()
        {
            if (RemainingAmount() <= 0)
            {
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return String.Format("Paid by: Cash\n" +
                                 "Total amount:                    {0:C}\n" +
                                 "Paid amount :                    {1:C}\n" +
                                 "Change      :                    {2:C}\n", base.TotalAmt, PaidAmt,PaidAmt - TotalAmt);
        }

    }
}
