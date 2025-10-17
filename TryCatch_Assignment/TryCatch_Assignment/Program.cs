using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("What is your age");
                    validInput = int.TryParse(Console.ReadLine(), out var age);
                    if (age == 0)
                    {
                        throw new AgeException();
                    }
                    int yearBorn = DateTime.Now.Year - age;
                    Console.WriteLine(yearBorn);


                }


            }
            catch (AgeException)
            {
                Console.WriteLine("You entered a zero.");
                Console.WriteLine("What is your age?");
                bool validInput = int.TryParse(Console.ReadLine(), out var age);
            }

            catch (Exception)
            {
                Console.WriteLine("Sample message");
            }

        }
    }
    public class AgeException : Exception
    {
        public AgeException() : base() { }
        public AgeException(string message) : base(message)
        {
        }
    }
}