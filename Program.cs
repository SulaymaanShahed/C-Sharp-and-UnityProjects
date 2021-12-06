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
        }
    }
}
