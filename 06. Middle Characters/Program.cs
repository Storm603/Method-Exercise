using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(StringDivider(input));
        }

        static string StringDivider(string input)
        {
            string digitS = String.Empty;
            
            if (input.Length % 2 == 1)
            {
                int length = input.Length / 2;
                char digit = input[length];
                digitS = digit.ToString();
            }

            else if (input.Length % 2 == 0)
            {
                int length = input.Length / 2;
                char digit = input[length - 1];
                char sdigit = input[length];
                digitS = digit.ToString() + sdigit.ToString();
            }

            return digitS;
        }
    }
}
