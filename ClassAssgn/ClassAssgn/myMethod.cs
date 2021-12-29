using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssgn
{
    public class myMethod
    {
        public void myMethods(int firstInt)
        {
            int result = firstInt / 2;
            Console.WriteLine(result);
        }
        public static void myMethods(out int secInt)
        {
            secInt = 10;
        }
    }
}
