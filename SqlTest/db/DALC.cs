using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.db
{
    public class DALC
    {
        public static string GetConnectionString()
        {
            return "Server=localhost; Database=Northwind; Integrated Security=SSPI;";
        }
    }
}
