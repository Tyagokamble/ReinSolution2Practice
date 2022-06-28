using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class ThreeNumComparison
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1>num3)
            {
              if (num2 > num3)
                {
                    Console.WriteLine("num1>num2>num3"+num1+num2+num3);
                }
                else
                {
                    Console.WriteLine("Num1 is greater than num2 and num3" );
                }
            }
        }
    }
}
