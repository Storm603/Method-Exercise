﻿using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            MatrixCreator(input);
        }

        static void MatrixCreator(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
