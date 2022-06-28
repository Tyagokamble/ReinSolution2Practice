using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class EquilateralTriangePattern
    {
        static void Main(string[] args)
        {
            int[,] n = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 6, 4, 7, 8, }, { 1, 3, 5, 6 } };

            for (int i = 0; i <= n.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= n.GetUpperBound(1); j++)
                {
                    if (j == 0 || i == j || i == n.GetUpperBound(0))
                    {
                        Console.Write(n[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("////////////////////////////////////////////////////////////////////");


            int[,] m = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 6, 4, 7, 8, }, { 1, 3, 5, 6 } };

            for (int i = 0; i <= m.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= m.GetUpperBound(1); j++)
                {
                    if (i == 0 || i == j || j == m.GetUpperBound(1))
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
