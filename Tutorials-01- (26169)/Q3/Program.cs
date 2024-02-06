using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            if(num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    total += i;
                }
                Console.WriteLine("\nTotal= " + total);
            }

            else
            {
                Console.WriteLine("\nERROR");
            }

            Console.ReadLine();
        }
    }
}
