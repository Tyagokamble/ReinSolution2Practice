using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class ConstructerTypeDemo
    {
        
        ConstructerTypeDemo()
        {
            Console.WriteLine("hii i am Constructer Demo");
        }
        ConstructerTypeDemo(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            ConstructerTypeDemo d = new ConstructerTypeDemo();
            ConstructerTypeDemo d2 = new ConstructerTypeDemo(5,8);


        }
    }
}
