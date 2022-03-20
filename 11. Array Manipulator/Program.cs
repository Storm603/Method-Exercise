using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) > input.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    int[] exchanged = new int[input.Length];
                    int beginning = int.Parse(command[1]);
                    beginning++;

                    exchanged = ExchangingIndexes(beginning, input, command, exchanged);
                    input = exchanged;
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even" || command[1] == "odd")
                    {
                        MaxMinEvenOddElementFinder(input, command);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even" || command[1] == "odd")
                    {
                        MaxMinEvenOddElementFinder(input, command);
                    }
                }
                else if (command[0] == "first" || command[0] == "last")
                {
                    if (command[2] == "even" || command[2] == "odd")
                    {
                        EvenOddElementReturner(command, input);
                    }
                }
                else if (command[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", input)}]");
                    return;
                }
            }
        }

        static int[] ExchangingIndexes(int beginning, int[] input, string[] command, int[] exchanged)
        {
            int counter = 0;

            for (int i = beginning; i < input.Length; i++)
            {
                exchanged[0 + counter] = input[i];
                counter++;
            }

            int range = counter;

            for (int i = 0; i < input.Length - range; i++)
            {
                exchanged[counter] = input[i];
                counter++;
            }

            return exchanged;

        }

        static void MaxMinEvenOddElementFinder(int[] input, string[] command)
        {
            int bestNum = int.MinValue;
            int bestIndex = 0;
            bool result = false;
            if (command[0] == "min") bestNum = int.MaxValue;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currNum = input[i];
                if (command[0] == "max")
                {
                    if (input[i] % 2 == 0 && input[i] > bestNum && command[1] == "even")
                    {
                        bestNum = input[i];
                        bestIndex = i;
                        result = true;
                    }
                    else if (input[i] % 2 == 1 && input[i] > bestNum && command[1] == "odd")
                    {
                        bestNum = input[i];
                        bestIndex = i;
                        result = true;
                    }
                }
                else if (command[0] == "min")
                {
                    bestNum = 1001;

                    if (input[i] % 2 == 0 && input[i] < bestNum && command[1] == "even")
                    {
                        bestNum = input[i];
                        bestIndex = i;
                        result = true;
                    }
                    else if (input[i] % 2 == 1 && input[i] < bestNum && command[1] == "odd")
                    {
                        bestNum = input[i];
                        bestIndex = i;
                        result = true;
                    }
                }
            }

            if (command[0] == "max")
            {
                if (result == true)
                {
                    Console.WriteLine(bestIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }

            else
            {
                if (result == true)
                {
                    Console.WriteLine(bestIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void EvenOddElementReturner(string[] command, int[] input)
        {
            if (int.Parse(command[1]) > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> list = new List<int>();

            int counter = 0;

            if (command[0] == "first")
            {
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (counter >= int.Parse(command[1]))
                    {
                        break;
                    }
                    if (command[2] == "even" && input[i] % 2 == 0)
                    {
                        list.Add(input[i]);
                        counter++;
                    }
                    else if (command[2] == "odd" && input[i] % 2 == 1 || input[i] % 2 == -1)
                    {
                        list.Add(input[i]);
                        counter++;
                    }
                }
            }

            if (command[0] == "last")
            {

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (counter >= int.Parse(command[1]))
                    {
                        break;
                    }
                    if (command[2] == "even" && input[i] % 2 == 0)
                    {
                        list.Add(input[i]);
                        counter++;
                    }
                    else if (command[2] == "odd" && input[i] % 2 == 1 || input[i] % 2 == -1)
                    {
                        list.Add(input[i]);
                        counter++;
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", list)}]");
            }
        }
    }
}
