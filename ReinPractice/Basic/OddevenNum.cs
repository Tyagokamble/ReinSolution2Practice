using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class OddevenNum
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even:" +num);
            }
            else
            {
                Console.WriteLine("numbwer is  odd:" +num);
            }
        }
    }
}
