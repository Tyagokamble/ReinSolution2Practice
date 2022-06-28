using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class AdditionOfSeriesInParticularManner
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };                    //1+2=3,3+4=7,5+6=11,7+8=15;
            int sum = 0;
            for(int i = 0; i < a.Length; i=i+2)
            {
               sum= a[i] +a[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
}
