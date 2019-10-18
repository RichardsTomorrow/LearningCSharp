using System;

namespace MinAvgArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world!");
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; 
            
            int currentMin = Int32.MaxValue; // finds min value using a foreach loop
            foreach (int Num in array)
            {
                if(Num < currentMin)
                {
                    currentMin = Num;
                }
            }
            
            Console.WriteLine($"The minimum value of the array is {currentMin}");

            double total = 0;// must be doubles since the average of a set of numbers is rarely ever just an integer
            foreach(double Num in array)
            {
                total += Num;
            }
            double average = total / array.Length;
            Console.WriteLine($"The average of the array is {average}");
        }
    }
}
