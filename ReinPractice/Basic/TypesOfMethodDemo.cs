using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class TypesOfMethodDemo
    {
        public void show_Data()                       //user defined method
        {
            Console.WriteLine("hi i am show");
        }  
        
        public void addition(int a,int b)            // parameterized method
        {
            Console.WriteLine("addition"+(a+b));       
        }
        public string myFoo()                       // return type method
        {
            return "Hello";
        }

        public int add()
        {
            return 10 + 30;
        }
        public float areaOfCircle(int r,float PI)
        {
            float area = PI * r * r;
            return area;
        }
        static void Main(string[] args)
        {
            TypesOfMethodDemo m = new TypesOfMethodDemo();
            m.show_Data();
            m.addition(7, 5);
            float a = m.areaOfCircle(4, 3.14f);
            Console.WriteLine("Area of circle"+a);


        }
    }  
}
