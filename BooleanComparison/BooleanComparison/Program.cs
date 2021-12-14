using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            bool yourGuess = yourNumber == 73;

            do
            {
                switch (yourNumber)
                {
                    case 35:
                        Console.WriteLine("You guessed 35. Try again.");
                        Console.WriteLine("Guess a number?");
                        yourNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("You guessed 17. Try again.");
                        Console.WriteLine("Guess a number?");
                        yourNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 49:
                        Console.WriteLine("You guessed 49. Try again.");
                        Console.WriteLine("Guess a number?");
                        yourNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 73:
                        Console.WriteLine("You guessed the number 73. That is correct!");
                        yourGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        yourNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!yourGuess);

            int s = 33;
            while(s < 100)
            {
                Console.WriteLine(s);
                s++;
            }

            Console.Read();
        }
    }
}
