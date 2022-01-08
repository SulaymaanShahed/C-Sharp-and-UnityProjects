using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            
            employee.Things = new List<string> { "Bell", "Doll", "Locket", "Watch" };

            Employee<int> employeeInt = new Employee<int>();
            
            employeeInt.Things = new List<int> { 3, 8, 13, 27 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
