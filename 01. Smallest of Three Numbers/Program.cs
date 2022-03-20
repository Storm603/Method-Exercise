﻿using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int result = SmallestNumberFounder(numOne, numTwo, numThree);
            Console.WriteLine(result);
        }

        static int SmallestNumberFounder(int numOne, int numTwo, int numThree)
        {
            return Math.Min(numOne, Math.Min(numTwo, numThree));
        }
    }
}
