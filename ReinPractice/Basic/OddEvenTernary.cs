using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class OddEvenTernary
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            string result = (num1 % 2 == 0) ? "even" : "odd";
            Console.WriteLine("number is"+ result);

        }
       
    }
}
