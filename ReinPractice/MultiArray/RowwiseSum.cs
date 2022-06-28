using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.MultiArray
{
    class RowwiseSum
    {
        static void Main(string[] args)
        {
            int[,]arr= { {1,2,3},
                         {4,5,6 },
                         {7,8,9 } };
            int sum = 0; 
            for(int i = 0; i < arr.GetLength(0); i++)            // loop to channge row
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = sum + arr[i, j];                     // sum of coulmn will takes place 
                }
                Console.WriteLine(string.Join(",",sum));
            }
        }
    }
}
