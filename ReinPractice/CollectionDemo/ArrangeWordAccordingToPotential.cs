using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.CollectionDemo
{
    class ArrangeWordAccordingToPotential
    {
        public static int Potential(string word)
        {
            int p = 0;
            for (int i = 0; i < word.Length; i++)
            {
                p = p + (word[i]);
            }
            return p;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            string str = Console.ReadLine();
            str.ToUpper();
            string[] s = str.Split();

            //Selection sort.
            /* for(int i=0; i<s.Length; i++)
             {
                 for(int j=i+1; j<s.Length; j++)
                 {
                     if(Potential(s[i]) > Potential(s[j]))
                     {
                         string temp = s[i];
                         s[i] = s[j];
                         s[j] = temp;
                     }
                 }

             }*/
            //Bubble sort.

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1 - i; j++)
                {
                    if (Potential(s[j]) > Potential(s[j + 1]))
                    {
                        string temp = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = temp;
                    }
                }
            }
            foreach (var x in s)
            {
                Console.WriteLine(x);
            }
        }
    }
}
