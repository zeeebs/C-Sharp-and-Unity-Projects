using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The time and date at the moment is: " + DateTime.Now);
            DateTime dT1 = DateTime.Now;
            Console.WriteLine("Please enter a number.");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            DateTime dT2 = dT1.AddHours(UserNumber);
            string futureTime = Convert.ToString(dT2);

            Console.WriteLine("In {0} hour(s) it will be {1}.", UserNumber, futureTime);
            Console.ReadLine();
        }
    }
}
