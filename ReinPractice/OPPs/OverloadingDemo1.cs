using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class OverloadingDemo1
    {
        void area(int r)
        {
            Console.WriteLine("area of circle"+3.14*r*r);
        }
        void area(int length,int bredth)
        {
            Console.WriteLine("area of rectangle"+2*length*bredth);
        }
        void area(double b )
        {
            Console.WriteLine("area of square" +   b*b);
        }
        void area(float base1, float height)
        {
            Console.WriteLine("area of triangle" + 1/2 * base1 * height);
        }
        static void Main(string[] args)
        {
            OverloadingDemo1 s = new OverloadingDemo1();
            s.area(20.59);
            s.area(5);
            s.area(8, 5);
            s.area(5.0f, 7.0f);
        }
    }
}
