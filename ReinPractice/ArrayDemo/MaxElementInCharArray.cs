using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class MaxElementInCharArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'c', 'r', 'e' };
            char max = ch[0];                      // create variable name max of char type and assign it with 0 index of array.

        for(int i = 0; i < ch.Length; i++)
            {
                if (max < ch[i])
                {
                    max = ch[i];
                }
            }
            Console.WriteLine(max);
        }

    }
}
