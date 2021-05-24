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
            string strAge;

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

            Console.WriteLine("Enter your date of birth in yyyy/MM/dd format to calculate age:");
            strAge = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null).ToString("yyyy/MM/dd");
            DateTime toCalcAge = DateTime.Parse(strAge);

            string calculateAge(DateTime inputDate)
            {
                DateTime todaysDate = DateTime.Today;
                int months = todaysDate.Month - inputDate.Month;
                int years = todaysDate.Year - inputDate.Year;
                if (todaysDate.Day < inputDate.Day)
                {
                    months--;
                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                int days = (todaysDate - inputDate.AddMonths((years * 12) + months)).Days;

                return string.Format("{0} year{1}, {2} month{3} and {4} day{5}",
                         years, (years == 1) ? "" : "s",
                         months, (months == 1) ? "" : "s",
                         days, (days == 1) ? "" : "s");
            }

            Console.WriteLine(calculateAge(toCalcAge));



        }
    }
}
