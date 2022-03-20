using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());


            CharInrange(one, two);
        }

        static void CharInrange(char one, char two)
        {
            if (one > two)
            {
                char temp1 = one;
                one = two;
                two = temp1;
            }

            one++;
            for (char i = one; i < two; i++)
            {
                Console.Write(i.ToString() + " ");
            }
        }
    }
}
