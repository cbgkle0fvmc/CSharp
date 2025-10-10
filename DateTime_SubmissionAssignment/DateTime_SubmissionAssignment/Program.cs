using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // STEP 1.
            // Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);
            //STEP 2.
            // Asks the user for a number.
            Console.WriteLine("Enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //STEP 3.
            //Prints to the console the exact time it will be in X hours, X being the number the user
            //entered in step 2.
            DateTime timeLater = DateTime.Now.AddHours(userInput);
            Console.WriteLine("It will be " + timeLater + " in " + userInput + " hours.");




        }
    }
}
