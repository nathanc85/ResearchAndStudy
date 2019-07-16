using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndStudy
{
    public static class Validation
    {
        public static bool ValidateDigit(char digit, int min, int max)
        {
            if (!char.IsDigit(digit))
            {
                Error.Message("The option has to be a digit.");
                return false;
            }
            else
            {
                int chosenDigit = int.Parse(digit.ToString());
                if (chosenDigit < min || chosenDigit > max)
                {
                    Error.Message($"The option has to be a digit between {min} and {max}.");
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateNumber(string input, out double result)
        {
            // If i didn't use "out", then i would have had to do the parsing
            // again outside this function. Another option would have been
            // returning an object with 2 fields or a Tuple. Discuss with mentor.
            // Trying to parse the input.
            bool successfulParsing = double.TryParse(input, out double number);
            result = number;
            if (!successfulParsing)
            {
                Error.Message("This is not a valid number.");
                return false;
            }
            return true;
        }

        public static bool ValidateFutureDate(string input, out DateTime result)
        {
            bool successfulParsing = DateTime.TryParse(input, out DateTime date);
            result = date;
            if (!successfulParsing)
            {
                Error.Message("This is not a valid date.");
                return false;
            }
            else
            {
                if (DateTime.Now > date)
                {
                    Error.Message("This is not a future date.");
                    return false;
                }
            }
            return true;
        }
    }
}
