using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int multiplication = 1;
            while (num > 0) 
            { 
                int r = num % 10;
                sum = sum + r;
                multiplication = multiplication * r;
                num = num / 10;
            }
            if (sum == multiplication)
            {
                Console.WriteLine("The number is a spy number.");
            }
            else
            {
                Console.WriteLine("It is not a spy number.");
            }
            Console.WriteLine(sum);
            Console.WriteLine(multiplication);
        }
    }
}
