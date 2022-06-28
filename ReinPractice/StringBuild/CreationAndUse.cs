using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.StringBuild
{
    class CreationAndUse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            StringBuilder sb = new StringBuilder(s);
            sb.Append(s);                              // append is used to add 
            Console.WriteLine(s);




        }
    }
}
