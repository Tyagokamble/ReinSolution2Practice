using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class CountOfElementInArray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 3, 9, 2, 5 };

            Console.WriteLine("Enter an element for searching.");

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Number of counts in an array.");
            Console.WriteLine(string.Join(",", count));
            if (count == 0)
            {
                Console.WriteLine("The number is not present in an array");
            }
            else
            {
                Console.WriteLine("The number is present in an array");
            }
        }
    }
}
