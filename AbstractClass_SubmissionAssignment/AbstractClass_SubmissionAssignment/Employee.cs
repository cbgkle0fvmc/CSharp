using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_SubmissionAssignment
{
    //STEP 2. Have your Employee class from the previous drill inherit that interface and implement the Quit()
    //method in any way you choose.
    public class Employee : Person, IQuittable
    {
        List<Employee> EmployeeList = new List<Employee>();
        public override void SayName()
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);   
            //Add employee to employee list when SayName function is called
            EmployeeList.Add(this);
        }

        public void Quit()
        {
            //Remove employee from list when Quit is called
            EmployeeList.Remove(this);
            
        }

    }
}
