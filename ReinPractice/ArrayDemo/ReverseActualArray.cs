using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class ReverseActualArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60 };
            int j = arr.Length - 1;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                  arr[i] = arr[j];
                  arr[j] = temp;
                  j--;

                
            }
            Console.WriteLine(string.Join(" ",arr));
          for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
           
        }
    }
}
