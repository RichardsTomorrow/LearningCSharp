using System;

namespace asterixMover
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = x/2;
            char symbol = '*';

            while (true)
            {
                Console.CursorVisible = false;
                ConsoleKeyInfo press = Console.ReadKey();
                switch(press.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (x == 119)
                        {
                            Console.Beep();
                            break;
                        }
                        x += 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x == 0)
                        {
                            Console.Beep();

                            break;
                        }
                        x -= 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;
                    case ConsoleKey.UpArrow:
                        if (y == 0) 
                        {
                            Console.Beep();
                            break;
                        }
                        y -= 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;
                    case ConsoleKey.DownArrow:
                        if (y == 59)
                        {
                            Console.Beep();
                            break;
                        }
                        y += 1;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write(symbol);
                        break;
                }
            }
        }
    }
}
