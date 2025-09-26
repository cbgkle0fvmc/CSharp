using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        List<int> intList = new List<int>();
        intList.Add(1);
        intList.Add(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();
        //delcare an array called numArray
        //array must be instantiated (new int[5]), size of array
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 3;
        numArray[3] = 4;

        Console.WriteLine(numArray);
        Console.WriteLine(numArray[3]);

    }
}

