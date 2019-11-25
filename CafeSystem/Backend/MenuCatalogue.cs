using CafeSystem.Backend.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeSystem.Backend
{
    class MenuCatalogue
    {

        //handle database conn
        Database db = new Database();

        List<Item> menuList = new List<Item>();

        public List<Item> MenuList {
            get { return menuList; }
            set { menuList = value; } 
        }

        public MenuCatalogue()
        {
            db.OpenDBConnection();
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT * FROM item";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database


            while (db.Sqlite_datareader.Read())
            {
                String name = db.Sqlite_datareader.GetString(1);
                decimal price = db.Sqlite_datareader.GetDecimal(2);
                String description = db.Sqlite_datareader.GetString(3);
                String image = db.Sqlite_datareader.GetString(4);
                String category = db.Sqlite_datareader.GetString(5);
                String type = db.Sqlite_datareader.GetString(6);

                MenuList.Add(new Item(name, price, description, image, category, type));

            }

            db.CloseDBConnection();

            //hard code items first in the mean time
            //MenuList.Add(new Item("Latte", 13.00M,5.00M,  "efewfsfsdfsefsdf", "latte.jpg", "Beverage", "Coffee"));
            //MenuList.Add(new Item("Espresso", 14.34M,6.00M, "efewfsfsdfsefsdf", "espresso.jpg", "Beverage", "Coffee"));
            //MenuList.Add(new Item("Mocha", 15.00M,7.00M, "efewfsfsdfsefsdf", "mocha.jpg", "Beverage", "Coffee"));
            //MenuList.Add(new Item("Cappuccino", 12.00M, 7.00M, "efewfsfsdfsefsdf", "cappuccino.jpg", "Beverage", "Coffee"));

            //MenuList.Add(new Item("Matcha", 10.00M, 5.00M, "efewfsfsdfsefsdf", "matcha.jpg", "Beverage", "Tea"));
            //MenuList.Add(new Item("Jasmine tea", 6.40M, 2.00M, "efewfsfsdfsefsdf", "jasmine-tea.jpg", "Beverage", "Tea"));

            //MenuList.Add(new Item("Croissant", 4.00M,1.00M, "efewfsfsdfsefsdf", "croissant.jpg", "Food", "Pastry"));
            //MenuList.Add(new Item("Toast", 2.00M, 1.50M, "efewfsfsdfsefsdf", "toast.jpg", "Food", "Pastry"));

            //MenuList.Add(new Item("Egg", 1.50M, 0.50M, "efewfsfsdfsefsdf", "egg.jpg", "Food", "Sides"));
            //MenuList.Add(new Item("Fries", 6.50M, 2.00M, "efewfsfsdfsefsdf", "fries.jpg", "Food", "Sides"));

        }

        //arrange and filter the list to get the descending order of food/beverage sold
        public List<Item> TopFoodList()
        {
            //linq to get top sold foods first
            var topFoodList = (from item in MenuList
                               where item.Category == "Food"
                               orderby item.Quantity descending
                               select item).ToList();
            return topFoodList;
        }

        public List<Item> TopBeverageList()
        {
            //linq to get top sold beverage first
            var topBeverageList = (from item in menuList
                                   where item.Category == "Beverage"
                                   orderby item.Quantity descending
                                   select item).ToList();

            return topBeverageList;
        }





    }
}
