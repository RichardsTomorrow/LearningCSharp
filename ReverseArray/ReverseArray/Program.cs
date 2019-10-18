using System;

namespace ReverseArray
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the array reverser");
            int[] numbers = GenerateNumbers(10);
            //PrintNumbers(numbers);// show array going forwards
            Reverse(numbers);
            PrintNumbers(numbers); // should show array going backwards

            Console.ReadKey();
          
            static int[] GenerateNumbers(int arraySize)
            {
                int[] numbers = new int[arraySize];
                for(int index = 0; index < arraySize; index++)
                {// I must add 1 if I want the numbers to start at index zero but start with number 1
                    numbers[index] = index + 1; 
                 }
                return numbers;
            }
            static void PrintNumbers(int[] arrayOfNum)
            {
                foreach (int number in arrayOfNum)
                {
                    Console.Write($"{number} ");
                }
            }
            static void Reverse(int[] arrayToReverse)
            {

                //for (int index = 0; index < arrayToReverse.Length; index++)
               //{    //I dont know why I put it in a for loop but I did and I made a reverse forward flip flopper method
                int indexFirst = 0;
                int indexLast = arrayToReverse.Length - 1; //fricken 0 index ahhhhhh

                 while (indexFirst < (arrayToReverse.Length/2))// must stop in the middle
                 {
                  int temp = arrayToReverse[indexFirst];//"takes" out first at first I only "swapped" indexes [i] instead of the array's index array[i]
                   // Console.WriteLine($"1.F{arrayToReverse[indexFirst]},L{arrayToReverse[indexLast]},t{temp}"); //provides feedback about every index change
                    arrayToReverse[indexFirst] = arrayToReverse[indexLast];//puts last in first
                    //Console.WriteLine($"2.F{arrayToReverse[indexFirst]},L{arrayToReverse[indexLast]},t{temp}");//provides feedback about every index change
                    arrayToReverse[indexLast] = temp;// puts first in last
                    //Console.WriteLine($"3.F{arrayToReverse[indexFirst]},L{arrayToReverse[indexLast]},t{temp}");//provides feedback about every index change

                    indexFirst++;// grabs second. I know I could've named them differently but I named them when I worked out the first swap.
                        indexLast--;// grabs second to last
                 }
                //}
            }
        }
    }
}