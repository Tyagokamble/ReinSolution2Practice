using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ZeroAndNonZeroSorting
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 2, 0, 4, 0, 6, 0, 8 };

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i+1; j < a.Length; j++)
                {
                    if(a[i]==0 && a[j] != 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(",",a));
        }
    }
}
