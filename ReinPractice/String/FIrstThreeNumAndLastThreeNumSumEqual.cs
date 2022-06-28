using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.String
{
    class FIrstThreeNumAndLastThreeNumSumEqual
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with numbers");
            string str = Console.ReadLine();
            int i;
            int sum = 0;
            int sum1 = 0;

            for (i = 0; i < 3; i++)
            {
                 if (str[i] >= '0' && str[i] <= '9')
                 {

                int p = int.Parse(str[i].ToString());
                
                    sum = sum + p;
               }
            }
            for (i = str.Length - 1; i > str.Length - 4; i--)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                   int q = int.Parse(str[i].ToString());
                    sum1 = sum1 + q;
               }
            }
            if (sum == sum1)
            {
                Console.WriteLine("String is a valid String");
            }
            else
            {
                Console.WriteLine("String is not a valid string");
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum1);

        } 
    }
}
