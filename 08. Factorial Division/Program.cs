using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            long resultOne = FactorialCalculationNumbers(numberOne);
            long resultTwo = FactorialCalculationNumbers(numberTwo);

            double result = (resultOne * 1.0/ resultTwo);

            Console.WriteLine($"{result:f2}");
        }

        static long FactorialCalculationNumbers(int number)
        {

            long digit = 1;
            if (number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    digit = digit * i;
                }
            }

            return digit;
        }
    }
}