using System;
using System.Collections.Generic;
using System.Text;

namespace ReinPractice.Basic
{
    class FriendsAge
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter age :");
            age=Convert.ToInt32(Console.ReadLine());
            if (age < 19)
            {
                Console.WriteLine("Teenger");
            }
            else
            {
                Console.WriteLine("Not Teenager");
            }
        }
    }
}
