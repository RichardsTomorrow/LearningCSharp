using System;

namespace ColorBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to the world of COLOR BALLLLLLLL!");
            Ball bigRed = new Ball(10, new Color(255, 0, 0));
            Ball smallGreen = new Ball(2, new Color(0, 255, 0));
            Ball medBlue = new Ball(5, new Color(0, 0, 255));
            // tests if throw works
            bigRed.Throw(2);
            bigRed.Throw(3);
            bigRed.Throw(1);
            Console.WriteLine($"The red ball was thrown {bigRed.GetThrows()} times\n");

            // tests the popping mechanic
            smallGreen.Throw(3);
            Console.WriteLine($"The green ball was thrown {smallGreen.GetThrows()} times");
            medBlue.Throw(4);
            smallGreen.Pop();
            Console.WriteLine($"The green ball was popped");
            Console.WriteLine($"The blue ball was thrown {medBlue.GetThrows()} times\n");

            // tests if a popped ball can be thrown
            Console.WriteLine($"The green ball was thrown {smallGreen.GetThrows()} times");
            smallGreen.Throw(1);
            Console.WriteLine($"The green ball was thrown {smallGreen.GetThrows()} times");
        }
    }
}
