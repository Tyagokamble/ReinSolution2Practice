using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.Test1Assignment
{
    class Test1Num1To100ExceptsDivBy5or10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%5==0 && i % 10 == 0)
                {
                    Console.WriteLine("number is divisible by 5 or 10");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
       
    }
}
