using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class StaticMethod
    {
            void show()
        {
            Console.WriteLine("hi this is show");
        }
           static void read()
        {
            Console.WriteLine("hi this is read");
        }
        static void Main(string[] args)
        {
            StaticMethod d = new StaticMethod();
            d.show();
            StaticMethod.read();
            read();


        }
    }
}
