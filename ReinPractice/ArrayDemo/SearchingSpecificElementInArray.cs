using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.ArrayDemo
{
    class SearchingSpecificElementInArray
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 3, 9, 2 };
            Console.WriteLine("Enter an element for searching.");



            int num = int.Parse(Console.ReadLine());
            bool IsVisited = false;



            for (int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    IsVisited = true;
                    break;
                }
            }
            if (IsVisited)
            {
                Console.WriteLine("The number is present in an array");
            }
            else
            {
                Console.WriteLine("The number is not preasent in an array");
            }
        }
    }
}
