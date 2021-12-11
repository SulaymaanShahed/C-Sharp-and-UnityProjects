using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Please answer True or False.");
            bool yourDui = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int spTicket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool isQualified = (yourAge > 15  && yourDui == false && spTicket < 3);
            Console.WriteLine(isQualified);
            Console.ReadLine();

        }
    }
}
