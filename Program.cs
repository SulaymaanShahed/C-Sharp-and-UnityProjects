using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TheTechAcademy");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your page number is: " + pageNum);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string specificS = Console.ReadLine();
            Console.WriteLine (specificS);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            byte hoursWorked = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Hours studied are: "+ hoursWorked);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            int num1 = 4;
            int num2 = 6;
            int total = num1 + num2;
            Console.WriteLine(total);

            int num3 = 9;
            int num4 = 3;
            int difference = num3 - num4;
            Console.WriteLine(difference);

            int num5 = 7;
            int num6 = 3;
            int product = num5 * num6;
            Console.WriteLine(product);

            int num7 = 16;
            int num8 = 8;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);

            string name = "Kellig";
            int number = 10;
            Console.WriteLine(name + number);
        }
    }
}
