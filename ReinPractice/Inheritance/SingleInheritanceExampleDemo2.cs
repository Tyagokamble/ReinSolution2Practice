using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.OPPs
{
    
        class Shape
        {
            public int area = 256;
        }

        class Circle:Shape
        {
            public void AreaCir()
            {
                Console.WriteLine("Area of Circle"+area);
            }
            
        }

        class SingleInheritanceExampleDemo2
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.AreaCir();
            }
        }
    
}
