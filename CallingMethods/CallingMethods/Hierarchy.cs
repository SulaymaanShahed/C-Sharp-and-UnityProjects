using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Hierarchy
    {
        public int Method1(int userInput)
        {
            return userInput + 15;
        }
        public int Method2(int userInput)
        {
            return userInput - 2;
        }
        public int Method3(int userInput)
        {
            return userInput * 4;
        }
    }
}
