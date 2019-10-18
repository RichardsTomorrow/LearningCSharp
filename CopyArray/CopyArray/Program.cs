using System;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // this block creates the original array and prints it out
            int[] original = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numbers in the original array: ");
            foreach (int Num in original) // reads and prints out array
            {
                Console.WriteLine($"{Num} ");
            }
            // this block creates a copy of the original and prints it out
            int[] copy = new int[original.Length];// creates a array the same length as the original
            for (int i = 0;i < original.Length; i++ ) // for loops that copies
            {
                copy[i] = original[i];
            }
            Console.WriteLine("\nNumbers in the copied array: "); // add new line for formatting and so I could use one
            foreach (int NumCopy in copy)// reads and prints out array
            {
                Console.WriteLine($"{NumCopy} ");
            }
        }
    }
}
