using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void RecArea()
        {
            
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("\nArea of the rectangle: " + area);
            Console.ReadLine();

        }
        
        static void Main(string[] args)
        {
            RecArea();
        }
    }
}
