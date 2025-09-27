using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterate_through_an_array_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create one dimensional array of strings
            string[] stringArray = { "Desk", "Keyboard", "Mouse", "charger", "phone", "laptop", "monitors" };
            //ask user for text input
            Console.WriteLine("Please input some text");
            string additionalText = Console.ReadLine();
            
            //iterate through each string in array and add user input to original string
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + additionalText;
            }
            //print new string at each index after user input has been added to the string
            foreach (string array in stringArray)
            {
                Console.WriteLine(array);
            }
        }
    }
}
