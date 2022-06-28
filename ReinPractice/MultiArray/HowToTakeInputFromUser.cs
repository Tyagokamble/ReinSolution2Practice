using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class HowToTakeInputFromUser
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            

            Console.WriteLine("Enter the elements in array a.");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
                Console.WriteLine("The elements of the first array is :");
            }
        }
    }
}
