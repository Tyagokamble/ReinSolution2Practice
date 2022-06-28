using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
   
    class StaticExample
    {
        static int a = 5;             
        int b = 10;

    static StaticExample() 
        {
            Console.WriteLine("hii i am static constructer");
        
        }
     static void show()
        {
            Console.WriteLine("hii i m static method");
        }
        static void Main(string[] args)
        {
            StaticExample s = new StaticExample();
            StaticExample.show();
        }
    }
}
