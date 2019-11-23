using CafeSystem.Backend.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend
{
    class UserCollection
    {
        private List<User> userList = new List<User>();

        //later can just get users from db and put it here 
        public UserCollection()
        {
            userList.Add(new User("adminuser1","adminpass1", "Admin"));
            userList.Add(new User("adminuser2","adminpass2", "Admin"));
            userList.Add(new User("adminuser3", "adminpass3", "Admin"));
            userList.Add(new User("adminuser4", "adminpass4", "Admin"));
            userList.Add(new User("adminuser5", "adminpass5", "Admin"));
            userList.Add(new User("cashieruser1", "cashierpass1", "Cashier"));
            userList.Add(new User("cashieruser2", "cashierpass2", "Cashier"));
            userList.Add(new User("cashieruser3", "cashierpass3", "Cashier"));
            userList.Add(new User("cashieruser4", "cashierpass4", "Cashier"));
            userList.Add(new User("cashieruser5", "cashierpass5", "Cashier"));
            userList.Add(new User("kitchenuser1", "kitchenpass1", "Kitchen"));
            userList.Add(new User("kitchenuser2", "kitchenpass2", "Kitchen"));
            userList.Add(new User("kitchenuser3", "kitchenpass3", "Kitchen"));
            userList.Add(new User("kitchenuser4", "kitchenpass4", "Kitchen"));
            userList.Add(new User("kitchenuser5", "kitchenpass5", "Kitchen"));
            userList.Add(new User("a", "a", ""));


        }

        public List<User> UserList { get { return userList; } set { userList = value; } }
    }
}
