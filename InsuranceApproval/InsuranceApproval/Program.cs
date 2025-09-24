using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize approval as false until proven true
            bool approval = false;
            //ask user for age, dui and tickets input 
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you had?");
            byte tickets = Convert.ToByte(Console.ReadLine());
            //use if else loop to provide boolean approval
            if (age >= 15 && dui == false && tickets < 3)
            {
                approval = true;
            } 
            else
            {
                approval = false;
            }
            Console.WriteLine(approval);
        }
    }
}
