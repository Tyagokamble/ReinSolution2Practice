using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class StaticDemo
    {
        int x = 0;
        static int c = 0;

        public StaticDemo()
        {
            x++;
            Console.WriteLine("x"+ x);
            c++;
            Console.WriteLine("c" +  c);
        }
        static void Main(string[] args)
        {
            StaticDemo d = new StaticDemo();
            StaticDemo d1 = new StaticDemo();
            StaticDemo d2 = new StaticDemo();
        }
    }
}
