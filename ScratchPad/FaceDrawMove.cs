// This example demonstrates the 
//     Console.CursorLeft and 
//     Console.CursorTop properties, and the
//     Console.SetCursorPosition and 
//     Console.Clear methods.
using System;

class Sample
{
    protected static int origRow;
    protected static int origCol;

    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
    //public static void Movement()
    //{
    //    int right = 0;
    //    int down = 0;
    //    while (true)
    //    {
    //        var key = Console.ReadKey().Key;
    //        switch (key)
    //        {
    //            case ConsoleKey.LeftArrow:
    //                right--;
    //                break;
    //            case ConsoleKey.UpArrow:
    //                down--;
    //                break;
    //            case ConsoleKey.RightArrow:
    //                right++;
    //                break;
    //            case ConsoleKey.DownArrow:
    //                down++;
    //                break;
               
    //        }

    //    }
    //}
    public static void Main()
    {
        // Clear the screen, then save the top and left coordinates.
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        int right = 0;
        int down = 0;
        // moves stuff?

        while (true)
        {

            // Draw the Face
            //WriteAt("/", 1, 0);
            WriteAt("/", 0 + right, 1 + down);
            WriteAt("|", 0 + right, 2 + down);
            WriteAt("|", 0 + right, 3 + down);
            WriteAt("\\", 0 + right, 4 + down);

            // Draw the bottom side, from left to right.
            WriteAt("_", 1 + right, 4 + down); // shortcut: WriteAt("---", 1, 4)
            WriteAt("_", 2 + right, 4 + down); // ...
            WriteAt("_", 3 + right, 4 + down); // ...
            WriteAt("_", 4 + right, 4 + down);
            WriteAt("_", 5 + right, 4 + down);

            // Draw the right side, from bottom to top.
            WriteAt("/", 6 + right, 4 + down);
            WriteAt("|", 6 + right, 3 + down);
            WriteAt("|", 6 + right, 2 + down);
            WriteAt("\\", 6 + right, 1 + down);

            // Draw the top side, from right to left.
            WriteAt("_", 5 + right, 0 + down); // shortcut: WriteAt("---", 1, 0)
            WriteAt("_", 4 + right, 0 + down); // ...
            WriteAt("_", 3 + right, 0 + down);
            WriteAt("_", 2 + right, 0 + down);

            //eyes
            WriteAt("I", 2 + right, 2 + down); // left eye
            WriteAt("I", 4 + right, 2 + down);// right eye
            //mouth
            WriteAt("\\", 2 + right, 3 + down); // left smirk
            WriteAt("/", 4 + right, 3 + down);// right smirk
            WriteAt("_", 3 + right, 3 + down);// mid smirk

                //
            //WriteAt("All done!", 0, 6);
        Console.WriteLine();


            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    right--;
                    break;
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    down--;
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    right++;
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    down++;
                    break;

            }

        }

    }
}
/*
This example produces the following results:

+---+
|   |
|   |
|   |
+---+

All done!

*/
