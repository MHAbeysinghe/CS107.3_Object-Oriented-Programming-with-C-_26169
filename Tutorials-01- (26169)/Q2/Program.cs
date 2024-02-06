using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=9; i++)
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("\n" + num + " is an Even number\n");
                }
                else
                {
                    Console.WriteLine("\n" + num + " is an Odd number\n");
                }
            }

        }
    }
}
