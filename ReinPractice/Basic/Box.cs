using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class Box
    {
         int length;
       
        
        static void Main(string[] args)
        {
            Box A = new Box();
            A.length = 4;
            int Area;
            
            Area = 6 *A.length*A.length;

            Console.WriteLine(Area);

        }
    }
}
