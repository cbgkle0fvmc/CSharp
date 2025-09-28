using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Strings_and_Integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to run in try block
            try
            {
                //STEP 1. 
                //create list of integers
                List<int> intList = new List<int>() { 10, 20, 25, 38, 57, 97, 734, 98561, 29, 93 };

                //ask user for user to divide each number in the list by
                Console.WriteLine("Please enter a number to divide each number in the list by.");
                int divideBy = Convert.ToInt32(Console.ReadLine());

                //Write a loop that takes each integer in the list, divides it by the number the user
                //entered, and displays the result to the screen.
                foreach (int i in intList)
                {
                    int quotient = i / divideBy;
                    Console.WriteLine(i + "/" + divideBy + " = " + quotient);
                }

            }
            //catches exception thrown by dividing by 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catches exception thrown by dividing int by string
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
