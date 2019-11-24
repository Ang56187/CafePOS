using CafeSystem.Backend.Objects;
using System;
using System.Collections.Generic;

namespace CafeSystem.Backend
{
    class UserCollection
    {
        Database db = new Database();

        private List<User> userList = new List<User>();

        //later can just get users from db and put it here 
        public UserCollection()
        {
            //userList.Add(new User("adminuser1", "adminpass1", "Admin"));
            //userList.Add(new User("adminuser2", "adminpass2", "Admin"));
            //userList.Add(new User("adminuser3", "adminpass3", "Admin"));
            //userList.Add(new User("adminuser4", "adminpass4", "Admin"));
            //userList.Add(new User("adminuser5", "adminpass5", "Admin"));
            //userList.Add(new User("cashieruser1", "cashierpass1", "Cashier"));
            //userList.Add(new User("cashieruser2", "cashierpass2", "Cashier"));
            //userList.Add(new User("cashieruser3", "cashierpass3", "Cashier"));
            //userList.Add(new User("cashieruser4", "cashierpass4", "Cashier"));
            //userList.Add(new User("cashieruser5", "cashierpass5", "Cashier"));
            //userList.Add(new User("kitchenuser1", "kitchenpass1", "Kitchen"));
            //userList.Add(new User("kitchenuser2", "kitchenpass2", "Kitchen"));
            //userList.Add(new User("kitchenuser3", "kitchenpass3", "Kitchen"));
            //userList.Add(new User("kitchenuser4", "kitchenpass4", "Kitchen"));
            //userList.Add(new User("kitchenuser5", "kitchenpass5", "Kitchen"));
            //userList.Add(new User("a", "a", ""));

            db.OpenDBConnection();
            db.Sqlite_cmd = db.SqlConn.CreateCommand();//ask database what to query
            db.Sqlite_cmd.CommandText = "SELECT * FROM user";

            db.Sqlite_datareader = db.Sqlite_cmd.ExecuteReader();//reads the database


            while (db.Sqlite_datareader.Read())
            {
                String name = db.Sqlite_datareader.GetString(1);
                String pass = db.Sqlite_datareader.GetString(2);
                String role = db.Sqlite_datareader.GetString(3);

                UserList.Add(new User(name, pass, role));
            }

            db.CloseDBConnection();

        }

        public List<User> UserList { get { return userList; } set { userList = value; } }


    }
}
