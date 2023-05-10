using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
              new Employee() { ID = 1, FirstName = "Dwight", LastName = "Shrute" },
              new Employee() { ID = 2, FirstName = "Pam", LastName = "Beasly" },
              new Employee() { ID = 3, FirstName = "Jim", LastName = "Halpert" },
              new Employee() { ID = 4, FirstName = "Joe", LastName = "Schmoe" },
              new Employee() { ID = 5, FirstName = "Michael", LastName = "Scott" },
              new Employee() { ID = 6, FirstName = "Creed", LastName = "Bratton" },
              new Employee() { ID = 7, FirstName = "Joe", LastName = "Broe" },
              new Employee() { ID = 8, FirstName = "Angela", LastName = "Martin" },
              new Employee() { ID = 9, FirstName = "Stanley", LastName = "Hudson" },
              new Employee() { ID = 10, FirstName = "Andy", LastName = "Bernard" }
            };

            Employee employee = new Employee();
            List<Employee> JoeList = employees.Where(x => x.FirstName == "Joe").ToList();

            //List<Employee> checkName = new List<Employee>();
            //foreach (Employee employeeJoe in employees)
            //{
            //    if (employeeJoe.FirstName.Equals("Joe"))
            //    {
            //        checkName.Add(employeeJoe);
            //    }
            //}



            foreach (Employee Joe in JoeList)
            {
                Console.WriteLine(Joe.FirstName);
            }

            Employee ID5 = new Employee();
            List<Employee> GreaterThanFive = employees.Where(x => x.ID > 5).ToList();

            

            foreach (Employee ID in GreaterThanFive)
            {
                Console.WriteLine(ID.FirstName);
            }

            Console.ReadLine();
        }
    }
}
