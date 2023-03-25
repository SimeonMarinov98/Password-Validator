using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLenghtEnought = IsPasswordEnoughLong(password);
            bool isPasswordAplhaNumeric = IsPasswordAlphaNumeric(password);
            bool isPasswordHaveEnoughDigit = IsPasswordHaveAtLeastTwoDigits(password);
            if (!isLenghtEnought)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordAplhaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordHaveEnoughDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if(isLenghtEnought && isPasswordAplhaNumeric && isPasswordHaveEnoughDigit)
            {
                Console.WriteLine("Password is valid");
            }


        }
        static bool IsPasswordEnoughLong(string password)
        {
            if(password.Length>=6 && password.Length<=10)
            {
                return true;
            }
            return false;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach  (char ch in password)
            {
                if(!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordHaveAtLeastTwoDigits(string password)
        {
            int digitCount = 0;
            foreach (char ch in password)
            {
                if(Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            if(digitCount>2)
            {
                return true;
            }
            return false;
        }
    }
}
