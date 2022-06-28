using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.RevisionLect
{
  class ArithmeticProgression
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Enter 2nd Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 3rd Number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int diff = 4;
                int nth = 7;
                int first = num1 - diff;
                int AP = first + (nth - 1) * diff;
                Console.WriteLine(AP);
            
        }
    }
    
}
