using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int person1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int person2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            int person1AnnualSalary = person1Hourly * person1Hours * 52;
            int person2AnnualSalary = person2Hourly * person2Hours * 52;

            Console.WriteLine("Annual salary person 1: \n" + person1AnnualSalary );
            Console.WriteLine("Annual salary person 2: \n" + person2AnnualSalary);

            bool person1GreaterThanPerson2 = person1Hourly > person2Hourly;
            Console.WriteLine("Does person 1 make more than person 2? \n" + person1GreaterThanPerson2);

        }
    }
}
