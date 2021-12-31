using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssgn
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + LastName);
        }
    }
}
