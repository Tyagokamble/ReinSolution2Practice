using System;

namespace ReinPractice.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 5)
            {
                Console.WriteLine("number is greter than 5"+num);

            }
      
            else
            {
                Console.WriteLine("number is less than 5"+num);
            }
            
           
        }
    }
}
