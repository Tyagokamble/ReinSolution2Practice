using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the exponent:");
            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;
            while (i <= expo)
            {
                power = power * num;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
