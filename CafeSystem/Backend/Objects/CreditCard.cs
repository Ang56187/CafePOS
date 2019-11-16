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
            paidAmt = totalAmt;
        }

        public decimal PaidAmt
        {
            get { return paidAmt; }
        }
    }
}
