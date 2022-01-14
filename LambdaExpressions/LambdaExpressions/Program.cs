using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employList = new List<Employees>();

            employList.Add(new Employees() {
                Firstname = "Loren", Lastname = "Dalimar", Id = 1 
            });
            employList.Add(new Employees() {
                Firstname = "Joe", Lastname = "Tenak", Id = 2
            });
            employList.Add(new Employees() {
                Firstname = "Warren", Lastname = "Morell", Id = 3
            });
            employList.Add(new Employees() {
                Firstname = "Akira", Lastname = "Soren", Id = 4
            });
            employList.Add(new Employees() {
                Firstname = "Jemma", Lastname = "Lilian", Id = 5
            });
            employList.Add(new Employees() {
                Firstname = "Joe", Lastname = "Helor", Id = 6
            });
            employList.Add(new Employees() {
                Firstname = "Charles", Lastname = "Portsmith", Id = 7
            });
            employList.Add(new Employees() {
                Firstname = "Terry", Lastname = "Xavier", Id = 8
            });
            employList.Add(new Employees() {
                Firstname = "Qorin", Lastname = "Oliver", Id = 9
            });
            employList.Add(new Employees() {
                Firstname = "Bellam", Lastname = "Iver", Id = 10
            });

            List<Employees> joesList = new List<Employees>();

            foreach (Employees employees in employList)
            {
                if (employees.Firstname == "Joe")
                {
                    joesList.Add(employees);
                }
            }
            Console.ReadLine();
        }
    }
}
