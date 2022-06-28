using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class FactUsingRecursion
    {
        static int factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return (n * factorial(n - 1));
            }
        }
        static void Main(string[] args)
        {
            int ans = factorial(4);
            Console.WriteLine(4);
                
        }
    }
}
