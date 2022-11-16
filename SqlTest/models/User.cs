using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
