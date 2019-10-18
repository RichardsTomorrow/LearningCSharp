using System;

namespace VariableMedley
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "This is a string";
            Console.WriteLine(phrase);

            bool truth = true;
            Console.WriteLine("This is a boolean " + truth);

            decimal money = 60.00M;
            Console.WriteLine("I have " + money + " decimal dollars");

            double hat = 5.5;
            Console.WriteLine("This double is " + hat);

            float pennywise = 3.1415926f;
            Console.WriteLine("We all float down here " + pennywise);

            char letter = 'R';
            Console.WriteLine("My name starts with " + letter);

            long cat = 9L;
            Console.WriteLine("The cat is " + cat + " feet long.");

            ulong tea = 4UL;
            Console.WriteLine("I drank " + tea + " ulong teas");

            int neg = -7;
            Console.WriteLine("This integer can be " + neg);

            uint pos = 7;
            Console.WriteLine("This uinteger must be positive: " + pos);

            short dog = -4;
            Console.WriteLine("short: " + dog);

            ushort bird = 4;
            Console.WriteLine("ushort: " + bird);

            byte one = 1;
            Console.WriteLine(one);

            sbyte negone = -1;
            Console.WriteLine(negone);

            Console.ReadKey();
        }
    }
}
