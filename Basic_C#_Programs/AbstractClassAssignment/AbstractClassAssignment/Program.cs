﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee name = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName();
            Console.ReadLine();

            IQuittable quitting = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            quitting.Quit();
            Console.WriteLine(" - {0} {1}", name.FirstName, name.LastName);
            Console.ReadLine();

        }
    }
}
