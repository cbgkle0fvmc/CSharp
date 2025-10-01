using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionAssignment
{
    // STEP 3.
    // Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        // STEP 4. 
        // Implement the SayName() method inside of the Employee class.
        //Made Person abstract class so SayName could be implemented 
        //override keyword to override abstract method in Person class
        public override void SayName()
        {
                Console.WriteLine("Hello, " + firstName + " " + lastName);   
        }

    }
}
