using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class User
    {
        //testing purpose
        public User(String name, String password,String position)
        {
            Name = name;
            Password = password;
            Position = position;
        }

        public User(String name, String position)
        {
            Name = name;
            Position = position;
        }

        public String Name {get;set;}
        public String Position { get; set; }

        public String Password { get; set; }

        public override string ToString()
        {
            return String.Format("Processed by: {0}", Name);
        }

    }
}
