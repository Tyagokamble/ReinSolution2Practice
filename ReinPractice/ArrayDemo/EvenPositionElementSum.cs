using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
   class EvenPositionElementSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());      // for enter array size
            int sum = 0;
            int[] arr = new int[size];

            Console.WriteLine("enter the array");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   //for enter array element 
            }
            Console.WriteLine("///////////////////////////");
            for (int i = 0; i < arr.Length; i+=2)
            {
                sum = sum + arr[i]; 
            }
            Console.WriteLine(sum);
        }
    }
}
