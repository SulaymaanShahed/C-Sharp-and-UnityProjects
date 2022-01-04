using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.FirstName = "Sample ";
            name.LastName = "Student";
            name.SayName();
            Console.ReadLine();

            IQuittable youEnd = new Employee();

            youEnd.Quit();
            Console.ReadLine();
        }
    }
}
