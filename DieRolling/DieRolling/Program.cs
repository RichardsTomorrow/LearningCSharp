using System;

namespace DieRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validSides = false;
            int sides = 0;
            //asks and gets how many sides the die needs
            while (!validSides) //thanks to Radiah for this validation technique
            {
                Console.Write($"How many sides would you like on your die?\n");
                validSides = Int32.TryParse(Console.ReadLine(), out sides);

                if(sides < 0)
                {
                    validSides = false;
                }


            }
            Console.WriteLine($"You selected a {sides}-sided die.");

            bool validRolls = false;
            int rolls = 0;
            //asks and gets how many rolls the die needs
            while (!validRolls) //thanks to Radiah for this validation technique
            {
                Console.Write($"How many times would you like to roll your die?\n");
                validRolls = Int32.TryParse(Console.ReadLine(), out rolls);

                if (rolls < 0)
                {
                    validRolls = false;
                }


            }
            Console.WriteLine($"You will roll your {sides}-sided die {rolls} times");
            int sum = 0;
            for(int i =0; i < rolls; i++)
            {
                Random random = new Random();
                int dieRoll = random.Next(sides) + 1;
                Console.WriteLine($"Roll {i + 1} was {dieRoll}");
                sum += dieRoll;
            }
            Console.WriteLine($"The sum of your rolls was {sum}");
            Console.WriteLine("May your rolls be ever natural!");
        }
    }
}
