using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 100 || marks < 0)
            {
                Console.WriteLine("\nError!");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("\nStudent Name: " + name);
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("\nStudent Name: " + name);
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("\nStudent Name: " + name);
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("\nStudent Name: " + name);
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("\nStudent Name: " + name);
                Console.WriteLine("Grade: F");
            }

            Console.ReadLine();
        }
    }
}
