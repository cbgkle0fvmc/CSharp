using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DayOfWeek dayOfWeek = new DayOfWeek();

            List<string> validInput = new List<string>(); //Empty list at top
            List<string> invalidInput = new List<string>();
            bool isValid = false;

            // STEP 4. 
            // Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.”
            // to the console if an error occurs.
            while (!isValid) //until correct day of week is iterated through, you will be asked for input
            {
                try
                {
                    // STEP 2.
                    // Prompt the user to enter the current day of the week.
                    Console.WriteLine("Please enter the current day of the week.");
                    //STEP 3.
                    // Assign the value to a variable of that enum data type you just created.
                    string userInput = Console.ReadLine().ToUpper();

                    // https://learn.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-9.0

                    foreach (string day in Enum.GetNames(typeof(DayOfWeek)))
                    {
                        if (day.ToUpper() == userInput) //use .ToUpper on user input and enum 
                        {
                            validInput.Add(day); //if user input caps is in days of week, add valid input to day of week and break to next section
                            Console.WriteLine("That's a valid day.");
                            isValid = true; // break try/catch loop 
                            break;
                        }
                        else
                        {
                            invalidInput.Add(day); // if user input not equal to day enumerator, continue iterating
                        }

                    }


                }
                catch
                {
                    //if (validInput.Count == 0)
                    //{
                    //    Console.WriteLine("Please enter an actual day of the week.");
                    //    string userInput2 = Console.ReadLine().ToUpper();
                    //}

                }
                finally // if no entries in valid entry list, ask for valid input 
                {
                    if (validInput.Count == 0)
                    {
                        Console.WriteLine("Please enter an actual day of the week.");
                        string userInput2 = Console.ReadLine().ToUpper();
                    }
                }

            }

        }
    }
}
