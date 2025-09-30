using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SubmissionAssignment
{
    public class Overload_Method
    {
        // STEP 4. 
        // Create a method with output parameters.
        public void MethodWithoutParameters(out string WelcomeMessage)
        {
           WelcomeMessage = "Hey, Tech Academy Instructor!";
        }

        // STEP 5.
        // Overload a method
        public void MethodWithoutParameters(int num1, int num2, out int calculation) 
        {
            calculation = num1 * num1;

        }
    }
}
