using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssgn
{
    class Program
    {
        static void Main(string[] args)
        {    
            myMethod myMath = new myMethod();// Instantiated class in Main()

            Console.WriteLine("Enter a number to divide by 2 "); //Requested users integer for operation
            int userInput = Convert.ToInt32(Console.ReadLine()); //Users input held in int "userInput"
            myMath.myMethods (userInput); //Method called on input integer.

            int secInt = 40; 
            myMethod.myMethods (out secInt);
            Console.WriteLine(secInt);

            Console.ReadLine();
        }
    }
}
