using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChall
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime lDate = DateTime.Now;

            Console.WriteLine("Please input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            DateTime mDate = lDate.AddHours(userInput);
           
            Console.WriteLine("Initial DateTime = {0:dd} {0:y}, {0:t}", lDate);
            Console.WriteLine("\nNew DateTime = {0:dd} {0:y}, {0:t} ", mDate);
            Console.ReadLine();
        }
    }
}
