using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            methods mathOps = new methods();           

            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);

            Console.WriteLine(userNum + " plus 5 equals " + mathOps.mathOp1(userNum));
            Console.WriteLine(userNum + " multiplied by 5 equals " + mathOps.mathOp2(userNum));
            Console.WriteLine(userNum + " diveded by 5 equals " + mathOps.mathOp3(userNum));
            Console.ReadLine(); Console.ReadLine();
        }
    }
}

