using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations math = new Operations();

            Console.WriteLine("Please input a number for subtraction.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.Method1(userInput));

            Console.WriteLine("Please input a number to multiply.");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(math.Method2(userDec));

            Console.WriteLine("Please type a number in string.");
            string userStr = Convert.ToString(Console.ReadLine());
     
            Console.WriteLine(math.Method3(userStr));

            Console.ReadLine();
        }
    }
}
