using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
       public int Id { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
