using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class DisariumNumUsingPowFunction
    {
        static void Main(string[] args)
        {
            int sum = 0, rem = 0;
            int count = 0;
            int n = 15;
            int temp = n;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);

            n = temp;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (int)Math.Pow(rem, count);
                count--;
                n=n / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("number is disarium");
            }
            else
            {
                Console.WriteLine("number is not disarium");
            }
        }
    }
}
