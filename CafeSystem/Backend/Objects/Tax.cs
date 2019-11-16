using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Tax
    {
        private decimal serTax;
        private decimal serCharge ;

        public Tax(decimal serTax,decimal serCharge)
        {
            SerTax = serTax;
            SerCharge = serCharge;
            serTax = 0;
            serCharge = 0;

        }

        public Tax()
        {
            serTax = 0;
            serCharge = 0;
        }

        public decimal SerTax
        {
            get{ return serTax; }
            set
            {
                if (value >= 0)
                {
                    serTax = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Service tax must be 0 or more.");
            }
        }

        public decimal SerCharge
        {
            get { return serCharge; }
            set
            {
                if (value >= 0)
                {
                    serCharge = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Service charge must be 0 or more.");
            }
        }

    }
}
