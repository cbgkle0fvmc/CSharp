using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 5.
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and
            // lastName “Student”. Call the SayName() method on the object.

            Employee employee = new Employee() { firstName="Sample", lastName="Student"};
            employee.SayName();
        }
    }
}
