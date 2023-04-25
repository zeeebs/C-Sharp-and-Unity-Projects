using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //math operators

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();


            //int quotient = 100 / 17;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //modulus operator - even #
            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //modulus operator - odd #
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //if you divide any number by 2 and it does not have a remainder, then its even, but if it does have a remainder then its odd 

            //comparison operators

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;
            //bool isWarm = currentTemp > roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;
            //bool isWarm = currentTemp <= roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;
            //bool isWarm = currentTemp == roomTemp;
            bool isWarm = currentTemp != roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
