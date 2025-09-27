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
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you had?(true/false)");
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


            bool isApproved(byte age1, bool dui1, byte tickets1)
            {
                return (age > 15 && dui == false && tickets < 3) ? true : false;
            }
            
            Console.WriteLine(isApproved(18, false, 0));
        }
    }
}
