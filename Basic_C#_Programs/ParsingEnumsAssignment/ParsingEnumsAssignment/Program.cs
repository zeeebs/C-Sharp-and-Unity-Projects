using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string Day = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            try
            {
                Console.WriteLine(Enum.Parse(typeof(DayOfWeek), Day));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block.");
                Console.ReadLine();
            }



        }
    }
}
