using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 1.
            // Create a const variable.
            const string flowline_alarm = "flowline_PAHH";

            //STEP 2.
            // Create a variable using the keyword “var.”
            var flowline_PAHH_SP = 250;

        }

            // STEP 3.
            // Chain two constructors together.
            public class Alarms
        {
            public Alarms(string component) : this(component, 150) //default 150
            {
            }
            public Alarms(string component, int SP)
            {
                //example of overloading
            }

        }
    }
}

