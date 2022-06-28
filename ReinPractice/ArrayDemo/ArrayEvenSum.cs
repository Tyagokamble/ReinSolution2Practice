using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ArrayEvenSum
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter size of array");
                int size = Convert.ToInt32(Console.ReadLine( ));
              
                int[] a = new int[size];
                int sum = 0;
                Console.WriteLine("enter element of array");

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("/////////////");

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        sum = sum + a[i];
                    }
                    Console.WriteLine(sum);
                }
                
            }
        }
    }
}
