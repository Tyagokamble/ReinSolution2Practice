using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class Krishnamurtinumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            num = temp;

            if (num == sum)
            {
                Console.WriteLine("krishnamurti number");
            }
            else
            {
                Console.WriteLine("not krishnamurti number");
            }
        }

    }
}

