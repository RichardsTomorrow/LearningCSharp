using System;

namespace StarPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int row = 0; row < 5; row++)
            {
                for (int space = row; space < 5; space++) 
                {
                    Console.Write(" "); //replace " " with "\" for easier visualization      
                }
                for (int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
            Console.WriteLine("All hail the pyramid!!!");
            Console.ReadKey();
        }
    }
}
