using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.ID = 12345;

            Employee name2 = new Employee();
            name2.FirstName = "Second";
            name2.LastName = "Student";
            name2.ID = 54321;

            Console.WriteLine(name == name2);

            Console.ReadLine();

        }

    }
}
