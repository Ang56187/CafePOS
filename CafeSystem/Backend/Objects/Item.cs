using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class Item
    {
        int quantity ;
        decimal price;
        //additional
        decimal cost;

        public Item(String name, decimal price, int qty, String description, String image, String category, String type)
        {
            Name = name;
            Price = price;
            Quantity = qty;
            Description = description;
            Image = image;
            Category = category;
            Type = type;
            IsDone = false;

            qty = 0;
            price = 0;
        }

        //for database 
        public Item(String name, decimal price, decimal cost, String description, String image, String category, String type)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Description = description;
            Image = image;
            Category = category;
            Type = type;
            IsDone = false;

            Quantity = 0;
            price = 0;
        }

        public String Name { get; set; }

        public decimal Price 
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value >= 0)
                {
                    cost = value;
                }
            }
        }

        public int Quantity {
            get { return quantity; }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public String Description{get; set;}

        public String Image { get; set; }

        public String Category { get; set; }

        public String Type { get; set; }

        public bool IsDone { get; set; }//check if item is done at kitchen side

        public decimal CalculateTotal()
        {
            return Price * Quantity;
        }

        public override String ToString()
        {
            return String.Format("Item Name: {0}     Quantity: {1}     Price: {2:C}     Total:{3:C}\n", Name, Quantity, Price,Quantity*Price);
        }
    }
}
