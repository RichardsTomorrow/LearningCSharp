using System;

namespace ListONums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 integers pushing enter after each: ");
            int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                //Int32.TryParse(Console.ReadLine(), out num)
                int entry;
                if (Int32.TryParse(Console.ReadLine(), out entry) == true)
                {
                    numbers[i] = entry;
                    sum += entry;
                }
                else
                {
                    Console.WriteLine("You didn't enter an integer :(");
                }
            }
            Console.WriteLine($"You entered the numbers: {String.Join(",",numbers)} ");
            //foreach(int number in numbers)
            //{
            //    Console.Write($"{number}, ");
            //}

            Console.WriteLine($"\nThe sum of your numbers was {sum}");
        }


    }
      
}
