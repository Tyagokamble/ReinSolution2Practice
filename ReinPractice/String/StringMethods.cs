using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string str = "India Is My Country";
            int l = str.Length;
            Console.WriteLine(l);
            Console.WriteLine(str.Length);
            string str2 = str.Substring(6);                  //substring (intial position,final position)
            string str3 = str.Substring(0,6);
            Console.WriteLine(str2);

            Console.WriteLine("first index string str"+ str.IndexOf('i'));
            Console.WriteLine("first index of string str" + str.LastIndexOf('I') );

            string merge = str + str2;
            Console.WriteLine(merge);

            string joinString = string.Concat(str, "", str2);
            Console.WriteLine(joinString);
        }
    }
}
