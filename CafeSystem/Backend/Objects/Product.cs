using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Product
    {
        int qty;

        public Product(String name, int qty, String description, String image, String category, String type)
        {
            Name = name;
            Qty = qty;
            Description = description;
            Image = image;
            Category = category;
            Type = type;
        }

        public String Name { get; set; }

        public int Qty {
            get { return qty; }
            set
            {
                if (value >= 0)
                {
                    qty = value;
                }
            }
            }

        public String Description{get; set;}

        public String Image { get; set; }

        public String Category { get; set; }

        public String Type { get; set; }
    }
}
