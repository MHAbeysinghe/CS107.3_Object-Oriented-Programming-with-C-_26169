using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        public class Shape
        {
            private string shapeType;
            private double area;


            public double CalculateArea(double val1,double val2)
            {
                area = val1 * val2;
                return area;
            }

            public virtual void DisplayShapeInfo()
            {
                Console.WriteLine($"Shape Type : {shapeType}");
                Console.WriteLine($"Area : {area}");
            }

            public Shape()
            {
                

            }

        }

        public class Rectangle : Shape
        {
            private double length;
            private double width;
            
            public void SetDimentions(double length, double width)
            {
                this.length = length;
                this.width = width;

            }

            public override void DisplayShapeInfo()
            {
                Console.WriteLine($"\nShape Type : Rectangle");
                Console.WriteLine($"Length : {length}");
                Console.WriteLine($"Width : {width}");
                Console.WriteLine($"Area : {CalculateArea(length, width)}\n");
            }

        }

        public class Circle : Shape
        {
            private double radius;

            public void SetRadius(double radius)
            {
                this.radius = radius;

            }

            public override void DisplayShapeInfo()
            {
                Console.WriteLine($"\nShape Type : Circle");
                Console.WriteLine($"Radius : {radius}");
                Console.WriteLine($"Area : {Math.Round(CalculateArea(radius, radius)*Math.PI, 2)}\n");
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.SetDimentions(5, 3);
            rectangle1.DisplayShapeInfo();

            Circle circle1 = new Circle();
            circle1.SetRadius(4);
            circle1.DisplayShapeInfo();


            Console.ReadLine();
        }
    }
}
