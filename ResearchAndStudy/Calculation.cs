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
            Console.WriteLine($"The sum between {first} and {second} is {first + second}");
        }

        public static void CalculateTimeDiff(DateTime futureDate)
        {
            TimeSpan timeDifference = futureDate - DateTime.Now;
            Console.WriteLine($"There are {timeDifference.Days} days, {timeDifference.Hours} hours and {timeDifference.Minutes} minutes until {futureDate.ToString()}");
        }
    }
}
