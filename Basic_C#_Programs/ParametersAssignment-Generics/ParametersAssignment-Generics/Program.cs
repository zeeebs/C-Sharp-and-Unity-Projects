using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment_Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> stringList = new Employee<string>();
            List<string> StringList = new List<string>() { "red", "blue", "yellow", "black", "white" };


            Employee<int> intList = new Employee<int>();
            List<int> IntList = new List<int>() { 5, 10, 15, 20, 25 };

            for (int i = 0; i < StringList.Count; i++)
            {
                Console.WriteLine(StringList[i]);
                Console.WriteLine(IntList[i]);
            }
            Console.ReadLine();
        }
    }
}
