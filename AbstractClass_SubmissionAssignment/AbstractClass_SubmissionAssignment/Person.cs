using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionAssignment
{

    // STEP 1.
    // Create an abstract class called Person with two properties: string firstName and string lastName.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        // STEP 2.
        // Give it the method SayName().
        // use abstract class so specifics can be called in sub classes
        public abstract void SayName();
    }
}
