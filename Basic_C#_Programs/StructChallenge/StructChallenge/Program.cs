using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amount = new Number();
            amount.Amount = 5;

            Console.WriteLine(amount.Amount);
            Console.ReadLine();

        }
    }
}
