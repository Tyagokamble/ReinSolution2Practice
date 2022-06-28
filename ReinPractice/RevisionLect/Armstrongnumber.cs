using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
    class Armstrongnumber
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
             
            while (num > 0)
            {
               int r = num % 10;
                sum = sum + r * r * r;
                num = num / 10;
            }
            num = temp;
            if(num == sum)
            {
                Console.WriteLine("Number is Armstrong number"+num);
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong number" +num);
            }

        }
    }
}
