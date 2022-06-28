using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class CommonFactorBetweenTwoNum
    {
        
        
        static void Main(string[] args)
        {
      
                 int a = 18;
                 int b = 6;
                 int count = 0;

                 for (int i = 1; i <= a && i <= b; i++)
                 {
                     if (a % i == 0 && b % i == 0)
                     {
                         count++;
                         Console.WriteLine(i);
                     }

                 }
                 if (count > 0)
                 {
                     Console.WriteLine(count );
                 }



        }
    }
}
