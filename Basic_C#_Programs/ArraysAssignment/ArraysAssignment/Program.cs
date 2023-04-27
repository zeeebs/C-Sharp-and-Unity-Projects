using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {

        //1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.


            string[] stringArray = new string[] { "red", "orange", "yellow", "green", "blue", "violet" };
            Console.WriteLine("Please select an index of the array.");
            string chosenCol = Console.ReadLine();
            int chosenColor = Convert.ToInt32(chosenCol);

            if (chosenColor == 0)
            {
                Console.WriteLine(stringArray[0]);
                Console.ReadLine();
            }
            else if (chosenColor == 1)
            {
                Console.WriteLine(stringArray[1]);
                Console.ReadLine();
            }
            else if (chosenColor == 2)
            {
                Console.WriteLine(stringArray[2]);
                Console.ReadLine();
            }
            else if (chosenColor == 3)
            {
                Console.WriteLine(stringArray[3]);
                Console.ReadLine();
            }
            else if (chosenColor == 4)
            {
                Console.WriteLine(stringArray[4]);
                Console.ReadLine();
            }
            else if (chosenColor == 5)
            {
                Console.WriteLine(stringArray[5]);
                Console.ReadLine();
            }
            else
                {
                    Console.WriteLine("That index does not exist in this array");
                    Console.ReadLine();
                }

        //Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

        
            int[] numArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Please select an index of the array.");
            string chosenNumber = Console.ReadLine();
            int chosenNum = Convert.ToInt32(chosenNumber);

            if (chosenNum == 0) 
            {
                Console.WriteLine(numArray[0]);
                Console.ReadLine();
            }
            else if (chosenNum == 1)
            {
                Console.WriteLine(numArray[1]);
                Console.ReadLine();
            }
            else if (chosenNum == 2)
            {
                Console.WriteLine(numArray[2]);
                Console.ReadLine();
            }
            else if (chosenNum == 3)
            {
                Console.WriteLine(numArray[3]);
                Console.ReadLine();
            }
            else if (chosenNum == 4)
        {
                Console.WriteLine(numArray[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist in this array");
                Console.ReadLine();
            }

        //Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("strawberry");
            stringList.Add("pineapple");
            stringList.Add("banana");
            stringList.Add("apple");
            stringList.Add("peach");

            Console.WriteLine("Please select an index of the array.");
            string chosenFruit = Console.ReadLine();
            int fruit = Convert.ToInt32(chosenFruit);

            if (fruit == 0)
            {
                Console.WriteLine(stringList[0]);
                Console.ReadLine();
            }
            else if (fruit == 1)
            {
                Console.WriteLine(stringList[1]);
                Console.ReadLine();
            }
            else if (fruit == 2)
            {
                Console.WriteLine(stringList[2]);
                Console.ReadLine();
            }
            else if (fruit == 3)
            {
                Console.WriteLine(stringList[3]);
                Console.ReadLine();
            }
            else if (fruit == 4)
            {
                Console.WriteLine(stringList[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist in this array");
                Console.ReadLine();
            }
    }
    }
