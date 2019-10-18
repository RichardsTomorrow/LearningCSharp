using System;

namespace CylinderCalc
{
    class Program
    {
        static void CylinderVolume(double height, double radius)
        {
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine($"The volume of the cylinder is: {volume}");
        }

        static void CylinderSurfaceArea(double height, double radius)
        {
            double SurfArea = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine($"The surface area of the cylinder is: {SurfArea}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prepare to calculate cylinder things!");
            Console.WriteLine("Please enter height(h)"); // should grab and convert height
            string InputH = Console.ReadLine(); // input is always a string and must be converted
            double h = Convert.ToDouble(InputH);

            Console.WriteLine("Please enter radius(r)");// should grab and convert radius
            string InputR = Console.ReadLine();
            double r = Convert.ToDouble(InputR);

            double pi = 3.141592654; // dirty pi

            //volume
            //double Rsq = r * r;
            //double Vol = pi * Rsq * h;
            //Console.WriteLine("The volume of the cylinder is: " + Vol);
            CylinderVolume(h, r);

            //surface area
            //double SurfArea = 2 * pi * r * (r + h);
            //Console.WriteLine($"The surface area of the cylinder is: {SurfArea}");
            CylinderSurfaceArea(h, r);

            Console.ReadKey();// pauses debug mode after it has finished


        }
    }
}
