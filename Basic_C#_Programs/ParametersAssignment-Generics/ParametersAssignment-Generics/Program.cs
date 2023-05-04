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
            stringList.Things = new List<string>() { "red", "blue", "yellow", "black", "white" };


            Employee<int> intList = new Employee<int>();
            intList.Things = new List<int>() { 5, 10, 15, 20, 25 };

            for (int i = 0; i < stringList.Things.Count; i++)
            {
                Console.WriteLine(stringList.Things[i]);
                Console.WriteLine(intList.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
