using System;
using System.Collections.Generic; //used for lists of any data types

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> intList = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Please enter a number to divide each numer in the list by");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);

            for (int i = 0; i < intList.Count; i++)
            {
                int result = intList[i] / userNum;
                Console.WriteLine(intList[i] + " divided by " + userNum + " equals " + result);
            }
            Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("The program has emerged from the try/catch block.");
            Console.ReadLine();
        }

    }
}

