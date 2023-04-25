using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

            Console.WriteLine("Choose a number to multiply by 50");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int timesFifty = num1 * 50;
            Console.WriteLine(timesFifty.ToString());
            Console.ReadLine();


        //Takes an input from the user, adds 25 to it, then prints the result to the console

            Console.WriteLine("Choose a number to add to 25");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int plusTwentyFive = num2 + 25;
            Console.WriteLine(plusTwentyFive.ToString());
            Console.ReadLine();

        //Takes an input from the user, divides it by 12.5, then prints the result to the console.

            Console.WriteLine("Choose a number to divide by 12.5");
            string number3 = Console.ReadLine();
            int num3 = Convert.ToInt32(number3);
            double quotient = num3 / 12.5;
            Console.WriteLine(quotient.ToString());
            Console.ReadLine();

        //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console
            Console.WriteLine("Choose a number to check if its greater than 50");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();


        //Takes an input from the user, divides it by 7, then prints the remainder to the console(tip: think % operator)
            Console.WriteLine("Choose a number to to divide by 7 and see the remainder");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int modulus = num5 % 7;
            Console.WriteLine(modulus.ToString());
            Console.ReadLine();

        }
    }
}
