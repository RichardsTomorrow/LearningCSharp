using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 100; x++)
            {
                //Console.Write($" {x} "); // print all numbers
               
                if (x % 3 == 0 && x % 5 == 0) //checks for this first so it won't check 15 for Fizz or Buzz after assigning it FizzBuzz
                {
                    Console.WriteLine(" FizzBuzz ");
                }
                else if (x % 3 == 0)
                {
                    Console.Write(" Fizz ");
                }
                else if (x % 5 == 0)
                {
                    Console.Write(" Buzz ");
                }
                else // nothing else needs to be checked so every other number should be able to print out
                {
                    Console.Write($" {x} ");
                }
            }
            
            Console.WriteLine("All I could think of during this was Fizzgig");
        }
    }
}
