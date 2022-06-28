using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    class HierarchicalInheritanceExampleDemo
    {
        class Shape
        {
            public int side = 0;
            public string shape = "round";
            public void MyShape()
            {
                Console.WriteLine( side);
            }

        }
        class Circle:Shape
        {
        public void show ()
            {
                side = 1;
                Console.WriteLine("side of circle" + shape);
            }
        }
        class Square:Shape
        {
            public void display()
            {
                side = 4;
                Console.WriteLine("side of Circle"+side );
            }
        }
        class Triangle : Shape
        {
            public void output() 
            {
                side = 3;
                Console.WriteLine("side of Triangle"+side);
            }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.show();
            Square s = new Square();
            s.display();
            Triangle t = new Triangle();
            t.output();
        }
    }
}
