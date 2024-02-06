using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static int Fibonacci(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = "";
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                result += Convert.ToString(Fibonacci(i)) + " ";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
