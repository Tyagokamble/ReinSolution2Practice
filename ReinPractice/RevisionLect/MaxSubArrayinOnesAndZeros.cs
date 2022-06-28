using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class MaxSubArrayinOnesAndZeros
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 0, 1, 0, 1, 1, 0, 0 };
            int ones = 0;
            int zeros = 0;
            foreach(int d in a)
            {
                Console.WriteLine(d+" ");
            }

            int max = 0;

            for (int i = 1; i < a.Length; i++)
            {
                zeros = 0;ones = 0;
                for(int j = i; j < a.Length; j++)
                {
                    if (a[j] == 0)
                        zeros++;
                    else
                        ones++;
                    if (zeros == ones)
                    {
                        if (max < j - i + 1) ;
                        max = j - i + 1;
                    }


                   
                }
            }
            Console.WriteLine(max);
        }
    }
}
