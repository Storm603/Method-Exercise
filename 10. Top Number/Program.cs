using System;
using System.Globalization;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            TopNumberFinder(range);
        }

        static void TopNumberFinder(int range)
        {
            

            for (int i = 1; i < range; i++)
            {
                bool oddNum = false;
                bool dividerChecker = false;

                int digit = 0;
                int digitSum = 0;
                int currNum = 0;

                currNum = i;

                while (currNum > 0)
                {

                    digit = currNum % 10;
                    currNum /= 10;

                    digitSum += digit;

                    if (digit % 2 == 1)
                    {
                        oddNum = true;
                    }
                }

                if (digitSum % 8 == 0)
                {
                    dividerChecker = true;
                }

                if (dividerChecker == true && oddNum == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
