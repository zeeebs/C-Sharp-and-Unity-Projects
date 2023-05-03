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

            methodClass.twoInput(value1:5, value2:15);
            Console.ReadLine();
        }
        
    }
}
