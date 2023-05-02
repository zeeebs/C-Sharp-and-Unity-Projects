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

            try
            {
                Console.WriteLine("Pick a number:");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("(Optional) Pick another number:");
                value2 = Convert.ToInt32(Console.ReadLine());
                int result = value1 * value2;
                Console.WriteLine(value1 + " x " + value2 + " = " + result);
            }
            catch
            {
                Console.WriteLine("Pick a number:");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(value1 + " x 0 = " + twoInput.twoInput(value1));
                Console.WriteLine("a second number was not entered");
            }
            Console.ReadLine();
        }
    }
}
