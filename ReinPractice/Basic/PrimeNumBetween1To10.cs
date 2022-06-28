using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class PrimeNumBetween1To10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number1");
            int n1 = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("Enter the number2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Boolean prime = true;
            int i,j;

            for ( i = n1; i <= n2; i++)                  //for range of two numbers
            {
                for ( j = 2; j <= i; j++)                // for checking divisblility by 2 till number
                {
                    if (i % j == 0)
                        break;   
                }
                if (i == j)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
