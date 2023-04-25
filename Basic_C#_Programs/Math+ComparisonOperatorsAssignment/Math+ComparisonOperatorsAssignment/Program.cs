using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_ComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1\n");

            Console.WriteLine("1. What is your hourly rate?\n");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Your hourly rate is: " + hourlyRate1+"\n");

            Console.WriteLine("2. How many hours are worked per week?\n");
            string weeklyHours1 = Console.ReadLine();
            Console.WriteLine("You work: " + weeklyHours1 + " hours\n");

            Console.WriteLine("Person 2\n");

            Console.WriteLine("1. What is your hourly rate?\n");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Your hourly rate is: " + hourlyRate2 +"\n");

            Console.WriteLine("2. How many hours are worked per week?\n");
            string weeklyHours2 = Console.ReadLine();
            Console.WriteLine("You work: " + weeklyHours2 + " hours\n");

            int hrlyRate1 = Convert.ToInt32(hourlyRate1);
            int weeklyHrs1 = Convert.ToInt32(weeklyHours1);
            int salary1 = hrlyRate1 * weeklyHrs1 * 52;
            Convert.ToString(salary1);
            Console.WriteLine("Annual salary of Person 1: " + salary1 + "\n");
            Console.ReadLine();

            int hrlyRate2 = Convert.ToInt32(hourlyRate2);
            int weeklyHrs2 = Convert.ToInt32(weeklyHours2);
            int salary2 = hrlyRate2 * weeklyHrs2 * 52;
            Convert.ToString(salary2);
            Console.WriteLine("Annual salary of Person 2: " + salary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?\n");
            bool moreSalary = salary1 > salary2;
            Console.WriteLine(moreSalary);
            Console.ReadLine();
        }
    }
}
