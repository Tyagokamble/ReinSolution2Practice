using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    static class parameter
    {
        static int a = 5;
        static int b = 9;
    }
    class StaticDemo1
    {
        int x = 10;
        static int y = 20;

        void write()
        {
            Console.WriteLine("hii write");
        }
        static void read()
        {
            Console.WriteLine("hii read"); 
        }
        static StaticDemo1()
        {
            Console.WriteLine("hii i m consturcter");
        }
        static void Main(string[] args)
        {
            StaticDemo1 d = new StaticDemo1();
            Console.WriteLine(d.x);
            Console.WriteLine(y);
            Console.WriteLine();
            read();
            d.write();

            

        }
    }
}
