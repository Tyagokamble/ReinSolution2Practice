using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class PositiveNegativeTernary
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());


            string result = num1 > 0? "positive" : num1<0?"negative":"zero";
            Console.WriteLine(result);
        }
    }
}
