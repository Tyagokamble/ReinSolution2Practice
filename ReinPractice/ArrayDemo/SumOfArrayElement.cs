using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class SumOfArrayElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];
            int sum=0;
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);

        }
    }
}
