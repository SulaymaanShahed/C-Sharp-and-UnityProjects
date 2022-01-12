using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");

            string input1 = Console.ReadLine();
            try 
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.", e);
            }
            Console.ReadLine();
        }
        
    }
}
