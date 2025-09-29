using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 2.
            // In the Main() method of the console app, instantiate the class.
            Math math = new Math();

            // STEP 3.
            // Ask the user to input two numbers, one at a time. Let them know they need not enter
            // anything for the second number.
            Console.WriteLine("Please input two numbers, one at a time. You do not need to enter anything for the second number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            // STEP 4.
            // Call the method in the class, passing in the one or two numbers entered.
            int userInput = math.OptionalMethod(num1, num2);
            Console.WriteLine(userInput);
            
            //STEP 5.
            //Try various combinations of numbers on the code, including having no second number.
            Console.WriteLine("Please input two numbers, one at a time. You do not need to enter anything for the second number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int userInput2 = math.OptionalMethod(num3, num4);
            Console.WriteLine(userInput2);

        }
    }
}
