using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            twoInt twoInput = new twoInt();
            int value1, value2;

            Console.WriteLine("Pick a number:");
            if (int.TryParse(Console.ReadLine(), out value1))
            {
                Console.WriteLine(value1 + " x 2 = " + twoInput.twoInput(value1));
            }

            Console.WriteLine("(Optional) Pick another number:");
            if (int.TryParse(Console.ReadLine(), out value2))
            {
                Console.WriteLine(value2 + " x 2 = " + twoInput.twoInput(value2));
            }
            else
            {
                Console.WriteLine("a second number was not entered");
            }
            Console.ReadLine();
        }
    }
}
