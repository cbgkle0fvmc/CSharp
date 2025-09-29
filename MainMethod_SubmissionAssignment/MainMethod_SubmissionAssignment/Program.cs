using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STEP 2.
            //In the Main() method of the console app, instantiate the class and call the one
            //method, passing in an integer. Display the result to the screen
            Operators operators = new Operators();
            Console.WriteLine(operators.add(25));

            // STEP 4.
            //In the Main() method of the console app, instantiate the class and call the
            //second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine(operators.add(225.5m));

            // STEP 6.
            // In the Main() method of the console app, instantiate the class and call the
            // third method, passing in a string that equates to an integer. Display the
            // result to the screen.
            Console.WriteLine(operators.StringToInt("50"));
        }
    }
}
