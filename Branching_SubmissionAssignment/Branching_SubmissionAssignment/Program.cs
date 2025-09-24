using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//use System.Globalization to display shipping cost as currency
using System.Globalization;

namespace Branching_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask for user input
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            Console.WriteLine("Please enter package width.");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageHeight * packageWidth * packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            //display shipping cost in currency
            else
            {
                decimal shippingCost = packageHeight * packageWidth * packageLength * packageWeight / 100;
                //Console.WriteLine("Your estimated total for shipping this package is: " + shippingCost.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                Console.WriteLine("Your estimated total for shipping this package is: " + shippingCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));

            }

        }
    }
}
