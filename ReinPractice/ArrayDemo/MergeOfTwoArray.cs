using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class MergeOfTwoArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[ a.Length+ b.Length ];

            int k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                
            }
            

           for(int j = 0; j < b.Length; j++) 
            {
                c[k] = b[j];
                k++;
            }
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}