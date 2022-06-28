using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class ForLoopTableOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to print table:");
            int num = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num*i);
            }
        }
    }
}
