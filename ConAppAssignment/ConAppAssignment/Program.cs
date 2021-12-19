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
            //Begin Part 1
            // Created string array with different paint types
            string[] artPaints = { "Oil ", "Acrylic ", "Pastel ", "Ink Wash " };
            Console.WriteLine("Please type something to add to the end: "); //Users input 
            string myPaints = Convert.ToString(Console.ReadLine());
            for (int p = 0; p < artPaints.Length; p++)
            {
                artPaints[p] += myPaints;
                Console.WriteLine(artPaints[p]);
            }
            //Users input returned
            //End Part 1

            //Begin Part 2
            //while (true)
            //{
            //   Console.WriteLine("Always true like infinitely true");
            //}
            
            int v = 0;
            
            while (v < 10)
            {
                Console.WriteLine("Value of v: {0}", i);
                v++;
            }
            //End Part 2

            //Begin Part 3
            int k = 0;

            while (k < 10)
            {
                Console.WriteLine("Value of k: {0}", k);
                k++;
            }

            int i = 0;

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            //End Part 3
            
            //Begin Part 4
            List<string> uniqueItems = new List<string>();
            { "Urn of Amen-Ra", "Dyanises Sword", "Pallades Diary", "Ring of Solomon", "Barbar Tea Set" };
            
            Console.WriteLine("Please input text to search in the list: ");
            string userItem = Console.ReadLine();
            Console.WriteLine("You have ");

            if (userItem == uniqueItems)
            {
                Console.WriteLine(uniqueItems.IndexOf(uniqueItems));
                break;
            }
            else
            {
                Console.WriteLine("Your choice is not in: " + uniqueItems.IndexOf(uniqueItem);
            }
            //End Part 4

            //Begin Part 5
            List<string> cards = new List<string>();
            { "Joker","King", "Queen", "Jack", "Joker",  "Ace"}

            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
            //End Part 5
        }
        Console.ReadLine();
    }
}
