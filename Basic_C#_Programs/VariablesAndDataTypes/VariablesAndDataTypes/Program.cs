using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simple program
            //Console.WriteLine("What is your name");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbtye currentTemp = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; //have to put m after any decimal value

            double heightInCM = 211.30202092;

            float secondsLeft = 2.62f; //have to put f after any float value

            short tempOnMars = -341;

            string myName = "zella";

            int currentAge = 25;
            string yearsOld = currentAge.ToString(); //converting int to string

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining); //converting bool to string


            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
