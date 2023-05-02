using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            integerMath mainMethod = new integerMath();

            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);

            Console.WriteLine(userNum + " minus 5 equals " + mainMethod.mathOp(userNum));
            Console.ReadLine();

            Console.WriteLine("Please enter a decimal");
            string userDecimal = Console.ReadLine();
            decimal userDec = (decimal)Convert.ToDouble(userDecimal);
            Console.WriteLine(userDec + " minus 1 equals " + mainMethod.mathOp(userDec));
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            string userString = Console.ReadLine();
            int userInt = Convert.ToInt32(userString);

            Console.WriteLine(userString + " divided by 2 equals " + mainMethod.mathOp(userInt));
            Console.ReadLine();
        }
    }
}
