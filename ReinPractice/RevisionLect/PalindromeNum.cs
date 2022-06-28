using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class PalindromeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            for (; num > 0; num = num / 10)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
            }
            if (num == reverse)
            {
                Console.WriteLine("The number is palindrome number.");
            }
            else
            {
                Console.WriteLine("The number is not palindrome.");
            }
            Console.WriteLine(reverse);
        }
    }
}
