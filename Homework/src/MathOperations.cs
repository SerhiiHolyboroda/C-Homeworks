using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework.src
{
    internal class MathOperations
    {

        public static double NumberSumFromString(MatchCollection matches)
        {
            double sum = matches.Cast<Match>()
                      .Select(m => Double.Parse(m.Value, CultureInfo.InvariantCulture))
                      .DefaultIfEmpty(0)
                      .Sum();
            return sum;
        }
        public static double  MaximumNumber(MatchCollection matches)
        {
            double maxNumber = matches.Cast<Match>()
                    .Select(m => Double.Parse(m.Value, CultureInfo.InvariantCulture))
                    .DefaultIfEmpty(0)
                    .Max();
            return maxNumber;
        }

        public static string GetIndexOfMaximumNumber(string StrignOfNumbers)
        {
            Regex regex = new Regex(@"\d+(\.\d+)?");
            MatchCollection matches = regex.Matches(StrignOfNumbers);

            var numbers = from Match match in matches
                          select double.Parse(match.Value);

            if (numbers.Any())
            {
                double maxNumber = numbers.Max(n => (n));
                var indexofMaxNumber = numbers
                  .Select((n, i) => new { Number = (n), Index = i })
                   .Where(x => x.Number == maxNumber)
                  .Select(x => x.Index);
               return string.Join(",", indexofMaxNumber);
            }
            else
            {
                return "no numbers in this string"; 
            }
        }

        public static int GetNumberOfPages(int[] pages)
        {
            return pages.Max();
        }
        public static string GetIndexOfFastestCar(int[] randomCarsSpeeds)
        {

            double maxNumber = randomCarsSpeeds.Max(n => (n));
            var maxIndexes = randomCarsSpeeds
              .Select((n, i) => new { Number =  (n), Index = i })
               .Where(x => x.Number == maxNumber)
              .Select(x => x.Index);
                        
            return string.Join(",", maxIndexes);
        }

    }
}
