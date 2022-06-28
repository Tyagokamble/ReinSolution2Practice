using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.Test1Assignment
{
    class Test4SpyNum
    {
        static void Main(string[] args)
        {
            int rem, product = 1, sum = 0;
            Console.WriteLine("enter the number :");
            int Num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= Num; i++)
            {
                rem = Num % 10;
                sum = sum + rem;
                product = product * rem;
                Num = Num / 10;
                if (product == sum)
                {
                    Console.WriteLine("number is Spy Number");
                }
                else
                {
                    Console.WriteLine("Number is not Spy Num Number");
                }
            }
        }
    }
}
