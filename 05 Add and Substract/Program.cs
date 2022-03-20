using System;

namespace _05_Add_and_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int result = SumOfTwo(number1, number2);
            Console.WriteLine(SubtractFromThird(result, number3));
        }

        static int SumOfTwo(int number1, int number2)
        {
            return number1 + number2;
        }

        static int SubtractFromThird(int result, int number3)
        {
            return result - number3;
        }
    }
}
