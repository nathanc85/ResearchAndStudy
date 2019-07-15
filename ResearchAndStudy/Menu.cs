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
            // TO DO
            if (char.IsDigit(option))
            {
                var chosen = int.Parse(option.ToString());
            }
            return false;
        }
    }
}
