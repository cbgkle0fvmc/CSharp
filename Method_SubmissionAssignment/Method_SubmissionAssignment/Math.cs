using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_SubmissionAssignment
{
    internal class Math
    {
        // STEP 1.
        // Create a class. In that class, create a method that takes two integers as parameters.
        // Make one of them optional. Have the method do a math operation and return an integer result.
        public int OptionalMethod(int num1, int num2=1)
        {
            return num1 * num1;
        }
    }
}
