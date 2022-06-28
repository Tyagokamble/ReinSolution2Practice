using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
   class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "I Like My Country India";
            string reverse = " ";
            for(int i = str.Length-1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
            
        }
    }
}
