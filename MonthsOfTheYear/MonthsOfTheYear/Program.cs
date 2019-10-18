using System;

namespace MonthsOfTheYear
{
    enum MonthsOfTheYear 
    {
        January = 1, February =  2,
        March = 3, April = 4, May = 5,
        June = 6, July = 7, August = 8,
        September = 9, October = 10,
        November = 11, December = 12  
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a month by number (1-12): ");
            string monthString = Console.ReadLine();
            
            try
            {
                int monthNum = Convert.ToInt32(monthString);
                if (monthNum >= 1 && monthNum <= 12)
                {
                    MonthsOfTheYear chosenOne = (MonthsOfTheYear)monthNum;
                    Console.WriteLine($"Your chosen month was the beautiful month of {chosenOne}");
                }
                else if(monthNum < 1 || monthNum > 12)
                {// complains if entry is not between 1-12
                    Console.Write("You didn't enter a number between 1-12.  You can't handle this calculator. Goodbye ");
                    monthString = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"You somehow created an error I didn't account for. To be honest at this point that is easy.");
                }

            }
            catch (System.FormatException)
            {
                Console.Write("You didn't enter a number! You can't handle this calculator. Goodbye :(");
                monthString = Console.ReadLine();
            }
           

            //while (!int.TryParse(monthString, out int monthNum))
            //{
            //    Console.Write("Enter only a number between 1 and 12.\n");
            //    monthString = Console.ReadLine();
            //}

            Console.ReadKey();
        }
    }
}
