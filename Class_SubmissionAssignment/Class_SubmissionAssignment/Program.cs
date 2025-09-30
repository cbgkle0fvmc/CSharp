using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 2.
            // In the Main() method, instantiate that class.
            divide divide = new divide();

            //Step 3. 
            // Have the user enter a number. 
            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number. Display the output to the screen.It should be the entered number,
            // divided by two.
            divide.OutputInteger(userInput, out int result);
            Console.WriteLine(userInput + " / 2 = " + result);

        }




            // STEP 6.
            // DECLARE A CLASS TO BE STATIC
            // STEP 4. 
            // Create a method with output parameters.
            public static void MethodWithoutParameters(out string WelcomeMessage)
        {
            WelcomeMessage = "Hey, Tech Academy Instructor!";
        }

        // STEP 5.
        // Overload a method
        public static void MethodWithoutParameters(int num1, int num2, out int calculation)
        {
            calculation = num1 * num1;

        }



    }
}

