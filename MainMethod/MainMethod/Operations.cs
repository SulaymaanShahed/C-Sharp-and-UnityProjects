using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Operations
    {
        public int Method1(int userInput)
        {
            return userInput - 8;
        }
        public int Method2(decimal userDec)
        {
            int conum = Convert.ToInt32(userDec);
            return conum * 50;
        }
        public int Method3(string userStr)
        {
            int coStr = Convert.ToInt32(userStr);
            return coStr + 2;
        }
    }
}
