using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystem.Backend.Objects
{
    class User
    {
        public User(String name, String position)
        {
            Name = name;
            Position = position;
        }

        public String Name {get;set;}
        public String Position { get; set; }

    }
}
