using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 2. 
            // In the Main() method of the console app, instantiate the class.
            Operator Operator = new Operator();

            // STEP 3. 
            // Call the method in the class, passing in two numbers.
            Operator.MethodExample(10, 2);
            //STEP 4.
            // Call the method in the class, specifying the parameters by name.
            Operator.MethodExample(num1: 10, num2: 15);

        }
    }
}
