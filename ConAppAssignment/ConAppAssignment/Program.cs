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
            Console.ReadLine();
            //Users input returned
            //End Part 1

            //Begin Part 2
            //while (true)
            //{
            //   Console.WriteLine("Always true like infinitely true");
            //}
            
            //int v = 0;
            
            //while (v < 10)
            //{
            //    Console.WriteLine("Value of v: {0}", v);
            //    v++;
            //}
            //Console.ReadLine();
            //End Part 2

            //Begin Part 3
            //int k = 0;

            //while (k < 10)
            //{
            //    Console.WriteLine("Value of k: {0}", k);
            //    k++;
            //}
            //Console.ReadLine();

            //int core = 5;

            //for (int core = 5; core <= 10; core += 2)
            //{
            //    Console.WriteLine(" This is your result: " + core);
            //}
            //Console.ReadLine();
            //End Part 3

            //Begin Part 4
            List<string> uniqueItems = new List<string>()
            { "Urn of Amen-Ra", "Dyanises Sword", "Pallades Diary", "Ring of Solomon", "Barbar Tea Set" };
            
            Console.WriteLine("Please input text to search in the list: ");
            string userItem = Console.ReadLine();

            foreach (string uniqueItem in uniqueItems)
            {

                if  (userItem == uniqueItem)
                {
                    Console.WriteLine("Your choice: " + userItem + " is at " + uniqueItems.IndexOf(uniqueItem));
                    break;
                }
                else
                {
                    Console.WriteLine("Your choice is not in: " + uniqueItems.IndexOf(uniqueItem));
                }
            }
            Console.ReadLine();
            //End Part 4

            //Begin Part 5
            List<string> cards = new List<string>()
            { "Joker","King", "Queen", "Jack", "Joker",  "Ace"};

            Console.WriteLine("Pick a face card: ");
            string yourCard = Console.ReadLine();

            foreach (string card in cards)
            {
                if (yourCard == card)
                {
                    Console.WriteLine("Your choice: " + yourCard + " is at " + cards.IndexOf(card));
                    break;
                }
                else
                {
                    Console.WriteLine("Your choice is not in: " + cards.IndexOf(card));
                }
            }
            Console.ReadLine();
            //End Part 5

            //Begin Part 6
            List<string> mythicBeasts = new List<string>()
            { "Manticore", "Dragon", "Kitsune", "Phoenix", "Dragon"};

            List<string> repeatB = new List<string>();


            foreach (string beast in mythicBeasts)
            {
                if (repeatB.Contains(beast))
                { 
                    Console.WriteLine("This mythic beast has been repeated.");
                }
                else
                {
                    Console.WriteLine("This beast has not been repeated.");
                }
                repeatB.Add(beast);
            }
            Console.ReadLine();
            //End Part 6
        }
        
    }
}
