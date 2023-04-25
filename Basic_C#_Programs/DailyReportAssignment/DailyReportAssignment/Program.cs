using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy \nStudent Daily Report");

        Console.WriteLine("\n");

        Console.WriteLine("What is your name?\n");
        string yourName = Console.ReadLine();
        Console.WriteLine("Your name is: " + yourName);

        Console.WriteLine("\n");

        Console.WriteLine("What course are you on?\n");
        string courseName = Console.ReadLine();
        Console.WriteLine("Your on course: " + courseName);

        Console.WriteLine("\n");

        Console.WriteLine("What page number?\n");
        string pageNumber = Console.ReadLine();
        int pgNum = Convert.ToInt32(pageNumber);
        Console.WriteLine("Your on page number: " + pgNum);

        Console.WriteLine("\n");

        Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”\n");
        string anyHelp = Console.ReadLine();
        bool needHelp = Convert.ToBoolean(anyHelp);
        Console.WriteLine("Your answer: " + needHelp);

        Console.WriteLine("\n");

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string posExperience = Console.ReadLine();
        Console.WriteLine("Your answer: " + posExperience);

        Console.WriteLine("\n");

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string anythingElse = Console.ReadLine();
        Console.WriteLine("Your answer: " + anythingElse);

        Console.WriteLine("\n");

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int hrsStudy = Convert.ToInt32(hoursStudied);
        Console.WriteLine("You studied: " + hrsStudy + " hours");

        Console.WriteLine("\n");

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        Console.ReadLine();
    }
}

