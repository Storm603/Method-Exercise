using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToLower();


            Console.WriteLine(VowelCounter(input));

        }

        static int VowelCounter(string input)
        {
            int counter = 0;

            foreach (char vowel in input)
            {
                if ("aeiou".Contains(vowel))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
