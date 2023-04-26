using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int fruit = 5;
            switch (fruit)
            {
                case 1:
                    Console.WriteLine("banana");
                    break;
                case 2:
                    Console.WriteLine("lemon");
                    break;
                case 3:
                    Console.WriteLine("strawberry");
                    break;
                case 4:
                    Console.WriteLine("watermelon");
                    break;
                case 5:
                    Console.WriteLine("apple");
                    break;
                case 6:
                    Console.WriteLine("blueberry");
                    break;
                case 7:
                    Console.WriteLine("orange");
                    break;
            }
            Console.ReadLine();
        }
    }
}
