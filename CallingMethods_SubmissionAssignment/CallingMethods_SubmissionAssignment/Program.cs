using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 2. 
            // In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("What number would you like to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // STEP 3. 
            // Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

            //instantiate object
            Step1 step1 = new Step1();

            // store result of operations in variables 
            int calc1 = step1.MethodOne(userInput);
            int calc2 = step1.MethodTwo(userInput);
            int calc3 = step1.MethodThree(userInput);

            //write results to console
            Console.WriteLine(calc1 + "\n" + calc2 + "\n" + calc3);
            Console.ReadLine();
        }

    }
}
