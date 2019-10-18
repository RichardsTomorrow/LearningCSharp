using System;
using System.Collections.Generic;
using System.Text;

namespace ListONums
{
    class ListMaker
    {
        //private int[] holder;

        public static void Lister(int[] holder)
        {
            int[] x = holder;

            foreach (int number in holder)
            {
                Console.Write($"{number}, ");
            }

        }
    }
}
