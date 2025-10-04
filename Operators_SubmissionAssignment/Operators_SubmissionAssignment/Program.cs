using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_SubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STEP 3.
            // In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.
            // Then compare the two Employee objects using the newly overloaded operators and display the results.
            Employee employee1 = new Employee() { FirstName="Josh", LastName="Cordova", Id=1};
            Employee employee2 = new Employee() {FirstName="Alicia", LastName="Cordova", Id=2};
            bool isUnique = employee1 == employee2;
            Console.WriteLine(isUnique);
        }
    }
}
