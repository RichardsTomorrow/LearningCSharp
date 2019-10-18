using System;

namespace PosOrNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers and I will figure out the sign of their product");//greeting

            Console.Write("Please enter the first number: "); // should grab and convert Num1
            string Input1 = Console.ReadLine(); // input is always a string and must be converted
            int Num1 = Convert.ToInt32(Input1);

            Console.Write("Please enter the second number: "); // should grab and convert Num1
            string Input2 = Console.ReadLine(); // input is always a string and must be converted
            int Num2 = Convert.ToInt32(Input2);

            if((Num1 > 0 && Num2 > 0) || (Num1 < 0 && Num2 < 0)) // should catch sign matches
            {
                Console.WriteLine("This number should be positive");
            }
            else if ((Num1 < 0 && Num2 > 0) || (Num1 > 0 && Num2 < 0))
            {
                Console.WriteLine("This number should be negative");// should catch sign mismatches
            }
            else

            {
                Console.WriteLine("This number should be zero");// should catch tricky zeros
            }

            Console.ReadKey();
        }
    }
}
