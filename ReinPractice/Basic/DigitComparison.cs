using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class DigitComparison
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num<=0 && num <= 9)
            {
                Console.WriteLine("Number is single digit:"+num);
            }
            else
            {
                Console.WriteLine("Number is double digit"+num);
            }
        }
    }
}
