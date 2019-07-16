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
            Menu newMenu = new Menu();
            newMenu.WelcomeMessage();

            ProcessTheRequest(newMenu);

            newMenu.GoodbyeMessage();
        }

        private static void ProcessTheRequest(Menu menu)
        {
            // The truth value of the chosen option.
            char option;
            do
            {
                // Display the menu.
                menu.DisplayMenu();
                
                // Read the option.
                option = Console.ReadKey().KeyChar;
                // Validate the entry.
                bool valid = Validation.ValidateDigit(option, 1, 3);
                if (valid)
                {
                    switch (option)
                    {
                        case '1':
                            menu.ProcessOption1();
                            break;
                        case '2':
                            menu.ProcessOption2();
                            break;
                        default:
                            // I could have went with return; and it would have worked
                            // because it was exiting the loop, but i went with continue;
                            // so that the end of the loop condition would be hit.
                            // Either one works. Discuss with mentor.
                            continue;
                    }
                }
            } while (option != '3');
        }
    }
}
