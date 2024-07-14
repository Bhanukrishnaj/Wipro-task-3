using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its factorial:");
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");

            Console.ReadLine();
        }

        // Function to find the factorial of a given number
        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
