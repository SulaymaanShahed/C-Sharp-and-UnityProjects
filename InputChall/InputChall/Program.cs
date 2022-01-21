using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChall
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter intFile = new StreamWriter(@"C:\Users\sulay\ansel\log.txt", true))
            {
                intFile.WriteLine(DateTime.Now);
                intFile.WriteLine(userInput);
            }
            Console.ReadLine();
        }
    }
}
