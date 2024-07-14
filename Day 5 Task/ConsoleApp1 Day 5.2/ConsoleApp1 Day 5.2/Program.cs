using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Day_5._2
{
    /*c.   Find out sum of alternate digits of the given 5 digit number
Input :   12345
utput :     1 + 3 + 5  =  9 
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5-digit number:");
            int number = int.Parse(Console.ReadLine());

            int sum = SumOfAlternateDigits(number);
            Console.WriteLine($"Sum of alternate digits: {sum}");

            Console.ReadLine();
        }

        // Function to find the sum of alternate digits of the given 5-digit number
        static int SumOfAlternateDigits(int number)
        {
            string numStr = number.ToString();
            int sum = 0;

            for (int i = 0; i < numStr.Length; i += 2)
            {
                sum += int.Parse(numStr[i].ToString());
            }

            return sum;
        }
    }
}
