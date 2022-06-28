using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class CountNumOfDigitsInString
    {
        static void Main(string[] args)
        {
            string s = "India22";
            char[] ch = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    count++;
                }

            }
            Console.WriteLine("no of digits" + count);

        }
    }
}
