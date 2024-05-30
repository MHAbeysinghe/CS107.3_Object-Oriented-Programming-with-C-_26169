using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            public string CourseName
            {
                get { return courseName; }
                set { courseName = value; }
            }
            //to throw exceptions--> // throw new ArgumentException("");
            public double Grade
            {
                get { return grade; }
                set { grade = value; }
            }

            public string SetInstructorName
            {
                set
                {
                    if (value == "")
                    {
                        throw new ArgumentException("InstructorName should not be empty.");
                    }
                    else
                    {
                        instructorName = value;
                    }
                    
                }
            }

            private string CalculateLetterGrade()
            {
                string gradeLetter;

                if (grade >= 75)
                {
                    gradeLetter = "A";
                }
                else if (grade >= 65)
                {
                    gradeLetter = "B";
                }
                else if (grade >= 55)
                {
                    gradeLetter = "C";
                }
                else if (grade >= 45)
                {
                    gradeLetter = "S";
                }
                else
                {
                    gradeLetter = "F";
                }

                return gradeLetter;
            }

            public void PrintCourseInfo()
            {
                

                Console.WriteLine($"Course Name : {courseName}");
                Console.WriteLine($"Instructor Name : {instructorName}");
                Console.WriteLine($"Grade : {CalculateLetterGrade()}");

            }

        }
        
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "ICT";
            course1.SetInstructorName = "Bob";
            course1.Grade = 82;

            course1.PrintCourseInfo();

            Console.ReadLine();
        }
    }
}
