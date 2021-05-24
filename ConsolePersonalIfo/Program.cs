using System;

namespace ConsolePersonalIfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter your name or surname in Console window and print out a full sentence.
            bool isNumeric(string variable)
            {
                int testVar;
                return int.TryParse(variable, out testVar);
            }

            string name;
            string surname;

            do
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine().Trim();
            } while (isNumeric(name));

            do
            {
                Console.WriteLine("Enter your surname:");
                surname = Console.ReadLine().Trim();
            } while (isNumeric(surname));

            //if (name == null || surname == null || name == "" || surname == "")
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                {
                Console.WriteLine("Welcome! Glad to see u! :)");
            }
            else if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Welcome {surname}! Glad to see you here! :)");
            }
            else if (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine($"Hello {name}! Have a nice day!");
            }
            else
            {
                Console.WriteLine($"Hello {name} {surname}! Enjoy your stay.");
            }
        }
    }
}
