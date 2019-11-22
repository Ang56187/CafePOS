using System;
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
            //test
            String fileLocation = System.IO.Path.Combine(Environment.CurrentDirectory, "..", "..", "Database", "posDB.db");

            string connStr = "Data Source=" + fileLocation + ";Version=3;Synchronous=Off;UTF8Encoding=True;";

            System.Data.SQLite.SQLiteConnection sqlConn = null;
            sqlConn = new System.Data.SQLite.SQLiteConnection(connStr);
            try
            {
                sqlConn.Open();
            }
            catch (Exception ei)
            {
            }

            System.Data.SQLite.SQLiteDataReader sqlite_datareader;
            System.Data.SQLite.SQLiteCommand sqlite_cmd;

            sqlite_cmd = sqlConn.CreateCommand();//ask database what to query
            sqlite_cmd.CommandText = "SELECT * FROM item";

            sqlite_datareader = sqlite_cmd.ExecuteReader();//reads the database


            while (sqlite_datareader.Read())
            {
                String name = sqlite_datareader.GetString(0);
                decimal price = sqlite_datareader.GetDecimal(1);
                decimal cost = sqlite_datareader.GetDecimal(2);
                String description = sqlite_datareader.GetString(3);
                String image = sqlite_datareader.GetString(4);
                String category = sqlite_datareader.GetString(5);
                String type = sqlite_datareader.GetString(6);

                MenuList.Add(new Item(name, price, cost, description, image, category, type));

            }

            sqlConn.Close();

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
