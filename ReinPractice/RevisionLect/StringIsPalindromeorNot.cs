using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class StringIsPalindromeorNot
    {
        static void Main(string[] args)
        {
            string str = "radar";
            string rev = " ";

            for (int i = str.Length - 1; i >= 0; i--)
            {

                rev = rev + str[i];

            }

            if (str == rev)
            {
                Console.WriteLine(" string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
