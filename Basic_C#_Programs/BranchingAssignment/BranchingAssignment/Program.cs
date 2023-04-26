﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Please enter the package weigh?");
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width?");
                string packageWidth = Console.ReadLine();
                int width = Convert.ToInt32(packageWidth);
                Console.WriteLine("Please enter the package height?");
                string packageHeight = Console.ReadLine();
                int height = Convert.ToInt32(packageHeight);
                Console.WriteLine("Please enter the package length?");
                string packageLength = Console.ReadLine();
                int length = Convert.ToInt32(packageLength);
                int dimension = (width + height + length);
                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int total = (width * height * length * weight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank You!");
                }
            }
            Console.ReadLine();
        }
    }
}
