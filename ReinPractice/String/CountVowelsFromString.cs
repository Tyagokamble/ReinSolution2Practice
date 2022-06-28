using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class CountVowelsFromString
    {
        static void Main(string[] args)
        {
            string str = "India is My Country";
            char[] s = str.ToLower().ToCharArray();                 // as we have to count char so converted in char array.
            int count = 0;
           

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }

            }
                           Console.WriteLine("no of vowels present"+ count);
         
        }
    }
}
