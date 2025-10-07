using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_SubmissionAssignment
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it");
            string userInput = Console.ReadLine().ToUpper();
            bool inputIsFalse = true;
            while (inputIsFalse)
            {
                try
                {
                    foreach (String Day in Enum.GetNames(typeof(DayOfWeek))) //display all days
                    {
                        if (userInput == Day.ToUpper())
                        {
                            Console.WriteLine(userInput + " is a day.");
                            inputIsFalse = false;
                            break;
                        }
                    }
                    if (inputIsFalse)
                    {
                        throw new Exception();
                    }


                }

                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    userInput = Console.ReadLine().ToUpper();

                }

            }

        }
    }
}
          