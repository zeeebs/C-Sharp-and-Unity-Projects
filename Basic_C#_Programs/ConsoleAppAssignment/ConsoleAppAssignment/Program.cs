using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

         //boolean comparison using a while statement

            Console.WriteLine("Guess a number between 1 and 50?");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed1 = number1 == 5;

            while (!isGuessed1)
            {
                switch (number1)
                {
                    case 28:
                        Console.WriteLine("You guessed 28. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("You guessed 16. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 42:
                        Console.WriteLine("You guessed 42. Try again.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That is correct!");
                        isGuessed1 = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

                //boolean comparison using a do while statement

                    Console.WriteLine("Guess a number between 1 and 100?");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    bool isGuessed2 = number1 == 73;

                    do
                    {
                        switch (number2)
                        {
                            case 92:
                                Console.WriteLine("You guessed 92. Try again.");
                                Console.WriteLine("Guess a number?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 73:
                                Console.WriteLine("You guessed 73. That is correct!");
                                isGuessed2 = true;
                                break;
                            case 66:
                                Console.WriteLine("You guessed 66. Try again.");
                                Console.WriteLine("Guess a number?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 34:
                                Console.WriteLine("You guessed 34. Try again.");
                                Console.WriteLine("Guess a number?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("You are wrong.");
                                Console.WriteLine("Guess a number?");
                                number2 = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                    while (!isGuessed2); //!isGuessed = isGuessed=false
                    Console.ReadLine();
        }
    }
}
