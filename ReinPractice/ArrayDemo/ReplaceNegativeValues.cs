using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ReplaceNegativeValues
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            Console.WriteLine(string.Join(" ", a));
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine("/////////////////////");
            Console.WriteLine(string.Join(" ", a));
          
            
        }
    }
}
