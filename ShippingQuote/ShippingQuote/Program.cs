using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Enter the package weight: ");
            double pkgWt = Convert.ToDouble(Console.ReadLine());

            if (pkgWt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Enter package width: ");
            double pkgWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter package height: ");
            double pkgHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter package length: ");
            double pkgLength = Convert.ToDouble(Console.ReadLine());

            double pkgTotal = pkgWidth + pkgHeight + pkgLength;
            
            if (pkgTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            else
            {
                Console.WriteLine("Package is shippable!");
            }
            Console.ReadLine();

            double dimensions = pkgWidth * pkgHeight * pkgLength;  
            
            double pkgCalc = dimensions * pkgWt;
            double pkgQuote = pkgCalc / 100;
            Console.WriteLine(pkgQuote.ToString("C"));
            Console.ReadLine();

        }
    }
}
