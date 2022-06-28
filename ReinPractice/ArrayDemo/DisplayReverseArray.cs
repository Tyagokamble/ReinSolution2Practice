using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class DisplayReverseArray                                                   //reverse array without changing actual array.
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44 };
            Console.WriteLine(string.Join(" ",a));                                      // display array method.
            Console.WriteLine("////////////////////////////");

            for(int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]+" ");                                             // after reversing array.
            }
            Console.WriteLine("                          ");
            Console.WriteLine("//////////////////////////");
            Console.Write(string.Join(" ",a));                                      //original array 
        }
    }
}
