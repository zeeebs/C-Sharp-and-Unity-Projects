using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. What is your age?\n");
            string age = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Have you ever had a DUI? Please type \"yes\" or \"no\"\n");
            string dui = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("How many speeding tickets do you have?\n");
            string ticket = Console.ReadLine();

            Console.WriteLine("\n");

            int yourAge = Convert.ToInt32(age);
            int speedingTickets = Convert.ToInt32(ticket);
           
            Console.WriteLine("Qualified?\n");
            bool qualified = (yourAge > 15 && dui == "no" && speedingTickets < 4);
            Console.WriteLine(qualified);
            Console.ReadLine();



        }
        
    }
}
