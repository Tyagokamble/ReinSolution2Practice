using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class WordReverse
    {
        static void Main(string[] args)
        {
            string str = "India is the best";
            string[] mywords = str.Split(" ");

            string reverseString = " ";

            for (int i = 0; i < mywords.Length; i++)
            {
                string s = mywords[i];
                string reverseMyword = " ";

                for (int j = s.Length - 1; j >= 0; j--)
                {
                    reverseMyword = reverseMyword + s[j];
                }
                reverseString = reverseString + s;
                Console.Write(reverseMyword);
            }
            Console.WriteLine("  ");


            Console.WriteLine(reverseString);
        }
    }
}
