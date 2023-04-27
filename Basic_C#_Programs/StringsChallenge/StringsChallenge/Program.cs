using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Concatenates three strings.

            string name = "My name is Zella.";
            string color = " My favorite color is green.";
            string animal = " My favorite animal is a cow.";

            string zella = name + color + animal;
           
            Console.WriteLine(zella);
            Console.ReadLine();

            //2. Converts a string to uppercase.
            color = color.ToUpper();
            Console.WriteLine(color);
            Console.ReadLine();

            //3. Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Zella.");
            sb.AppendLine("My favorite color is green.");
            sb.AppendLine("My favorite animal is a cow.");
            sb.AppendLine("My favorite food is french fries");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
