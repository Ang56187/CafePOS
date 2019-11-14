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

        public Item(String name, decimal price, int qty, String description, String image, String category, String type)
        {
            qty = 0;
            price = 0;
            Name = name;
            Price = price;
            Quantity = qty;
            Description = description;
            Image = image;
            Category = category;
            Type = type;
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

        public decimal CalculateTotal()
        {
            return Price * Quantity;
        }

        public override String ToString()
        {
            return String.Format("Name: {0}\n" +
                "Price: {1}\n" +
                "Quantity: {2}\n" +
                "Description: {3}\n" +
                "Image: {4}\n" +
                "Category: {5}" +
                "Type: {6}",Name,Price,Quantity,Description,Image,Category,Type);
        }
    }
}
