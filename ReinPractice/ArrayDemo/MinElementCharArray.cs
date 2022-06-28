using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class MinElementCharArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 'i', 'o', 'u','c' };
            char min = ch[0];
         for(int i = 0; i < ch.Length; i++)
            {
                if (min > ch[i])
                {
                    min = ch[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
