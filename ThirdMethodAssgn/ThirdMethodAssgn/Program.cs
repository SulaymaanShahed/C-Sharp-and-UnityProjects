using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdMethodAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodX name = new MethodX();

            name.MethodOne(4, 7);
            name.MethodOne(num1: 4, num2: 6);
            Console.ReadLine();
        }
    }
}
