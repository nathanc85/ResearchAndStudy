using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndStudy
{
    class Menu
    {
        public string welcome = "Welcome to the Research and Study Project!";

        public void DisplayMenu()
        {
            WelcomeMessage(welcome);

            DisplayOptions();
        }

        private void WelcomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void DisplayOptions()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Calculate the sum of 2 numbers.");
            Console.WriteLine("2. Calculate the time to a future date.");
            Console.WriteLine("3. Exit!");
        }

        public char ReadMenuOption()
        {
            return Console.ReadKey().KeyChar;
        }

        public bool ValidateMenuOption(char option)
        {
            // Confirm it's a valid option.
            if (!char.IsDigit(option))
            {
                Error.Message("The option has to be a digit.");
                return false;
            }
            else
            {
                int chosenDigit = int.Parse(option.ToString());
                if (chosenDigit < 1 || chosenDigit > 3)
                {
                    Error.Message("The option has to be a digit between 1 and 3.");
                    return false;
                }
            }
            return true;
        }
    }
}
