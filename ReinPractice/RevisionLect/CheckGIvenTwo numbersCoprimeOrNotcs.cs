using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class CheckGIvenTwo_numbersCoprimeOrNotcs
    {
        static void Main(string[] args)
        {
            int a = 10;
            int count = 0;
            for (int i = 1; i <=a; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                   
                    if(a%j==0 && i%j == 0) 
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"Given number is pair of co prime number{i} {a}");
                    Console.WriteLine("the number coprime number"+i+a);
                }
            }
        }
    }
}
