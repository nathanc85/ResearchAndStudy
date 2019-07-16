using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndStudy
{
    class Calculation
    {
        public static void CalculateSum(double first, double second)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The sum between {first} and {second} is {first + second}");
            Console.ResetColor();
        }

        public static void CalculateTimeDifference(DateTime futureDate)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            TimeSpan timeDifference = futureDate - DateTime.Now;
            Console.WriteLine($"There are {timeDifference.Days} days, {timeDifference.Hours} hours and {timeDifference.Minutes} minutes until {futureDate.ToString()}");
            Console.ResetColor();
        }
    }
}
