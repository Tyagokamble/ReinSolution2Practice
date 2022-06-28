using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class MaxAndMinElementIntArray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 12, 4, 7 };
            int max =a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);

            Console.WriteLine(  "/////////");
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
               
            }
            Console.WriteLine(min);
        }
    }
}
