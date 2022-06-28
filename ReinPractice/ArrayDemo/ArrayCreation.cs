using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ArrayCreation
   {
        static void Main(string[] args)
        {
            int[] marks = { 34, 12, 67, 3, 4 };   //first way to declare array.
           int[] a = new int[4];               //declaring size of element and hardcoding elements
          /*  a[0] = 34;                            
            a[1] = 2;
            a[3] = 89;
            a[4] = 14;*/

            Console.WriteLine("Enter Array Length");

        for(int i = 0; i <= a.Length; i++)            //for taking i/p from user 
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
                           
            }
        for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
       



    }
}
