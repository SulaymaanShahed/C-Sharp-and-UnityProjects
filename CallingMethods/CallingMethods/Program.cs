using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hierarchy math = new Hierarchy();
            
            Console.WriteLine("What number would you like to use math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.Method1(userInput));

            Console.WriteLine(math.Method2(userInput));

            Console.WriteLine(math.Method3(userInput));

            Console.ReadLine();
        }
    }
}
