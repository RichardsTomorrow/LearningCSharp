using System;

namespace LeibnizPi
{



    class Program
    {
        static void Main(string[] args)
        {
            double delta = 0.00000000000000000000001;
            double pi = 0;
            int count = 0;
            for (int i = 1; true; i += 4)
            {
                count++;
                double prevPi = pi;
                pi += 1.0 / i - 1.0 / (i + 2);
                if (Math.Abs(pi - prevPi) < delta) break;

            }
            pi = 4 * pi;
            Console.WriteLine(count);
            Console.WriteLine(pi);
        }
    }
}

