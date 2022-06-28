using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class Static_MethodOverLoading
    {
        public static void cal(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void cal(double a, double b)
        {
            Console.WriteLine(a-b);
        }
        static void Main(string[] args)
        {
            Static_MethodOverLoading.cal(12,23);
            Static_MethodOverLoading.cal(3.4,9.5);
        }

    }
}
