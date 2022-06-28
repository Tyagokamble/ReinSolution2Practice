using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {  
            
            Console.WriteLine("enter the number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (; Num > 0; Num = Num / 10)
            {
                int r = Num % 10;
                sum = sum + r;
              }
            Console.WriteLine(sum);
        }
    }
}
