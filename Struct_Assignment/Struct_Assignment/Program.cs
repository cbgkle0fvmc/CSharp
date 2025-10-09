using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    // STEP 1.
    // Create a struct called Number and give it the property “Amount” and have it be of data type decimal.
    public struct Number
    {
        public decimal Amount { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 2.
            // In the Main() method, create an object of data type Number and assign an amount to it.
            Number number = new Number() { Amount = 3.43586m };
            // STEP 3.
            // Print this amount to the console.
            Console.WriteLine(number.Amount);

        }
    }
}
