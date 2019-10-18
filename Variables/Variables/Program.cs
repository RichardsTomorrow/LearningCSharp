using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            b = a;
            a = -3;
            string VarA = "Variable a is " + a;// I wanted to make it obvious in the console what variable is being shown
            Console.WriteLine(VarA);
            string VarB = "Variable b is " + b;
            Console.WriteLine(VarB);
            Console.ReadKey();
        }
    }
}
