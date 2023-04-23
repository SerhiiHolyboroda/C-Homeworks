using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Homework.src
{
    internal static  class Program
    {
        static void Main(string[] args)
        {

            // task 1
            Console.WriteLine("Please, input text to extract numbers");
            string input = Convert.ToString(Console.ReadLine());
            MatchCollection matches = Regex.Matches(input, @"[-+]?\d+(\.\d+)?");
           Console.WriteLine("Sum of all numbers from string = "+  MathOperations.NumberSumFromString(matches));
           Console.WriteLine("Maximum number froms string = " + MathOperations.MaximumNumber(matches));

            // task 2
            Console.WriteLine("Please, input text to extract index of largest number");
            string StringOfNumbers = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Idnex of largest number = " +  MathOperations.GetIndexOfMaximumNumber(StringOfNumbers));
            // task 3
            Random randomnumber = new Random();
            int[] pages = new int[100];

            for (int i = 0; i < pages.Length; i++)
            {
                pages[i] = randomnumber.Next(100);
            }
            Console.WriteLine("Number of pages of largest book: " + MathOperations.GetNumberOfPages(pages));

            // task 4
            Random random = new Random();
            int[] randomCarsSpeeds = new int[40];

            for (int i = 0; i < randomCarsSpeeds.Length; i++)
            {
                randomCarsSpeeds[i] = random.Next(40);
            }

            Console.WriteLine(" Indexes of highest  number in Array are: " +  MathOperations.GetIndexOfFastestCar(randomCarsSpeeds));


        }
                }
}
