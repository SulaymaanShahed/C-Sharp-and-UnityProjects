using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Start list of employees */
            List<Employees> employList = new List<Employees>();

            employList.Add(new Employees()
            {
                Firstname = "Loren", Lastname = "Dalimar", Id = 1
            });
            employList.Add(new Employees()
            {
                Firstname = "Joe", Lastname = "Tenak", Id = 2
            });
            employList.Add(new Employees()
            {
                Firstname = "Warren", Lastname = "Morell", Id = 3
            });
            employList.Add(new Employees()
            {
                Firstname = "Akira", Lastname = "Soren", Id = 4
            });
            employList.Add(new Employees()
            {
                Firstname = "Jemma", Lastname = "Lilian", Id = 5
            });
            employList.Add(new Employees()
            {
                Firstname = "Joe", Lastname = "Helor", Id = 6
            });
            employList.Add(new Employees()
            {
                Firstname = "Charles", Lastname = "Portsmith", Id = 7
            });
            employList.Add(new Employees()
            {
                Firstname = "Terry", Lastname = "Xavier", Id = 8
            });
            employList.Add(new Employees()
            {
                Firstname = "Qorin", Lastname = "Oliver", Id = 9
            });
            employList.Add(new Employees()
            {
                Firstname = "Bellam", Lastname = "Iver", Id = 10
            });
            /* End list of employees */

            List<Employees> joesList = new List<Employees>(); //List made for employees with firstname "Joe"

            /* Start of foreach loop that iterates through list of employees */
            foreach (Employees employees in employList)
            {
                if (employees.Firstname == "Joe")
                {
                    joesList.Add(employees);
                }
            }
            /* End of foreach loop */

            /* Start of foreach loop for employees with the firstname "Joe" */
            foreach (Employees joes in joesList)
            {
                Console.WriteLine(joes.Firstname + joes.Lastname);
            }
            /* End of foreach loop */

            /* Start new employee list for lambda expression */
            List<Employees> ajoeList = new List<Employees>() { 
                new Employees{ Firstname = "Bart", Lastname = "Jensen", Id =  1, },
                    new Employees{ Firstname = "Kelly", Lastname = "Haddes", Id =  2, },
                    new Employees{ Firstname = "Joe", Lastname = "Machio", Id =  3, },
                    new Employees{ Firstname = "Tera", Lastname = "Corsinth", Id =  4, },
                    new Employees{ Firstname = "Qorin", Lastname = "Epherin", Id =  5, },
                    new Employees{ Firstname = "Gareck", Lastname = "Lortimar", Id =  6, },
                    new Employees{ Firstname = "Solara", Lastname = "Yjaeger", Id =  7, },
                    new Employees{ Firstname = "Yassir", Lastname = "Puelora", Id =  8, },
                    new Employees{ Firstname = "Joe", Lastname = "Ocampo", Id =  9, },
                    new Employees{ Firstname = "Ingrid", Lastname = "Xanthus", Id =  10, },
            }; //End new employee list

            var lamJoes = ajoeList.Where(joe => joe.Firstname == "Joe").ToList(); //Lambda expression

            foreach (var joe in lamJoes) //Foreach loop to display all employees with firstname "Joe"
            {
                Console.WriteLine(joe.Firstname + joe.Lastname);
            }

            List<Employees> empId = ajoeList.Where(employId => employId.Id > 5).ToList();

            foreach (Employees employee in empId)
            {
                Console.WriteLine(employee.Firstname + employee.Lastname + " Id:" + employee.Id);
            }

            Console.ReadLine();
        }
    }
}
