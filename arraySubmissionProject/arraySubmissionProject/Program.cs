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
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (stringArray.Length-1));
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid. Please enter a valid integer.");
            }

            try
            {
                //ask user to select index of array
                Console.WriteLine("Please enter a whole number between 0 and 6 and the value of that index will be displayed.");
                userInput2 = Convert.ToInt32(Console.ReadLine());
                //display the string of that index in the console
                Console.WriteLine("The value of index " + userInput2 + " is: " + intArray[userInput2]);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (intArray.Length - 1));
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid. Please enter a valid integer.");
            }

            try
            {
                Console.WriteLine("Select index of string list to display value");
                userInput3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of index: " + userInput3 + " is" + stringList[userInput3]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid index. Please enter a number between 0 and " + (stringList.Count - 1));
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid. Please enter a valid integer.");
            }

        }
    }
}
