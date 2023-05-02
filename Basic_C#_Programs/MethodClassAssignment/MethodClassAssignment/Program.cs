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
            Console.WriteLine("Please enter a number");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(value2);
            Console.ReadLine();
        }
        
    }
}
