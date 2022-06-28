using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");            // prime nunmber is divisible only by 1 and by itself
            int n = Convert.ToInt32(Console.ReadLine());
            Boolean prime = true;

           for(int i = 2;i< n; i++)                         // for checking is it divisible by values between number.
            {
               if( n%i==0)
                {
                    prime = false;
                    Console.WriteLine("number is not prime");
                    break;
                }
            
            }
                    Console.WriteLine("number is prime");
            

        }
    }
}
