using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class FrequencyOfWordInString
    {
        static void Main(string[] args)
        {
            string str = "I love India, India is my country";
            string[] s = str.Split();
            Console.WriteLine("enter the word");
            string occurance = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (occurance == s[i])
                {
                    count++;
                }

            }
            Console.WriteLine("Occurance = " + count);
        }
    }
}
