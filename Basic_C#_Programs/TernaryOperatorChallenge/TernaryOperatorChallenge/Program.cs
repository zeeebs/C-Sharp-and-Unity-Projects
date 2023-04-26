using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 5;
            string result = num1 == num2 ? "num1 is equal to num2" : "num1 is not equal to num2";
            Console.WriteLine(result);
        
            int num3 = 5;
            int num4 = 7;
            string result2 = num3 == num4 ? "num3 is equal to num4" : "num3 is not equal to num4";
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
