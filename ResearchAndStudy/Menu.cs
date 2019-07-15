using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndStudy
{
    class Menu
    {
        public void WelcomeMessage(string message = "Welcome to the Research and Study Project!")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void GoodbyeMessage(string goodbye = "Good bye!")
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(goodbye);
            Console.ResetColor();
        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Calculate the sum of 2 numbers.");
            Console.WriteLine("2. Calculate the time to a future date.");
            Console.WriteLine("3. Exit!");
        }

        public char ReadMenuOption()
        {
            return Console.ReadKey().KeyChar;
        }

        public void ProcessOption1()
        {
            Console.WriteLine();
            // Read and validate the first number.
            Console.Write("First number: ");
            if (Validation.ValidateNumber(Console.ReadLine(), out double firstNumber))
            {
                // Read and validate the second number.
                Console.Write("Second number: ");
                if (Validation.ValidateNumber(Console.ReadLine(), out double secondNumber))
                {
                    Calculation.CalculateSum(firstNumber, secondNumber);
                }
            }
            
        }
    }
}
