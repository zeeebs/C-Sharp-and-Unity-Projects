using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFUnctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "zella";

            ////escape chars- preceded by \ - n=new line, t=tab, \\=\

            //string fileName = "C:\\Users\\zella";
            //string fileName2 = @"C:\Users\zella";
            //string quote = "The man said, \"Hello\", zella \n Hello on a new line. \n \t Hello on a tab.";

            //bool trueOrfalse = name.Contains("e");
            //trueOrfalse = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //strings are immutable - they cannot be changed because the string has been allocated a spot in memory - when a string is "changed" its not actually changed in memory, just a new string is created, this can become an issue when dealing with many strings that are "changed" many times because it takes up memory
            //C# has string builder (a dynamic object) to fix this issue

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is zella");

            Console.WriteLine("sb");
            Console.ReadLine();
        }
    }
}
