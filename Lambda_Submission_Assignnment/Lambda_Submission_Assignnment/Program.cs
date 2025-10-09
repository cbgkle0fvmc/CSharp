using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Submission_Assignnment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STEP 2.
            // In the Main() method, create a list of at least 10 employees. At least two employees should
            // have the first name “Joe”.
            List<Employee> employeeList = new List<Employee>();
            Employee emp1 = new Employee() {Id=1, FirstName="Lola", LastName="Gibbs"};
            employeeList.Add(emp1);
            Employee emp2 = new Employee() { Id = 2, FirstName = "Lucy", LastName = "Jethro" };
            employeeList.Add(emp2);
            Employee emp3 = new Employee() { Id = 3, FirstName = "Joe", LastName = "Joseph" };
            employeeList.Add(emp3);
            Employee emp4 = new Employee() { Id = 4, FirstName = "Rudolph", LastName = "Raindeer" };
            employeeList.Add(emp4);
            Employee emp5 = new Employee() { Id = 5, FirstName = "Steven", LastName = "Stevenson" };
            employeeList.Add(emp5);
            Employee emp6 = new Employee() { Id = 6, FirstName = "Jennifer", LastName = "Gordon" };
            employeeList.Add(emp6);
            Employee emp7 = new Employee() { Id = 7, FirstName = "Micheal", LastName = "Ross" };
            employeeList.Add(emp7);
            Employee emp8 = new Employee() { Id = 8, FirstName = "Harvey", LastName = "Spectre" };
            employeeList.Add(emp8);
            Employee emp9 = new Employee() { Id = 9, FirstName = "Joe", LastName = "Litt" };
            employeeList.Add(emp9);
            Employee emp10 = new Employee() { Id = 10, FirstName = "Zeus", LastName = "Sanches" };
            employeeList.Add(emp10);

            // STEP 3.
            // Using a foreach loop, create a new list of all employees with the first name “Joe”. In your
            // comparison statement, remember to reference the property of the object you are checking.
            List<Employee> NamedJoe = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    NamedJoe.Add(employee);
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }

            // STEP 4.
            // Perform the same action again, but this time with a lambda expression.
            int employeesNamedJoe = employeeList.Count(x => x.FirstName == "Joe");

            // STEP 5.
            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            // List<Employee> IdGreaterThan5 = new List<Employee>();
            List<Employee> IdGreaterThan5 = employeeList.Where(x => x.Id >= 5).ToList();
            foreach (Employee employee in IdGreaterThan5)
            {
                Console.WriteLine(employee.Id + " , " + employee.FirstName );
            }
        }
    }
}
