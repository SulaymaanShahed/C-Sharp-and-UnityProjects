using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            const int P = 115; /* Created constant variable for Price. */
            Console.WriteLine($"My local constant = {P}");

            var Q = 40; /* Created variable representing Quantity of items. */
            Console.WriteLine($"Quantity of items = {Q}");
            Console.ReadLine();
        }
    }
}
