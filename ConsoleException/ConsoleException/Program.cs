using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> integerList = new List<int>() { 12, 24, 35, 27, 54 };

            Console.WriteLine("Please enter a number to divide by: ");
            int dividenD = Convert.ToInt32(Console.ReadLine());

            foreach (int integer in integerList)
            {
                Console.WriteLine(integer / dividenD);
            }
            
               
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.ReadLine();
    }
}

