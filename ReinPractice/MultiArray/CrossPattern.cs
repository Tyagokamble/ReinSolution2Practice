using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class CrossPattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j || j == a.GetLength(1) - 1 - i)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                        Console.WriteLine(" ");
            }
        }
    }
}
