using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string UserNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\zella\Logs\log.txt", UserNumber);
            Console.WriteLine(UserNumber);
            Console.ReadLine();

        }
    }
}
