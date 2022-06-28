using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class DiffrenceBetweenCompareToAndEqualsTo
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 ="hello";
            string s3 = new string("Hello");

            Console.WriteLine(s1==s2);
            Console.WriteLine(s1==s3);

            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));

            Console.WriteLine(s1.CompareTo(s2));     //1
            Console.WriteLine(s1.CompareTo(s3));     //0
            Console.WriteLine(s2.CompareTo(s3));    //-1
                                                             // for doing interpolation we need to take dollar char $
            string msg = " Welcome TO India ";
            string mymsg = "Hello{msg}";
            Console.WriteLine(mymsg);

            char[] ch = msg.ToCharArray();
            Console.WriteLine(string.Join(" ",ch));
            Console.WriteLine(ch);

            Console.WriteLine(msg.ToLower());
            string newmsg = msg.ToLower();
           
            Console.WriteLine(newmsg);

            string []splitword = msg.Split(" ");

            foreach(string st in splitword)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(string.Join("",msg));
            Console.WriteLine(msg.Trim());
            Console.WriteLine(msg.TrimStart());
            Console.WriteLine(msg.Replace('W','M'));









        }
    }
}
