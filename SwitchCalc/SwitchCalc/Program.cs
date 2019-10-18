using System;

namespace SwitchCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepare to calculate simple things!");
            Console.Write("Please enter your first number: "); // should grab and convert Num1
            string Input1 = Console.ReadLine(); 
            double Num1 = Convert.ToDouble(Input1);

            Console.Write("Please enter your operator. Either +, -, *, /, %, or ^ : "); // should grab and convert the operator
            string InputOper = Console.ReadLine();
            char Operator = Convert.ToChar(InputOper);

            Console.Write("Please enter your second number: "); // should grab and convert Num2
            string Input2 = Console.ReadLine();
            double Num2 = Convert.ToDouble(Input2);

            switch (Operator)
            {
                case '+':
                    double resultAdd = Num1 + Num2;
                    Console.WriteLine($"{Num1} + {Num2} = {resultAdd}");
                    break;
                case '-':
                    double resultSub = Num1 - Num2;
                    Console.WriteLine($"{Num1} - {Num2} = {resultSub}");
                    break;
                case '*':
                    double resultMult = Num1 * Num2;
                    Console.WriteLine($"{Num1} * {Num2} = {resultMult}");
                    break;
                case '/':
                    double resultDiv = Num1 / Num2;
                    Console.WriteLine($"{Num1} / {Num2} = {resultDiv}");
                    break;
                case '%':
                    double resultMod = Num1 % Num2;
                    Console.WriteLine($"{Num1} % {Num2} = {resultMod}");
                    break;
                case '^':
                    double resultPow = Math.Pow(Num1, Num2);
                    Console.WriteLine($"{Num1} to the power of {Num2} is {resultPow}.");
                    break;
                default:
                    Console.WriteLine("Hint! This is but a simple calculator. You can only try those five operators listed above");
                    break;
            }

            Console.ReadKey();
        }
    }
}
