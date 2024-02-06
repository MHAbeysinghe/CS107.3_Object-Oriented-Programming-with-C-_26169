using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num+ "*"+ i+" = "+ num*i);

            }
            Console.ReadLine();
        }
    }
}
