using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Day_5._3
{
    /*d.   Given two numbers a and b, the task is to find the GCD of the two numbers.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int gcd = GCD(a, b);
            Console.WriteLine($"GCD of {a} and {b} is {gcd}");

            Console.ReadLine();
        }

        // Function to find the GCD of two numbers using Euclidean algorithm
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
