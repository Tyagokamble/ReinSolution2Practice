using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class OddPositionElementSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int sum = 0;
        for(int i = 0; i < a.Length; i++)
            {
               a[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("//////////////");
            for (int i = 0; i < a.Length; i++)
            {
               
                if (i % 2 != 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
