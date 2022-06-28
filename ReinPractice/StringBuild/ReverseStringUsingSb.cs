using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.StringBuild
{
    class ReverseStringUsingSb
    {
        static void Main(string[] args)
        {

            string str = "nitin";
            string rev = "";

         //   StringBuilder sb = new StringBuilder(str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                //     sb.Append(sb[i]);
                //   Console.Write(sb[i]);
                rev = rev + str[i];

            }
          //  Console.WriteLine("   ");
         //   string str2 = sb.ToString();
            if (str ==rev)
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
