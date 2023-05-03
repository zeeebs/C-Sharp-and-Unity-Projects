using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class voidClass
    {
        public static void intOutput(int userInput)
        {
            int quotient = userInput / 2;
            Console.WriteLine(quotient);
        }

        public static void outputParameters(out int value1, out int value2)
        {
            int value3 = 5;
            value2 = value3;
            value1 = value2 + value3;
        }

        public static void outputParameters(out string value4, out string value5)
        {
            string value3 = "banana";
            value5 = value3;
            value4 = value5;
        }
    }
}
