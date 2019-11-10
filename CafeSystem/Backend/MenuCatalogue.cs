﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeSystem.Backend.Objects;

namespace CafeSystem.Backend
{
    class MenuCatalogue
    {
        List<Item> menuList = new List<Item>();

        public List<Item> MenuList {
            get { return menuList; }
            set { menuList = value; } 
        }

        public MenuCatalogue()
        {
            //hard code items first in the mean time
            MenuList.Add(new Item("Latte", 13.00M, 0, "efewfsfsdfsefsdf", "latte.jpg", "Beverage", "Coffee"));
            MenuList.Add(new Item("Espresso", 14.34M, 0, "efewfsfsdfsefsdf", "espresso.jpg", "Beverage", "Coffee"));
            MenuList.Add(new Item("Mocha", 15.00M, 0, "efewfsfsdfsefsdf", "mocha.jpg", "Beverage", "Coffee"));
            MenuList.Add(new Item("Cappuccino", 12.00M, 0, "efewfsfsdfsefsdf", "cappuccino.jpg", "Beverage", "Coffee"));

            MenuList.Add(new Item("Matcha", 10.00M, 0, "efewfsfsdfsefsdf", "matcha.jpg", "Beverage", "Tea"));
            MenuList.Add(new Item("Jasmine tea", 6.40M, 0, "efewfsfsdfsefsdf", "jasmine-tea.jpg", "Beverage", "Tea"));

            MenuList.Add(new Item("Croissant", 4.00M, 0, "efewfsfsdfsefsdf", "croissant.jpg", "Food", "Pastry"));
            MenuList.Add(new Item("Toast", 2.00M, 0, "efewfsfsdfsefsdf", "toast.jpg", "Food", "Pastry"));

            MenuList.Add(new Item("Egg", 1.50M, 0, "efewfsfsdfsefsdf", "egg.jpg", "Food", "Sides"));
            MenuList.Add(new Item("Fries", 6.50M, 0, "efewfsfsdfsefsdf", "fries.jpg", "Food", "Sides"));

        }


        //return whole lists of items
        public List<Item> Show_All_Item()
        {
            return MenuList;
        }

        //return filtered items
        public List<Item> Show_Category_Item(String category)
        {
            var returnList =
                from item in MenuList
                where item.Category.Equals(category)
                select item;

            return (List<Item>)returnList;
        }

        public List<Item> Show_Type_Item(String type)
        {
            var returnList =
                from item in MenuList
                where item.Category.Equals(type)
                select item;

            return (List<Item>)returnList;
        }





    }
}