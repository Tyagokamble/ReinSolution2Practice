using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class Weekday
    {
        static void Main(string[] args)
        { int weekday;
            Console.WriteLine("Enter weekday numbers(0-6):");
            weekday = Convert.ToInt32(Console.ReadLine());
            switch (weekday)
            {
                case 0:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 2:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("It's FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("It's SATURDAY");
                    break;
                default:
                    Console.WriteLine("its a wrong input");
                    break;
            }
        }
    }
}
