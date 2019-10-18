using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your number even or odd? Find out below!");
            Console.Write("Please enter give me a number: "); // should grab and convert number
            string InputH = Console.ReadLine(); // input is always a string and must be converted
            int Number = Convert.ToInt32(InputH);

            if( Number % 2 == 0)
            {
                Console.WriteLine($"Your number, {Number} , is even! Congrats!");
            }
            else if(Number % 2 == 1)
            {
                Console.WriteLine($"Your number, {Number} , is odd! Congrats!");
            }
            else // attempt at catching errors and providing sass but alas it doesn't work
            {
                Console.WriteLine($"Your number ,{Number}, isn't even a number! Failure!");
            }
            Console.ReadKey();
        }
    }
}
