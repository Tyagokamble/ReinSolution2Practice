using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class AnagramString                                                 //silent==listen same chars 
    {
        static void Main(string[] args)
        { 
         
            
             string s1 = Console.ReadLine();
             string s2 = Console.ReadLine();

             string ch1 = s1.ToLower();
             string ch2 = s2.ToLower();

             char[] ch11 = ch1.ToCharArray();
             char[] ch22 = ch2.ToCharArray();

           Array.Sort(ch11);
           Array.Sort(ch22);
           

            Console.WriteLine(string.Join(",", ch11));
            Console.WriteLine(string.Join(",",ch22));

            string st1 = new string(ch11);
            string st2 = new string(ch22);

            if (st1.CompareTo(st2)==0) 
            {
                Console.WriteLine("both string are anagram");
            }
            else 
            {
                Console.WriteLine("string are not anagram");
            }

        }

    }
}
