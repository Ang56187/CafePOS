using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class CreditCard : Payment
    {
        private decimal paidAmt;

        public CreditCard(decimal totalAmt): base(totalAmt)
        {
            TotalAmt = totalAmt;
            paidAmt = totalAmt;
        }

        public decimal PaidAmt
        {
            get { return paidAmt; }
        }

        public override string ToString()
        {
            return String.Format("Paid by: Credit Card\n" +
                                 "Total amount:                    {0:C}\n" +
                                 "Paid amount :                    {1:C}\n\n", base.TotalAmt,PaidAmt);
        }
    }
}
