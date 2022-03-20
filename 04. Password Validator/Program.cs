using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();


            bool checkChar = CharacterCheck(password);
            bool letterDigitCheck = LetterDigitCheck(password);
            bool digitChecker = DigitChecker(password);

            if (!checkChar)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!letterDigitCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digitChecker)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (checkChar && letterDigitCheck && digitChecker)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharacterCheck(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool LetterDigitCheck(string password)
        {
            bool checker = true;

            foreach (char digit in password)
            {
                checker = char.IsLetterOrDigit(digit);
                if (!checker)
                {
                    return false;
                }
            }

            return checker;
        }

        static bool DigitChecker(string password)
        {
            int counter = 0;
            foreach (char digit in password)
            {
                if (digit >= 48 && digit <= 57)
                {
                    counter++;
                    if (counter == 2)
                    {
                        return true;
                    }
                }
            }
            

            return false;
        }
    }
}
