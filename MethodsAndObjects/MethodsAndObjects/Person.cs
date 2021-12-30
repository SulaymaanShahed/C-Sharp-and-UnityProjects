using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        private string _firstname = "Sample";
        private string _lastname = "Student";

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + _firstname + _lastname);
        }

        
    }
}
