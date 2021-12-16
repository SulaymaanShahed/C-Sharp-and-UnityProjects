using System;
using System.Collections.Generic;


namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an index of the array 0-4:");
            string[] favCars = {"Hyundai", "Honda", "Toyota", "Volvo", "Subaru"};
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput < 0 || userInput > 4)
            {
                Console.WriteLine("That index does not exist in this array.");
            }
            else
            {
                Console.WriteLine(favCars[userInput]);
            }

            Console.WriteLine("Select an index of the array 0-5:");
            int[] favNums = {3, 7, 12, 15, 22, 27};
            int yourInput = Convert.ToInt32(Console.ReadLine());
            if (yourInput < 0 || yourInput > 5)
            {
                Console.WriteLine("That index is non existant.");
            }
            else
            {
                Console.WriteLine(favNums[yourInput]);
            }

            Console.WriteLine("Select an index of the array 0-3:");
            List<string> myList = new List<string>();
            myList.Add("Barry");
            myList.Add("Lothar");
            myList.Add("Aren");
            myList.Add("Cyrus");
            int myNames = Convert.ToInt32(Console.ReadLine());
            if (myNames < 0 || myNames > 3)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(myList[myNames]);
            }
            Console.ReadLine();
        }
    }
}
