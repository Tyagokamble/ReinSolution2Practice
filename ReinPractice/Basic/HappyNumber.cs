using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class HappyNumber
    {
        static void Main(string[] args)
        {
            int rem=0;
            Console.WriteLine("enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean happy = true;
          
                rem = num % 10;
                if (rem % 2 == 0)
                {
                    Console.WriteLine("Happy number");
                }
                else { Console.WriteLine("Not Happy Number"); }
            }
        }
    
}
