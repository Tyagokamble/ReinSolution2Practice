using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class ConstructerOverloading
    {
           ConstructerOverloading()
        {
            Console.WriteLine("hii i m constructer overloading");
            
        }
        ConstructerOverloading(int a,int b)
        {
            Console.WriteLine("hii i m constructer overloading2"+ (a+b));
        }

        static void Main(string[] args)
        {

            ConstructerOverloading s1 = new ConstructerOverloading();
            ConstructerOverloading s2 = new ConstructerOverloading(2,5);
            



        }
    }
}
