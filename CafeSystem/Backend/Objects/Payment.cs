using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Payment
    {
        private decimal totalAmt;


        public Payment(decimal totalAmt)
        {
            TotalAmt = totalAmt;
            this.totalAmt = 0;
        }

        public Payment()
        {
            this.totalAmt = 0;
        }

        public decimal TotalAmt
        {
            get { return totalAmt; }

            set
            {
                if (value >= 0)
                {
                    totalAmt = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Total amount must be 0 or more.");
            }
        }

        public override string ToString()
        {
            return String.Format("Total amount:                    {0:C}", TotalAmt);

        }
    }
}
