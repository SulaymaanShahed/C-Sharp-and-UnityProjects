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
            Console.WriteLine(favCars[userInput]);

            Console.WriteLine("Select an index of the array 0-4:");
            int[] favNums = {3, 7, 12, 15, 22};
            int yourInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(favNums[yourInput]);

            if (yourInput == 0-4)
            {
                Console.WriteLine(favNums);
            }
            else
            {
                Console.WriteLine("You are close");
            }

            List<string> myList = new List<string>();
            myList.Add("Barry");
            myList.Add("Lothar");
            myList.Add("Aren");
            myList.Add("Cyrus");
            int myNames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myList[myNames]);
            
            Console.ReadLine();
        }
    }
}
