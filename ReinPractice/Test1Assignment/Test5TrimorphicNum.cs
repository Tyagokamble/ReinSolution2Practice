using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions.Test1Assignment
{
   class Test5TrimorphicNum
    {
        static void Main(string[] args)
        {
           int num = Convert.ToInt32(Console.ReadLine());
           int  cube = num * num * num;
            if (num % 10 == cube % 10)
            {
                Console.WriteLine("number is trimorphic");
            }
            else
            {
                Console.WriteLine("Number is not Trimorphic");

            }
        }
    }
}
