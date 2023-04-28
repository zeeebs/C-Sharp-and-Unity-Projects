using System;
using System.Collections.Generic; //used for lists of any data types

class Program
    {
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("hello");
        stringList.Add("zella");
        stringList.Remove("zella");

        byte[] byteArray = new byte[5000]; //arrays can be used for pics in binary form

        //int[] numArray = new int[5]; //5 =  specifying length of array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;

        Console.WriteLine(intList[0]);
        Console.ReadLine();
        }
    }
