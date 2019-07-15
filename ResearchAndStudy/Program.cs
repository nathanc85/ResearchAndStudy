using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage("Welcome to the Research and Study Project!");

            ProcessTheRequest();
        }

        /// <summary>
        /// Prints a welcome message.
        /// </summary>
        /// <param name="message">The welcome message to be printed.</param>
        private static void WelcomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Displays the menu.
        /// </summary>
        private static void DisplayTheMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Calculate the sum of 2 numbers.");
            Console.WriteLine("2. Calculate the time to a future date.");
            Console.WriteLine("3. Exit!");
        }

        private static void ProcessTheRequest()
        {
            // The truth value of the chosen option.
            int valid;
            do
            {
                // Display the menu.
                DisplayTheMenu();
                // Read the option.
                var option = Console.ReadKey().KeyChar;
                // Validate the entry.
                valid = ValidateOption(option);
                
            } while (valid);
        }

        private static bool ValidateOption(char option)
        {
            var valid = 0;
            if (char.IsDigit(option))
            {
                va = int.Parse(option.ToString());
            }

            return false;
        }
    }
}
