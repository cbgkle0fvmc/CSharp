using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Operators_SubmissionAssignment
{
    // STEP 1.
    // Create an Employee class with Id, FirstName and LastName properties.
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //STEP 2.
        // In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by
        // comparing their Id property. Remember that comparison operators must be overloaded in pairs.


        // return bool comparing two employees as arguments, if id numbers are =, == true
        //if id numbers !=, returns false because ID not equal
        public static bool operator==(Employee left, Employee right)
        {
           if (left.Id == right.Id)
            {
                return true;
            }
           return true;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            if (left.Id != right.Id)
            {
                return false;

            }
            return false;
        }
    }
}
