using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
   class Pattern1To5Table
    {
        static void Main(string[] args)
        {
            
                for (int i = 1; i <= 5; i++)
            {
                for (int j=1;j<=10; j++)
                {
                    Console.WriteLine(j*i );
                }
                Console.Write(" ");
            }
        }
    }
}
