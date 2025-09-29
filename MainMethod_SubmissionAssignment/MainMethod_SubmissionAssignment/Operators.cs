using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod_SubmissionAssignment
{
    public class Operators
    {
        //STEP 1.
        //Create a class. In that class, create a method that will take in an integer,
        //create a math operation for this integer (addition, subtraction, etc.), then
        //return the answer as an integer.
        public int add(int x)
        {
            return x + x;
        }

        // STEP 3.
        // Add a second method to the class with the same name that will take in a decimal,
        // create a different math operation for it, then return the answer as an integer.

        public decimal add(decimal x)
        {
            return Convert.ToInt32(x + x + x);
        }

        //STEP 5.
        //Add a third method to the class, with the same name, that will take in a string,
        //convert it to an integer if possible, do a different math operation to it, then return
        //the answer as an integer.

        public int StringToInt(string x)
        {
            try
            {
                int stringToInt = int.Parse(x);
                return stringToInt * 6;

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
