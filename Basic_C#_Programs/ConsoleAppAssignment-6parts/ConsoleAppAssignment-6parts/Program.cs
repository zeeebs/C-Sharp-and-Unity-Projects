﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //PART 1
        string[] fruits = new string[] { "apple\n", "banana\n", "grapes\n" };
        Console.WriteLine("Please add fruits to the array.");
        string fruitsAdd = Console.ReadLine();
        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i] += fruitsAdd;
        }
        Console.WriteLine("\n");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit + "\n");
        }
        Console.ReadLine();

     //PART 2
        //for (; ; )
        //{
        //    Console.WriteLine("Infinite Loop");
        //}

        for (; ; )
        {
            Console.WriteLine("Infinite Loop");
            break;
        }

     //PART 3
        int[] lessThan = new int[] { 16, 12, 3, 56, 42, 88, 97, 61 };
        for (int n = 0; n < lessThan.Length; n++)
        {
           Console.WriteLine(n);
       
        }
        Console.ReadLine();

        for (int n = 0; n <= lessThan.Length; n++)
        {
            Console.WriteLine(n);

        }
        Console.ReadLine();

     //PART 4
        List<string> colors = new List<string>() { "red", "yellow", "blue" };

        Console.WriteLine("Please input a color to search for in the list.");
        string chosenColor = Console.ReadLine();


        if (colors.Contains(chosenColor))
        {
            for (int c = 0; c < colors.Count; c++)
            {
                if (colors[c] == chosenColor)
                {
                    Console.WriteLine("That color is at index: " + c);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("That color isn't in the list, try again.");
        }
        Console.ReadLine();

     //PART 5
        List<string> animals = new List<string>() { "dog", "cat", "lizard", "cow", "hamster", "bird", "cow", "bear" };

        Console.WriteLine("Please input a color to search for in the list.");
        string chosenAnimal = Console.ReadLine();


        if (animals.Contains(chosenAnimal))
        {
            for (int a = 0; a < animals.Count; a++)
            {
                if (animals[a] == chosenAnimal)
                {
                    Console.WriteLine("That animal is at index: " + a);
                }
            }
        }
        else
        {
            Console.WriteLine("That animal isn't in the list, try again.");
        }
        Console.ReadLine();

     //PART 6
        List<string> names = new List<string>() { "zella", "gabe", "vlad", "ripper", "axel", "zella" };
        List<string> checkName = new List<string>();        

        foreach (string name in names)
        {
            if (checkName.Contains(name))
            {
                Console.WriteLine("These names already appeared in the list: " + name);
            }
            else
            {
                checkName.Add(name);
                Console.WriteLine("These names are unique: " + name);
            }
        }
        Console.ReadLine();
    }
}

