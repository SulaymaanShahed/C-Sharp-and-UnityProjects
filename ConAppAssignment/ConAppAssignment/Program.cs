using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] artPaints = { "Oil: ", "Acrylic: ", "Pastel: ", "Ink Wash: " };
            Console.WriteLine("Please type something to add to the end: ");
            string myPaints = Convert.ToString(Console.ReadLine());
            for (int p = 0; p < artPaints.Length; p++)
            {
                Console.WriteLine(artPaints[p] + myPaints);
            }
            Console.ReadLine();
            
        }
    }
}
