using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page are you on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \" true\" or \" false\" ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
