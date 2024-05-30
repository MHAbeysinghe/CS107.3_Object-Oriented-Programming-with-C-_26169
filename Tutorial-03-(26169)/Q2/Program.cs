using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        public class Employee
        {
            private int employeeID;
            private string fullName;
            private double salary;

            public Employee(int employeeID, string fullName, double salary)
            {
                this.employeeID = employeeID;
                this.fullName = fullName;
                this.salary = salary;

            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"EmployeeID : {employeeID}");
                Console.WriteLine($"Full Name : {fullName}");
                Console.WriteLine($"Salary : {salary}");
            }

            public int GetSetEmpID
            {
                get { return employeeID; }
            }

            public string GetSetFullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

        }
        
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "John Doe", 50000.00);

            Console.WriteLine($"Employee ID : {employee1.GetSetEmpID}");

            Console.WriteLine($"Employee FullName : {employee1.GetSetFullName}");

            employee1.GetSetFullName = "Will Smith";
            Console.WriteLine($"Employee FullName : {employee1.GetSetFullName}");

            //d). Salary cannot be changed directly from the external code(outside the class).
            // It needs to be done through Get-Set method.

            Console.ReadLine();

        }
    }
}
