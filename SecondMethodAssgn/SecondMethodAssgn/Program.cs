using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMethodAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            sMethod math = new sMethod();

            Console.WriteLine("Choose a number to multiply");
            int userInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.Method1(userInt));
            Console.ReadLine();

            Console.WriteLine("Optional Number: Input a 2nd number");
            int secInt = Convert.ToInt32(Console.ReadLine());
        }
    }
}
