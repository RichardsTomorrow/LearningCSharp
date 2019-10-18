using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of your Fibonacci sequence: ");
            int entry;
            if (!Int32.TryParse(Console.ReadLine(), out entry)) 
            {
                Console.WriteLine("Sorry but I couldn't read that");
            }
            Console.WriteLine("Welcome to the wonderous world of Fibonacci!");
            for (int i = 0; i < entry; i++)
            {
                Console.WriteLine(Fibonacci(i+1));
                Console.Beep();
            }
            //Console.WriteLine(Fibonacci(10));
            Console.ReadKey();


            static int Fibonacci(int number)
            {
                if (number == 1)//base cases as hinted in the book
                {
                    return 1;
                } 
                else if (number == 2)
                {
                    return 1;
                }
                // I looked up solutions on Stack Overflow and played around 
                //until I got something working.
                // I understand how this works for numbers 1-5.
                return Fibonacci(number-2) + Fibonacci(number-1);
            }
        }
    }
}
