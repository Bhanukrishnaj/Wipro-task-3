using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Day_5._1
{
   /* b.Print each word of the given string  in a new line.
Eg:   Input :   Welcome to C# Programming
Output:   Welcome to C# Programming*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            PrintWordsInNewLine(input);

            Console.ReadLine();
        }

        // Function to print each word of the given string in a new line
        static void PrintWordsInNewLine(string input)
        {
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
