using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            //part two, step 1. (create in infinite loop) this is infinite because the condition is always true
            //part two, stpe 3. fix the infinite loop (comment out the while loop
            //while (1 == 1)
            //{
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + additionalText;
                if (i <= stringArray.Length - 1)
                {
                    Console.WriteLine("----- line break -----");
                }
            }
            //print new string at each index after user input has been added to the string
            foreach (string array in stringArray)
            {
                Console.WriteLine(array);
            }
            //}

            //Part 4. Step 1: Create list of unique strings
            string[] stringArray2 = { "Treadmill", "Light", "Fan", "Dark", "Moon", "Sticky", "Note", "Screwdriver" };

            //Part 4. Step 2: Ask used for input text to search the list, hold value in variable
            Console.WriteLine("Please enter a character to seatch for text in the list that contains that character");
            string userInput = Console.ReadLine();

            //Part 4. Step 3: use for loop to iterate through string array and search for any strings that contain the user input
            List<string> matchingWords = new List<string>(); //start by instantiating empty list of add names that contain user input (matchingWords)

            //Part 4. Step 4
            //if word in stringArray2 contains the user input, add the word to the list matchingWords
            foreach (string word in stringArray2)
            {
                if (word.Contains(userInput))
                {
                    matchingWords.Add(word);

                }
            }
            //Part 4. Step 3. Display the index of the list item that contains userInput
            for (int j = 0;j < matchingWords.Count;j++)
            {
                if (matchingWords[j].Contains(userInput))
                {
                    Console.WriteLine("Index " + j + " contains user Input" );
                }
            }
            //Part 4. Step 4: Add code to check if the user put in text that isn't on the list and, if they did, tell 
            //the user their input is not on the list.

            //if no words match user input, list will contain 0 indexes, if count of list == 0, print"No words contain that character"
            if (matchingWords.Count == 0)
            {
                Console.WriteLine("No words contain that character");
            }
            //if count of list != 0, words match. in that case, use  for loopeach loop to print each word in matchingWords to the console
            else
            {
                foreach (string word in matchingWords)
                {
                    Console.WriteLine(word);
                }
            }


        }
    }
}
