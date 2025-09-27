using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen
            Console.WriteLine("Anonymous Income Comparison Program");
            //It must then print “Person 1” to the screen and get the following details from user input:
            //Hourly Rate
            //Hours worked per week
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            int person1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());

            //It must then print “Person 2” to the screen and then get the following details from user input:
            //Hourly rate
            //Hours worked per week
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int person2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours did you work?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            //It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
            int person1AnnualSalary = person1Hourly * person1Hours * 52;
            //It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
            int person2AnnualSalary = person2Hourly * person2Hours * 52;

            Console.WriteLine("Annual salary person 1: \n" + person1AnnualSalary );
            Console.WriteLine("Annual salary person 2: \n" + person2AnnualSalary);

            //It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.
            bool person1GreaterThanPerson2 = person1Hourly > person2Hourly;
            Console.WriteLine("Does person 1 make more than person 2? \n" + person1GreaterThanPerson2);

        }
    }
}
