using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilize the greater than operator and display output to the console
            int age = 26;
            if (age > 16)
            {
                Console.WriteLine("You can get a driver's license");
            }
            //Utilize the lesser than or equal to operator and display output to the console
            int age2 = 15;
            if (age2 <= 15)
            {
                Console.WriteLine("You can't get a driver's license");
            }

            Console.ReadLine();
        }
    }
}
