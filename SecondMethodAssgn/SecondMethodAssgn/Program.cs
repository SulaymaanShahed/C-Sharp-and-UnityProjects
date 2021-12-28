using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMethodAssgn
{
    class Program
    {
        static void Main(string[] args)w
        {
            sMethod math = new sMethod();

            Console.WriteLine("Choose a number to multiply: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Optional: Input a 2nd number ");
                int secInt = Convert.ToInt32(Console.ReadLine());
                int result = math.Method1(userInt, secInt);
                Console.WriteLine("User input " + userInt + " and 2nd int " + secInt + " equals " + result);
            }
            catch
            {
                int result = math.Method1(userInt);
                Console.WriteLine("User input number " + userInt + " times 5 = " + result);
            }

            Console.ReadLine();

            
        }
    }
}
