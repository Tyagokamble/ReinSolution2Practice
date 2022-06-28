using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class ColumnMaximumNumberElementInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");           //to take size from user i
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of an array");          //                        j
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[size, size1];

            Console.WriteLine("Enter the elements of an array");    //to take elements from user.
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());          
                }
            }
            for (int j = 0; j < a.GetLength(1); j++)
            {
                int max = a[0, j];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }

                }
                Console.WriteLine("The maximum numbers in column are: " + max);
            }
        }
    }
}
