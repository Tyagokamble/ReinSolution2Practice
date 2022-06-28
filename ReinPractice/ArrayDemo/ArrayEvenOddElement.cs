using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ArrayEvenOddElement
    {
        static void Main(string[] args)
        {
          int[] a = { 4, 5, 1, 7, 6, 8, 9 };


        for(int i = 0; i < a.Length; i++)
            {
                if (a[i]%2==0)
             { 
                Console.WriteLine(a[i]);                      //even element of array.
             }
           }
            Console.WriteLine("///////////////////");
         
        for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                   Console.WriteLine(a[i]);                 //odd element of array.
                }
            }
        }
    }
}
