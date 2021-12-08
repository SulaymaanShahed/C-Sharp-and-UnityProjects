using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate: ");
            int hourly1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hours Worked per week: ");
            int perWeek1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate: ");
            int hourly2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hours Worked per week: ");
            int perWeek2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int annualSal1 = perWeek1 * hourly1 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + annualSal1);
            Console.ReadLine();

            int annualSal2 = perWeek2 * hourly2 * 52;
            Console.WriteLine("Annual Salary of Person 2: " + annualSal2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2: ");
            bool vSus = annualSal1 > annualSal2;
            Console.WriteLine(vSus);
            Console.ReadLine();
            
        }
    }
}
