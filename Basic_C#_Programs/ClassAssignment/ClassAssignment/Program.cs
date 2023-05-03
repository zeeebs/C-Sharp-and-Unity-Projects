using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            voidClass voidMethod = new voidClass();

            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());


            voidClass.intOutput(userInput);
            Console.ReadLine();


            voidClass OutPar = new voidClass();

            voidClass.outputParameters(out int value1, out int value2);
            {
                Console.WriteLine(value1);
                Console.WriteLine(value2);
                Console.ReadLine();
            }
            voidClass.outputParameters(out string value4, out string value5);
            {
                Console.WriteLine(value4);
                Console.WriteLine(value5);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
            
    }
}

