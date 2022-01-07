using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();

            List<string> Things = new List<string>
            { "Tape", "Pencil", "Marker", "Folder" };

            Employee<int> employeeInt = new Employee<int>();

            List<int> Intthings = new List<int>
            { 4, 6, 9, 15, 22, 37 };
        }
    }
}
