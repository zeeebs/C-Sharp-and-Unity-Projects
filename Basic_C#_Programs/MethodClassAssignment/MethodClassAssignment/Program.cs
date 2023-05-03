using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            methodClass voidMethod = new methodClass();
            int value1, value2;

            Console.WriteLine("Pick a number:");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number:");
            value2 = Convert.ToInt32(Console.ReadLine());

            methodClass.twoInput(value1, value2);
            Console.ReadLine();
        }
        
    }
}
