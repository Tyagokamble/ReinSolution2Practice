﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class NumCompareTernary
    {
        static void Main(string[] args)
        {
            int num1, num2,result;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            result= num1>num2 ? num1:num2;
            Console.WriteLine( "result is "+result);
        }
    }
}
