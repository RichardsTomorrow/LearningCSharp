using System;

namespace AddIntsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This is the summ of all the ints between 1-100: ");
            int sum1 = 0;
            for (int i = 1; i < 101; i++)
            {
                sum1 += i;
            }
            Console.Write($"{sum1}");

            Console.WriteLine($"\n\nThis is the sum of the ints between 1-100 that are divisble by 3: ");
            int sum2 = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    sum2 += i;
            }
            Console.Write($"{sum2}");

            Console.WriteLine($"\n\nThis is the sum all of the primes between 1-100: ");
            int sum3 = 0;
            bool isPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum3 += i;
                }
                isPrime = true;
            }
            Console.Write($"{sum3}\n");

            bool success1 = Int32.TryParse(Console.ReadLine(), out int n);
            bool sucess2 = Int32.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine($"\n\nThis is the GCD of {n} and {m} : ");
            Console.Write(GCD(n, m));

            int GCD(int a, int b)
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }
                if (a == 0)
                    return b;
                else
                    return a;
            }
        }

    }
}
