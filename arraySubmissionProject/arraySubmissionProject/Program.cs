using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySubmissionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create one dimensional array of string
            string[] stringArray = { "Alicia", "Lucy", "Lola", "Joshua", "String", "Array" };
            //create one dimensional array of int
            int[] intArray = { 10, 20, 30, 40, 50, 60, 70 };
            //create list of strings
            List<string> stringList = new List<string>() { "index0", "index1", "index2", "index3" };
            int userInput = 0;
            int userInput2 = 0;
            int userInput3 = 0;

            try
            {
                //ask user to select index of array
                Console.WriteLine("Please enter an integer between 0 and 5.");
                userInput = Convert.ToInt32(Console.ReadLine());
                //display the string of that index in the console
                Console.WriteLine("The value of index " + userInput + " is: " + stringArray[userInput]);
            }
            catch
            {
                while (userInput > stringArray.Length)
                {
                    //if index is > array.length, user will be prompted to enter number less than array.length.
                    Console.WriteLine("That index of this string array is: " + stringArray.Length + ". Please enter number between 0 and " + stringArray.Length);
                    Console.WriteLine("Please enter an integer between 0 and 5.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                    //display the string of that index in the console
                    Console.WriteLine("The value of index " + userInput + " is: " + stringArray[userInput]);
                }


            }

            try
            {
                //ask user to select index of array
                Console.WriteLine("Please enter a whole number between 0 and 6 and the value of that index will be displayed.");
                userInput2 = Convert.ToInt32(Console.ReadLine());
                //display the string of that index in the console
                Console.WriteLine("The value of index " + userInput2 + " is: " + intArray[userInput2]);
            }

            catch
            {
                //if index is > array.length, user will be prompted to enter number less than array.length.
                Console.WriteLine("That index of this string array is: " + intArray.Length + ". Please enter number between 0 and " + intArray.Length);
                Console.WriteLine("Please enter an integer between 0 and 5.");
                userInput = Convert.ToInt32(Console.ReadLine());
                //display the string of that index in the console
                Console.WriteLine("The value of index " + userInput + " is: " + stringArray[userInput]);
            }

            try
            {
                Console.WriteLine("Select index of string list to display value");
                userInput3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of index: " + userInput3 + " is" + stringList[userInput3]);
            }
            catch
            {
                Console.WriteLine("Please enter number less than " + stringList.Count);
                userInput3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of index: " + userInput3 + " is" + stringList[userInput3]);
            }

        }
    }
}
