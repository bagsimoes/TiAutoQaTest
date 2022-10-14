using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String stringToRead = "";

            Console.WriteLine("Introduce a word to check if it is a palindrome");

            stringToRead= Console.ReadLine();

            bool palindrome = IsPalindrome(stringToRead);
            if (palindrome)
            {
                Console.WriteLine("The Word is palindrome");
            }
            else Console.WriteLine("The Word is NOT palindrome");
        }

        public static bool IsPalindrome(string value)
        {
            int i = 0;
            int j = value.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;                 
                }
                char a = value[i];
                char b = value[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
    }
}
