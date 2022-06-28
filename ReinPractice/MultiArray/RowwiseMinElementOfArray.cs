using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class RowwiseMinElementOfArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            

            for(int i = 0; i < a.GetLength(0); i++)
            {
                int min = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
