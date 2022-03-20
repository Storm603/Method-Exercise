using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            PalindromeChecker(input);
        }

        static void PalindromeChecker(string input)
        {
            while (input != "END")
            {
                string reversedInput = String.Empty;
                int number = int.Parse(input);

                for (int i = 0; i < input.Length; i++)
                {
                    int reversed = number % 10;
                    number /= 10;
                    reversedInput += reversed.ToString();
                }

                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }
    }
}
