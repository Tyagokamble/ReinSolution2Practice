using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class SortArrayInAscendingOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];

            Console.WriteLine("enter elements of array");
            for(int i = 0; i < a.Length; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            for(int i = 0; i < a.Length; i++)             //1,5,3,6
            {
               for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }
        }
    }
}
