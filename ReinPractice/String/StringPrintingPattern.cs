using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class StringPrintingPattern
    {
        static void Main(string[] args)
        {
            string str = "India is my country";

            string []s = str.Split();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
