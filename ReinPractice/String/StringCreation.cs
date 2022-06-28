using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class StringCreation
    {
        static void Main(string[] args)
        {
            string s = "Hello C#";                                     //using keyword
            string str = "wlecomeC#";                                  //using system.strings
            string S2 = new string("My C#");                           // using new keyword

            char[] ch = { 'I', 'n', 'd', 'i', 'a' };
            string s3 = new string(ch);                               //convert char arraay to string
             
        }
    }
}
