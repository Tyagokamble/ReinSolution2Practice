using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class TwoDArrayAddition
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];

            int[,] b = new int[2, 2];
            int[,] result = new int[2, 2];


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("////////////////////");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
            }
            Console.WriteLine("///////////////");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
            Console.WriteLine("////////////////////");
            }
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + b[i, j]);
                }
            }
        }
    }
}


